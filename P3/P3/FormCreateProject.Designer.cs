namespace P3
{
    partial class FormCreateProject
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
            this.AddProjectNameBox = new System.Windows.Forms.TextBox();
            this.AddProjectButton = new System.Windows.Forms.Button();
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddProjectNameBox
            // 
            this.AddProjectNameBox.Location = new System.Drawing.Point(145, 70);
            this.AddProjectNameBox.Name = "AddProjectNameBox";
            this.AddProjectNameBox.Size = new System.Drawing.Size(272, 22);
            this.AddProjectNameBox.TabIndex = 0;
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Location = new System.Drawing.Point(342, 133);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(75, 23);
            this.AddProjectButton.TabIndex = 1;
            this.AddProjectButton.Text = "Add";
            this.AddProjectButton.UseVisualStyleBackColor = true;
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.Location = new System.Drawing.Point(205, 133);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAddButton.TabIndex = 2;
            this.CancelAddButton.Text = "Cancel";
            this.CancelAddButton.UseVisualStyleBackColor = true;
            this.CancelAddButton.Click += new System.EventHandler(this.CancelAddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name:";
            // 
            // FormCreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.AddProjectButton);
            this.Controls.Add(this.AddProjectNameBox);
            this.Name = "FormCreateProject";
            this.Text = "Create Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddProjectNameBox;
        private System.Windows.Forms.Button AddProjectButton;
        private System.Windows.Forms.Button CancelAddButton;
        private System.Windows.Forms.Label label1;
    }
}