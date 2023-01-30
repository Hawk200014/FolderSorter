namespace FolderSorter.Forms
{
    partial class SortKeyDialog
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(658, 31);
            this.textBox1.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.Location = new System.Drawing.Point(574, 49);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(96, 34);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackBtn.Location = new System.Drawing.Point(472, 49);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(96, 34);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            // 
            // SortKeyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 94);
            this.ControlBox = false;
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "SortKeyDialog";
            this.Text = "Add Sort Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button SaveBtn;
        private Button BackBtn;
    }
}