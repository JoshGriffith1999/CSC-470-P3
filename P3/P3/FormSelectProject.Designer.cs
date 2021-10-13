namespace P3
{
    partial class FormSelectProject
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
            this.SelectProjectListBox = new System.Windows.Forms.ListBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectProjectListBox
            // 
            this.SelectProjectListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectProjectListBox.FormattingEnabled = true;
            this.SelectProjectListBox.ItemHeight = 20;
            this.SelectProjectListBox.Location = new System.Drawing.Point(29, 29);
            this.SelectProjectListBox.Name = "SelectProjectListBox";
            this.SelectProjectListBox.Size = new System.Drawing.Size(452, 224);
            this.SelectProjectListBox.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(198, 296);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(106, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectProjectButton
            // 
            this.SelectProjectButton.Location = new System.Drawing.Point(375, 296);
            this.SelectProjectButton.Name = "SelectProjectButton";
            this.SelectProjectButton.Size = new System.Drawing.Size(106, 23);
            this.SelectProjectButton.TabIndex = 2;
            this.SelectProjectButton.Text = "Select Project";
            this.SelectProjectButton.UseVisualStyleBackColor = true;
            this.SelectProjectButton.Click += new System.EventHandler(this.SelectProjectButton_Click);
            // 
            // FormSelectProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 350);
            this.Controls.Add(this.SelectProjectButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectProjectListBox);
            this.Name = "FormSelectProject";
            this.Text = "Select Project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SelectProjectListBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectProjectButton;
    }
}