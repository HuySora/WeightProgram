using System.Windows.Forms;

namespace WeightProgram.ExForm {
    public class ExtendedForm<TMdiForm> : Form where TMdiForm : Form {
        public new TMdiForm MdiParent {
            get => (TMdiForm)base.MdiParent;
            set => base.MdiParent = value;
        }
    }
}
