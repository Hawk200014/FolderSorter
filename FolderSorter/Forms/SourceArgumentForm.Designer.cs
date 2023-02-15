namespace FolderSorter.Forms
{
    partial class SourceArgumentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addSourceElementBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.sourceElementListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addSourceElementBtn
            // 
            this.addSourceElementBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addSourceElementBtn.Location = new System.Drawing.Point(884, 12);
            this.addSourceElementBtn.Name = "addSourceElementBtn";
            this.addSourceElementBtn.Size = new System.Drawing.Size(130, 44);
            this.addSourceElementBtn.TabIndex = 3;
            this.addSourceElementBtn.Text = "Add";
            this.addSourceElementBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveBtn.Location = new System.Drawing.Point(748, 12);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(130, 44);
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(130, 44);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // sourceElementListBox
            // 
            this.sourceElementListBox.FormattingEnabled = true;
            this.sourceElementListBox.ItemHeight = 15;
            this.sourceElementListBox.Location = new System.Drawing.Point(12, 62);
            this.sourceElementListBox.Name = "sourceElementListBox";
            this.sourceElementListBox.Size = new System.Drawing.Size(1002, 529);
            this.sourceElementListBox.TabIndex = 6;
            // 
            // SourceArgumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 612);
            this.Controls.Add(this.sourceElementListBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.addSourceElementBtn);
            this.Name = "SourceArgumentForm";
            this.Text = "SourceArgumentForm";
            this.Load += new System.EventHandler(this.SourceArgumentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button addSourceElementBtn;
        private Button RemoveBtn;
        private Button backBtn;
        private ListBox sourceElementListBox;
    }
}