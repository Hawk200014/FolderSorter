namespace FolderSorter.Forms
{
    partial class SorterArgumentForm
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
            this.sortElementsListBox = new System.Windows.Forms.ListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.AddSortElementBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sortElementsListBox
            // 
            this.sortElementsListBox.FormattingEnabled = true;
            this.sortElementsListBox.ItemHeight = 15;
            this.sortElementsListBox.Location = new System.Drawing.Point(12, 68);
            this.sortElementsListBox.Name = "sortElementsListBox";
            this.sortElementsListBox.Size = new System.Drawing.Size(1002, 529);
            this.sortElementsListBox.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(130, 44);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AddSortElementBtn
            // 
            this.AddSortElementBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddSortElementBtn.Location = new System.Drawing.Point(884, 12);
            this.AddSortElementBtn.Name = "AddSortElementBtn";
            this.AddSortElementBtn.Size = new System.Drawing.Size(130, 44);
            this.AddSortElementBtn.TabIndex = 2;
            this.AddSortElementBtn.Text = "Add";
            this.AddSortElementBtn.UseVisualStyleBackColor = true;
            this.AddSortElementBtn.Click += new System.EventHandler(this.AddSortElementBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveBtn.Location = new System.Drawing.Point(748, 12);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(130, 44);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // SorterArgumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 612);
            this.ControlBox = false;
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddSortElementBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.sortElementsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SorterArgumentForm";
            this.Text = "SelectFolder";
            this.Load += new System.EventHandler(this.SelectFolder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox sortElementsListBox;
        private Button backBtn;
        private Button AddSortElementBtn;
        private Button RemoveBtn;
    }
}