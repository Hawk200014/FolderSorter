using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderSorter.Forms
{
    public partial class SorterArgumentForm : Form
    {
        public SorterArgumentForm()
        {
            InitializeComponent();
            UpdateList();
        }

        private void SelectFolder_Load(object sender, EventArgs e)
        {

        }



        public void UpdateList()
        {
            sortElementsListBox.Items.Clear();
            foreach(SortListArgumentElement element in Program.sortArgumentsStorage.sortListArguments)
            {
                sortElementsListBox.Items.Add(element.ToStringListView());
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormsStorage.form1.Show();
            FormsStorage.sorterArgumentForm.Hide();
        }

        private void AddSortElementBtn_Click(object sender, EventArgs e)
        {
            new SortArgumentAddForm().Show();
            FormsStorage.sorterArgumentForm.Hide();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if(sortElementsListBox.SelectedItem == null)
            {
                MessageBox.Show("To remove an element you need to select one.");
                return;
            }
            int curItem = sortElementsListBox.FindString( sortElementsListBox.SelectedItem.ToString());
            SortListArgumentElement slae = Program.sortArgumentsStorage.sortListArguments.ElementAt(curItem);
            Program.sortArgumentsStorage.RemoveArgumentElement(slae.guid);
            UpdateList();
        }
    }
}
