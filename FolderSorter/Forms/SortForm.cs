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
            List<string> files = new List<string>();
            CopyFileToDirectory copyFileToDirectory = new CopyFileToDirectory();
            FileManager fm = new FileManager();
            List<SortListArgumentElement> argumentList = Program.sortArgumentsStorage.sortListArguments;
            foreach(SortListArgumentElement argument in argumentList)
            {
                foreach(string key in argument.sortKey)
                {
                    
                    string[] allfiles = copyFileToDirectory.GetFilesWithName(fm.GetSourceFolderPath(), key);
                    foreach (string file in allfiles)
                    {
                        if(!CheckIfAllreadyInList(files, file))
                        {
                            files.Add(file);
                        }
                    }
                }
            }
            return files.Count;
        }

        private bool CheckIfAllreadyInList(List<string> files, string file)
        {
            foreach(string testfile in files)
            {
                if(testfile == file)
                {
                    return true;
                }
            }
            return false;
        }


        private void SortBtn_Click(object sender, EventArgs e)
        {
            int max = CountFilesToSort();
            int sorted = 0;
            int notSorted = 0;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = max;
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
                        sorted++;
                        progressBar1.Value = sorted;
                    }
                }
            }
            if(notSorted > 0)
            {
                MessageBox.Show(notSorted + " elements got not sorted");
            }
            else
            {
                MessageBox.Show(sorted + " elements got sorted");
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
