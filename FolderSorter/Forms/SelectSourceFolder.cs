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
    public partial class SelectSourceFolder : Form
    {
        public SelectSourceFolder()
        {
            InitializeComponent();
        }

        private void SelectFolder_Load(object sender, EventArgs e)
        {
 
        }

        private void SelectSourceFolder_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormsStorage.form1.UpdateAndShow();
        }
    }
}
