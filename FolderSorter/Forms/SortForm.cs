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
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
            CountFilesToSort();
            countLbl.Text = CountFilesToSort() + " elements to sort";
        }

        private int CountFilesToSort()
        {
            CopyFileToDirectory copyFileToDirectory = new CopyFileToDirectory();
            FileManager fm = new FileManager();
            List<SortListArgumentElement> argumentList = Program.sortArgumentsStorage.sortListArguments;
            int filecount = 0;
            foreach(SortListArgumentElement argument in argumentList)
            {
                foreach(string key in argument.sortKey)
                {
                    filecount += copyFileToDirectory.CountFilesWithName(fm.GetSourceFolderPath(), key);
                }
            }
            return filecount;
        }



        private void SortBtn_Click(object sender, EventArgs e)
        {
            int max = CountFilesToSort();
            int sortet = 0;
            progressBar1.Value = 0;
            progressBar1.Minimum= 0;
            progressBar1.Maximum= max;
            int notSorted = 0;
            CopyFileToDirectory copyFileToDirectory = new CopyFileToDirectory();
            FileManager fm = new FileManager();
            List<SortListArgumentElement> argumentList = Program.sortArgumentsStorage.sortListArguments;
            foreach (SortListArgumentElement argument in argumentList)
            {
                foreach (string key in argument.sortKey)
                {
                    string[] files = copyFileToDirectory.GetFilesWithName(fm.GetSourceFolderPath(), key);
                    foreach (string file in files)
                    {
                        if(!CopyFileToDirectory.CpFtoDir(file, argument.sortDirectory))
                        {
                            notSorted++;
                        }
                        progressBar1.Value++;
                    }
                }
            }
            if(notSorted > 0)
            {
                MessageBox.Show(notSorted + " elements got not sorted");
            }
            progressBar1.Value = 0;
            countLbl.Text = CountFilesToSort() + " elements to sort";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            FormsStorage.form1.Show();
            this.Close();
        }
    }
}
