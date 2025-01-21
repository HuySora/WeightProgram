using System;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
using WeightProgram.Data;

namespace WeightProgram {
    public partial class MainForm : Form {
        private WeightInputForm m_WeightInputForm;
        private string m_WeightInputFormName = "WeightInputForm";

        public WeightProgramModelContainer DbContext { get; private set; }

        private ToolStripStatusLabel lbl_DatabaseStatus;

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
            DbContext.WeightDatum.Find(0); // Initialize database connection
            // Status strip
            lbl_DatabaseStatus = new ToolStripStatusLabel();
            lbl_DatabaseStatus.Alignment = ToolStripItemAlignment.Left;
            statusStrip.Items.Add(lbl_DatabaseStatus);
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
        }
        #endregion
    }
}
