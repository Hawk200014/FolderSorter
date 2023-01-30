namespace FolderSorter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SortArgumentsListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SourcePathLbl = new System.Windows.Forms.Label();
            this.SourceFolderBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SortArgumentsListBtn
            // 
            this.SortArgumentsListBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortArgumentsListBtn.Location = new System.Drawing.Point(300, 151);
            this.SortArgumentsListBtn.Name = "SortArgumentsListBtn";
            this.SortArgumentsListBtn.Size = new System.Drawing.Size(213, 34);
            this.SortArgumentsListBtn.TabIndex = 0;
            this.SortArgumentsListBtn.Text = "Sorter List";
            this.SortArgumentsListBtn.UseVisualStyleBackColor = true;
            this.SortArgumentsListBtn.Click += new System.EventHandler(this.SortArgumentsListBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Folder:";
            // 
            // SourcePathLbl
            // 
            this.SourcePathLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourcePathLbl.Location = new System.Drawing.Point(143, 18);
            this.SourcePathLbl.Name = "SourcePathLbl";
            this.SourcePathLbl.Size = new System.Drawing.Size(464, 25);
            this.SourcePathLbl.TabIndex = 2;
            this.SourcePathLbl.Text = "label2";
            // 
            // SourceFolderBtn
            // 
            this.SourceFolderBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SourceFolderBtn.Location = new System.Drawing.Point(645, 12);
            this.SourceFolderBtn.Name = "SourceFolderBtn";
            this.SourceFolderBtn.Size = new System.Drawing.Size(143, 34);
            this.SourceFolderBtn.TabIndex = 3;
            this.SourceFolderBtn.Text = "Source Folder";
            this.SourceFolderBtn.UseVisualStyleBackColor = true;
            this.SourceFolderBtn.Click += new System.EventHandler(this.SourceFolderBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sortBtn.Location = new System.Drawing.Point(266, 244);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(292, 93);
            this.sortBtn.TabIndex = 4;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.SourceFolderBtn);
            this.Controls.Add(this.SourcePathLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortArgumentsListBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SortArgumentsListBtn;
        private Label label1;
        private Label SourcePathLbl;
        private Button SourceFolderBtn;
        private Button sortBtn;
    }
}