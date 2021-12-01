namespace P3
{
    partial class FormModifyFeature
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
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ModifyFeatureButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title: ";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(98, 51);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(352, 22);
            this.TitleTextBox.TabIndex = 0;
            // 
            // ModifyFeatureButton
            // 
            this.ModifyFeatureButton.Location = new System.Drawing.Point(331, 99);
            this.ModifyFeatureButton.Name = "ModifyFeatureButton";
            this.ModifyFeatureButton.Size = new System.Drawing.Size(118, 23);
            this.ModifyFeatureButton.TabIndex = 2;
            this.ModifyFeatureButton.Text = "Modify Feature";
            this.ModifyFeatureButton.UseVisualStyleBackColor = true;
            this.ModifyFeatureButton.Click += new System.EventHandler(this.ModifyFeatureButton_Click_1);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(193, 99);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(118, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // FormModifyFeature
            // 
            this.ClientSize = new System.Drawing.Size(651, 159);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ModifyFeatureButton);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormModifyFeature";
            this.Text = "Modify Feature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button ModifyFeatureButton;
        private System.Windows.Forms.Button CancelButton;
    }
}