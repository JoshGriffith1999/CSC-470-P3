
namespace P3
{
    partial class FormModifyIssue
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
            this.InitialDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ModifyIssueButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComponentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DiscovererCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DiscoveryTimeDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InitialDescriptionTextBox
            // 
            this.InitialDescriptionTextBox.Location = new System.Drawing.Point(220, 229);
            this.InitialDescriptionTextBox.Multiline = true;
            this.InitialDescriptionTextBox.Name = "InitialDescriptionTextBox";
            this.InitialDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InitialDescriptionTextBox.Size = new System.Drawing.Size(372, 242);
            this.InitialDescriptionTextBox.TabIndex = 23;
            // 
            // ModifyIssueButton
            // 
            this.ModifyIssueButton.Location = new System.Drawing.Point(468, 492);
            this.ModifyIssueButton.Name = "ModifyIssueButton";
            this.ModifyIssueButton.Size = new System.Drawing.Size(124, 29);
            this.ModifyIssueButton.TabIndex = 26;
            this.ModifyIssueButton.TabStop = false;
            this.ModifyIssueButton.Text = "Modify Issue";
            this.ModifyIssueButton.UseVisualStyleBackColor = true;
            this.ModifyIssueButton.Click += new System.EventHandler(this.ModifyIssueButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(324, 492);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(109, 29);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Initial Description";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Open",
            "Assigned",
            "Fixed",
            "Closed - Won\'t Fix",
            "Closed - Fixed",
            "Closed - by design"});
            this.comboBox1.Location = new System.Drawing.Point(220, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Status:";
            // 
            // ComponentTextBox
            // 
            this.ComponentTextBox.Location = new System.Drawing.Point(220, 132);
            this.ComponentTextBox.Name = "ComponentTextBox";
            this.ComponentTextBox.Size = new System.Drawing.Size(372, 22);
            this.ComponentTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Component:";
            // 
            // DiscovererCombo
            // 
            this.DiscovererCombo.FormattingEnabled = true;
            this.DiscovererCombo.Location = new System.Drawing.Point(220, 97);
            this.DiscovererCombo.Name = "DiscovererCombo";
            this.DiscovererCombo.Size = new System.Drawing.Size(371, 24);
            this.DiscovererCombo.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Discoverer:";
            // 
            // DiscoveryTimeDate
            // 
            this.DiscoveryTimeDate.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.DiscoveryTimeDate.CustomFormat = "h\':\'m\':\'ss tt d, MMM yyyy";
            this.DiscoveryTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DiscoveryTimeDate.Location = new System.Drawing.Point(221, 65);
            this.DiscoveryTimeDate.MaxDate = new System.DateTime(2021, 11, 13, 0, 0, 0, 0);
            this.DiscoveryTimeDate.Name = "DiscoveryTimeDate";
            this.DiscoveryTimeDate.RightToLeftLayout = true;
            this.DiscoveryTimeDate.Size = new System.Drawing.Size(371, 22);
            this.DiscoveryTimeDate.TabIndex = 17;
            this.DiscoveryTimeDate.Value = new System.DateTime(2021, 11, 13, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Discovery Date:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(221, 33);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(371, 22);
            this.TitleTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Title:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(272, -34);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(85, 22);
            this.IDTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, -28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id:";
            // 
            // FormModifyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 601);
            this.Controls.Add(this.InitialDescriptionTextBox);
            this.Controls.Add(this.ModifyIssueButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComponentTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DiscovererCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DiscoveryTimeDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormModifyIssue";
            this.Text = "FormModifyIssue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InitialDescriptionTextBox;
        private System.Windows.Forms.Button ModifyIssueButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ComponentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DiscovererCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DiscoveryTimeDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}