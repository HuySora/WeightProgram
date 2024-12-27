using System.Windows.Forms;

namespace WeightProgram {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            ResizeBegin += (s, e) => { SuspendLayout(); };
            ResizeEnd += (s, e) => { ResumeLayout(true); };
        }
    }
}
