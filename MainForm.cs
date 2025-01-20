using System;
using System.Windows.Forms;

namespace WeightProgram {
    public partial class MainForm : Form {
        private WeightInputForm m_WeightInputForm;
        private string m_WeightInputFormName = "WeightInputForm";
        public MainForm() {
            InitializeComponent();
            ResizeBegin += (s, e) => { SuspendLayout(); };
            ResizeEnd += (s, e) => { ResumeLayout(true); };
        }

        #region Controls event
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
    }
}
