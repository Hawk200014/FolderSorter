using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FolderSorter.Forms
{
    public partial class SortArgumentAddForm : Form
    {
        ToolTip desFormtooltip;
        public SortArgumentAddForm()
        {
            InitializeComponent();
            desFormtooltip = new ToolTip();
            desFormtooltip.AutoPopDelay = 5000;
            desFormtooltip.ReshowDelay = 500;
            desFormtooltip.InitialDelay = 1000;
            desFormtooltip.ShowAlways = true;
            desFormtooltip.SetToolTip(destTextBox, destTextBox.Text);
        }

        private void SortArgumentAddForm_Load(object sender, EventArgs e)
        {

        }

        private void SortArgumentAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormsStorage.sorterArgumentForm.UpdateList();
            FormsStorage.sorterArgumentForm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DestFolderSelectBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                string path = dialog.SelectedPath;
                destTextBox.Text = path;
                desFormtooltip.SetToolTip(destTextBox, destTextBox.Text);
            }
        }

        private void AddSortKeyBtn_Click(object sender, EventArgs e)
        {
            SortKeyDialog skd = new SortKeyDialog();
            skd.AcceptButton = skd.getSaveButton();
            skd.CancelButton = skd.getCancleButton();
            TextBox tb = skd.GetTextDialog();
            DialogResult dialogResult = skd.ShowDialog();
            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(tb.Text))
            {
                listBox1.Items.Add(tb.Text);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormsStorage.sorterArgumentForm.Show();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1)
            {
                MessageBox.Show("To save that sort argument it need at least 1 sortkey.");
                return; 
            }
            if (!InputValid())
            {
                MessageBox.Show("Your input is not Valid. Please check if all fields are filled.");
                return;
            }
            List<string> list = new List<string>();
            foreach(string item in listBox1.Items)
            {
                list.Add(item);
            }
            SortListArgumentElement sortListArgumentElement = new SortListArgumentElement(SortNameTextBox.Text, destTextBox.Text, list, 0, Guid.NewGuid().ToString());
            Program.sortArgumentsStorage.sortListArguments.Add(sortListArgumentElement);
            Program.sortArgumentsStorage.SaveArgumentElements();
            FormsStorage.sorterArgumentForm.UpdateList();
            FormsStorage.sorterArgumentForm.Show();
            this.Close();
        }

        private bool InputValid()
        {
            string input = SortNameTextBox.Text;
            if (string.IsNullOrEmpty(input.Trim())) { return false; }
            input = destTextBox.Text;
            if (string.IsNullOrEmpty(input.Trim())) { return false; }
            return true;
        }
    }
}
