using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Zeo {
    public partial class FormManageSeries : System.Windows.Forms.Form {
        public string[] followingSeries = null;
        public string path = null;
        public string[] updatedList = null;

        public FormManageSeries() {
            InitializeComponent();
        }

        private void FormManageSeries_Load(object sender, EventArgs e) {
            if(followingSeries != null)
                foreach (String series in followingSeries)
                    listBoxFollowingSeries.Items.Add(series);
        }

        private void buttonAddSeries_Click(object sender, EventArgs e) {
            FormInputModal form = new FormInputModal();
            if (form.ShowDialog() == DialogResult.OK) {
                listBoxFollowingSeries.Items.Add(form.input);
                listBoxFollowingSeries.Refresh();
            }

            form.Dispose();
        }

        private void buttonEditSeries_Click(object sender, EventArgs e) {
            var item = listBoxFollowingSeries.SelectedItem;
            if (item != null) {
                FormInputModal form = new FormInputModal();
                form.input = (string)item;
                if (form.ShowDialog() == DialogResult.OK) {
                    listBoxFollowingSeries.Items[listBoxFollowingSeries.SelectedIndex] = form.input;
                    listBoxFollowingSeries.Refresh();
                }

                form.Dispose();
            }
        }

        private void buttonDeleteSeries_Click(object sender, EventArgs e) {
            var item = listBoxFollowingSeries.SelectedItem;
            if (item != null)
                listBoxFollowingSeries.Items.Remove(item);
        }

        private void FormManageSeries_FormClosed(object sender, FormClosedEventArgs e) {
            updatedList = listBoxFollowingSeries.Items.OfType<string>().ToArray();
            File.WriteAllLines(path, updatedList);
            this.DialogResult = DialogResult.OK;
        }
    }
}
