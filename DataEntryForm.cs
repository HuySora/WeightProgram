using System.Windows.Forms;

namespace WeightProgram {
    public partial class DataEntryForm : Form {
        public DataEntryForm() {
            InitializeComponent();
            ResizeBegin += (s, e) => { SuspendLayout(); };
            ResizeEnd += (s, e) => { ResumeLayout(true); };
        }
    }
}
