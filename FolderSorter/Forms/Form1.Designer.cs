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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SourcePathLbl = new System.Windows.Forms.Label();
            this.SourceFolderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(325, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sorter List";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Folder:";
            // 
            // SourcePathLbl
            // 
            this.SourcePathLbl.Location = new System.Drawing.Point(126, 21);
            this.SourcePathLbl.Name = "SourcePathLbl";
            this.SourcePathLbl.Size = new System.Drawing.Size(514, 15);
            this.SourcePathLbl.TabIndex = 2;
            this.SourcePathLbl.Text = "label2";
            this.SourcePathLbl.MouseHover += new System.EventHandler(this.SourcePathLbl_MouseHover);
            // 
            // SourceFolderBtn
            // 
            this.SourceFolderBtn.Location = new System.Drawing.Point(646, 17);
            this.SourceFolderBtn.Name = "SourceFolderBtn";
            this.SourceFolderBtn.Size = new System.Drawing.Size(108, 23);
            this.SourceFolderBtn.TabIndex = 3;
            this.SourceFolderBtn.Text = "Set Source Folder";
            this.SourceFolderBtn.UseVisualStyleBackColor = true;
            this.SourceFolderBtn.Click += new System.EventHandler(this.SourceFolderBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SourceFolderBtn);
            this.Controls.Add(this.SourcePathLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label SourcePathLbl;
        private Button SourceFolderBtn;
    }
}