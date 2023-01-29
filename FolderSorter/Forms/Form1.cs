
using System.Windows.Forms.VisualStyles;

namespace FolderSorter
{
    public partial class Form1 : Form
    {
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
            ToolTip toolTip= new ToolTip();
            toolTip.AutoPopDelay= 5000;
            toolTip.ReshowDelay= 500;
            toolTip.InitialDelay= 1000;
            toolTip.ShowAlways= true;
            toolTip.SetToolTip(SourcePathLbl, SourcePathLbl.Text);
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
    }
}