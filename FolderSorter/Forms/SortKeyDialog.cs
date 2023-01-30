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
    public partial class SortKeyDialog : Form
    {
        public SortKeyDialog()
        {
            InitializeComponent();
            
        }

        public Button getSaveButton()
        {
            return SaveBtn;
        }

        public Button getCancleButton()
        {
            return BackBtn;
        }

        public TextBox GetTextDialog()
        {
            return textBox1;
        }

    }
}
