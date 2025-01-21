using System;
using System.Windows.Forms;

namespace WeightProgram {
    public partial class WeightDataReceiptReportViewerForm : Form {
        public WeightDataReceiptReportViewerForm() {
            InitializeComponent();
        }

        private void WeightDataReceiptReportViewerForm_Load(object sender, EventArgs e) {

            this.reportViewer.RefreshReport();
        }
    }
}
