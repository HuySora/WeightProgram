using System;
using System.Data.Common;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using WeightProgram.Data;

namespace WeightProgram {
    public partial class MainForm : Form {
        public static Random Random = new Random();

        private WeightInputForm m_WeightInputForm;
        private string m_WeightInputFormName = "WeightInputForm";

        public WeightProgramModelContainer DbContext { get; private set; }
        public WeightDataService WeightDataService { get; private set; }

        public int CurrentScaleWeight { get; private set; }
        private SerialPort m_SerialPort;
        private StringBuilder m_InputBuffer;

        private ToolStripStatusLabel lbl_DatabaseStatus;
        private ToolStripStatusLabel lbl_SerialPortStatus;

        public Timer UpdateTimer { get; private set; }

        public MainForm() {
            InitializeComponent();
            ResizeBegin += (s, e) => { SuspendLayout(); };
            ResizeEnd += (s, e) => { ResumeLayout(true); };
        }

        #region Controls event
        private void MainForm_Load(object sender, EventArgs e) {
            // Database
            DbContext = new WeightProgramModelContainer();
            WeightDataService = new WeightDataService(DbContext);
            DbContext.WeightDatum.Find(0); // Initialize database connection
            // SerialPort
            m_SerialPort = new SerialPort("COM1", 1200, Parity.Even, 7, StopBits.One);
            m_SerialPort.Encoding = Encoding.ASCII;
            m_SerialPort.DataReceived += SerialPort_DataReceived;
            // Status strip
            lbl_DatabaseStatus = new ToolStripStatusLabel();
            lbl_DatabaseStatus.Alignment = ToolStripItemAlignment.Left;
            statusStrip.Items.Add(lbl_DatabaseStatus);
            lbl_SerialPortStatus = new ToolStripStatusLabel();
            lbl_SerialPortStatus.Alignment = ToolStripItemAlignment.Left;
            statusStrip.Items.Add(lbl_SerialPortStatus);
            // Timer
            UpdateTimer = new Timer();
            UpdateTimer.Interval = 1000;
            UpdateTimer.Tick += UpdateTimer_Tick;
            UpdateTimer.Start();
        }
        private void btnOpenWeightInputForm_Click(object sender, EventArgs e) {
            if(m_WeightInputForm == null) {
                m_WeightInputForm = Application.OpenForms[m_WeightInputFormName] as WeightInputForm;
                if(m_WeightInputForm == null) {
                    m_WeightInputForm = new WeightInputForm() {
                        MdiParent = this,
                    };
                    // TODO Performance: Garbage collection
                    m_WeightInputForm.FormClosed += (x, y) => m_WeightInputForm = null;
                }
            }
            // QoL: Remember last window state instead of default to Normal
            if(m_WeightInputForm.WindowState == FormWindowState.Minimized) {
                m_WeightInputForm.WindowState = FormWindowState.Normal;
            }
            m_WeightInputForm.BringToFront();
            m_WeightInputForm.Show();
        }
        #endregion

        #region Timer event
        private void UpdateTimer_Tick(object sender, EventArgs e) {
            switch(DbContext.Database.Connection.State) {
                case System.Data.ConnectionState.Open:
                    lbl_DatabaseStatus.ForeColor = Color.Green;
                    break;
                case System.Data.ConnectionState.Connecting:
                    lbl_DatabaseStatus.ForeColor = Color.Yellow;
                    break;
                case System.Data.ConnectionState.Broken:
                case System.Data.ConnectionState.Closed:
                    lbl_DatabaseStatus.ForeColor = Color.Red;
                    break;
                default:
                    lbl_DatabaseStatus.ForeColor = Color.Red;
                    break;
            }
            lbl_DatabaseStatus.Text = $"Database={DbContext.Database.Connection.State}";
            // Try to reconnect to database if not connected
            try {
                if(DbContext.Database.Connection.State == System.Data.ConnectionState.Closed) {
                    DbContext.Database.Connection.Open();
                }
            } catch(DbException ex) {
                Console.WriteLine(ex.Message);
            }

            switch(m_SerialPort.IsOpen) {
                case true:
                    lbl_SerialPortStatus.ForeColor = Color.Green;
                    break;
                case false:
                    lbl_SerialPortStatus.ForeColor = Color.Red;
                    break;
            }
            // Try to reconnect SerialPort if not connected
            lbl_SerialPortStatus.Text = $"SerialPort={(m_SerialPort.IsOpen ? "Open" : "Closed")}";
            // TODO: Is there anyway to get serial port connection state string?
            try {
                if(!m_SerialPort.IsOpen) {
                    m_SerialPort.Open();
                }
            } catch(Exception ex) {
                lbl_SerialPortStatus.Text = $"SerialPort={ex.Message}";
            }
        }
        #endregion

        #region Other event
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            // Read the incoming data
            string incomingData = ((SerialPort)sender).ReadExisting();
            m_InputBuffer.Append(incomingData);
            // Cleanup unrelated data
            while(m_InputBuffer.Length > 1 && m_InputBuffer[0] != (char)2) {
                // Remove the first character
                m_InputBuffer.Remove(0, 1);
            }
            if(m_InputBuffer.Length >= 10) {
                // Get substring from index 4 to 9
                string strDisp = m_InputBuffer.ToString().Substring(4, 5);
                // Remove the first 15 characters
                m_InputBuffer.Remove(0, Math.Min(m_InputBuffer.Length, 15));
                if(int.TryParse(strDisp, out int weight)) {
                    CurrentScaleWeight = weight;
                }
            }
        }
        #endregion
    }
}
