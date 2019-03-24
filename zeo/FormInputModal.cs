using System.Windows.Forms;

namespace Zeo {
    public partial class FormInputModal : Form {
        public string input = null;

        public FormInputModal() {
            InitializeComponent();
        }

        private void FormEditSeries_Load(object sender, System.EventArgs e) {
            textBoxInput.Text = input;
        }

        private void buttonSave_Click(object sender, System.EventArgs e) {
            input = textBoxInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
