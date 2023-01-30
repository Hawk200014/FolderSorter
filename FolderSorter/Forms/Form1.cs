
using FolderSorter.Forms;
using System.Windows.Forms.VisualStyles;

namespace FolderSorter
{
    public partial class Form1 : Form
    {
        ToolTip sourcePathToolTip;
        public Form1()
        {
            InitializeComponent();
            FormsStorage.form1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FolderManager folderManager = new FolderManager();
            folderManager.CreateFolders();
            FileManager fileManager = new FileManager();
            if (!fileManager.SourceFileConfigExists())
            {
                SourcePathLbl.Text = "No Folder Selected";
            }
            else
            {
                SourcePathLbl.Text = fileManager.GetSourceFolderPath();
            }
            sourcePathToolTip = new ToolTip();
            sourcePathToolTip.AutoPopDelay= 5000;
            sourcePathToolTip.ReshowDelay= 500;
            sourcePathToolTip.InitialDelay= 1000;
            sourcePathToolTip.ShowAlways= true;
            sourcePathToolTip.SetToolTip(SourcePathLbl, SourcePathLbl.Text);
        }

        public void UpdateAndShow()
        {
            Update();
            this.Show();
        }

        public void Update()
        {
            FileManager fileManager = new FileManager();
            if (!fileManager.SourceFileConfigExists())
            {
                SourcePathLbl.Text = "No Folder Selected";
            }
            else
            {
                SourcePathLbl.Text = fileManager.GetSourceFolderPath();
            }
            sourcePathToolTip.SetToolTip(SourcePathLbl, SourcePathLbl.Text);
        }

        private void OpenSelectSourceForms()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult dialogResult = dialog.ShowDialog();
            if(dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                FileManager fm = new FileManager();
                fm.AddSourceFolderPathToConfig(dialog.SelectedPath);
                Update();
            }
        }

        private void SourceFolderBtn_Click(object sender, EventArgs e)
        {
            OpenSelectSourceForms();
            
        }

        private void SourcePathLbl_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void SortArgumentsListBtn_Click(object sender, EventArgs e)
        {
            if (FormsStorage.sorterArgumentForm == null)
            {
                FormsStorage.sorterArgumentForm = new Forms.SorterArgumentForm();
            }
            FormsStorage.sorterArgumentForm.Show();
            FormsStorage.form1.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.sortArgumentsStorage.SaveArgumentElements();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            new SortForm().Show();
            FormsStorage.form1.Hide();
        }
    }
}