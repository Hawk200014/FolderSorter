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
    public partial class SourceArgumentForm : Form
    {
        public SourceArgumentForm()
        {
            InitializeComponent();
            LoadList();
        }

        private void LoadList()
        {
            sourceElementListBox.Items.Clear();
            foreach(SourceListArgumentElement element in Program.sourceArgumentStorage)
            {
                sourceElementListBox.Items.Add(element.)
            }
            
        }

        public void Update()
        {
            LoadList();
        }



        private void backBtn_Click(object sender, EventArgs e)
        {
            FormsStorage.form1.Show();
            this.Hide();
        }

        private void SourceArgumentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
