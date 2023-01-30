namespace FolderSorter.Forms
{
    partial class SortArgumentAddForm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SortNameTextBox = new System.Windows.Forms.TextBox();
            this.SortNameLbl = new System.Windows.Forms.Label();
            this.destTextBox = new System.Windows.Forms.TextBox();
            this.DestLbl = new System.Windows.Forms.Label();
            this.DestFolderSelectBtn = new System.Windows.Forms.Button();
            this.AddSortKeyBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(687, 270);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(102, 31);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(160, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(629, 184);
            this.listBox1.TabIndex = 1;
            // 
            // SortNameTextBox
            // 
            this.SortNameTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortNameTextBox.Location = new System.Drawing.Point(160, 6);
            this.SortNameTextBox.MaxLength = 30;
            this.SortNameTextBox.Name = "SortNameTextBox";
            this.SortNameTextBox.PlaceholderText = "30 chars max";
            this.SortNameTextBox.Size = new System.Drawing.Size(629, 31);
            this.SortNameTextBox.TabIndex = 2;
            // 
            // SortNameLbl
            // 
            this.SortNameLbl.AutoSize = true;
            this.SortNameLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortNameLbl.Location = new System.Drawing.Point(12, 9);
            this.SortNameLbl.Name = "SortNameLbl";
            this.SortNameLbl.Size = new System.Drawing.Size(97, 25);
            this.SortNameLbl.TabIndex = 3;
            this.SortNameLbl.Text = "Sort Name";
            // 
            // destTextBox
            // 
            this.destTextBox.BackColor = System.Drawing.Color.LightGray;
            this.destTextBox.Enabled = false;
            this.destTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destTextBox.Location = new System.Drawing.Point(160, 43);
            this.destTextBox.Name = "destTextBox";
            this.destTextBox.Size = new System.Drawing.Size(629, 31);
            this.destTextBox.TabIndex = 4;
            this.destTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DestLbl
            // 
            this.DestLbl.AutoSize = true;
            this.DestLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DestLbl.Location = new System.Drawing.Point(12, 46);
            this.DestLbl.Name = "DestLbl";
            this.DestLbl.Size = new System.Drawing.Size(107, 25);
            this.DestLbl.TabIndex = 5;
            this.DestLbl.Text = "Dest. Folder";
            // 
            // DestFolderSelectBtn
            // 
            this.DestFolderSelectBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DestFolderSelectBtn.Location = new System.Drawing.Point(795, 42);
            this.DestFolderSelectBtn.Name = "DestFolderSelectBtn";
            this.DestFolderSelectBtn.Size = new System.Drawing.Size(75, 31);
            this.DestFolderSelectBtn.TabIndex = 6;
            this.DestFolderSelectBtn.Text = "Select";
            this.DestFolderSelectBtn.UseVisualStyleBackColor = true;
            this.DestFolderSelectBtn.Click += new System.EventHandler(this.DestFolderSelectBtn_Click);
            // 
            // AddSortKeyBtn
            // 
            this.AddSortKeyBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddSortKeyBtn.Location = new System.Drawing.Point(795, 80);
            this.AddSortKeyBtn.Name = "AddSortKeyBtn";
            this.AddSortKeyBtn.Size = new System.Drawing.Size(75, 31);
            this.AddSortKeyBtn.TabIndex = 7;
            this.AddSortKeyBtn.Text = "Add";
            this.AddSortKeyBtn.UseVisualStyleBackColor = true;
            this.AddSortKeyBtn.Click += new System.EventHandler(this.AddSortKeyBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(579, 270);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 31);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sort Keys";
            // 
            // SortArgumentAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 310);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.AddSortKeyBtn);
            this.Controls.Add(this.DestFolderSelectBtn);
            this.Controls.Add(this.DestLbl);
            this.Controls.Add(this.destTextBox);
            this.Controls.Add(this.SortNameLbl);
            this.Controls.Add(this.SortNameTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SortArgumentAddForm";
            this.Text = "SortArgumentAddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SortArgumentAddForm_FormClosing);
            this.Load += new System.EventHandler(this.SortArgumentAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveBtn;
        private ListBox listBox1;
        private TextBox SortNameTextBox;
        private Label SortNameLbl;
        private TextBox destTextBox;
        private Label DestLbl;
        private Button DestFolderSelectBtn;
        private Button AddSortKeyBtn;
        private Button backBtn;
        private Label label1;
    }
}