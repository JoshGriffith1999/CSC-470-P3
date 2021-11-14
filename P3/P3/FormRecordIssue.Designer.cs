namespace P3
{
    partial class FormRecordIssue
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
            System.Windows.Forms.TextBox InitialDescriptionTextBox;
            this.label1 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DiscoveryTimeDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DiscovererCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComponentTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateIssueButton = new System.Windows.Forms.Button();
            InitialDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(132, 42);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(85, 22);
            this.IDTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(132, 73);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(371, 22);
            this.TitleTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discovery Date:";
            // 
            // DiscoveryTimeDate
            // 
            this.DiscoveryTimeDate.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.DiscoveryTimeDate.CustomFormat = "h\':\'m\':\'ss tt d, MMM yyyy";
            this.DiscoveryTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DiscoveryTimeDate.Location = new System.Drawing.Point(132, 105);
            this.DiscoveryTimeDate.MaxDate = new System.DateTime(2021, 11, 13, 0, 0, 0, 0);
            this.DiscoveryTimeDate.Name = "DiscoveryTimeDate";
            this.DiscoveryTimeDate.RightToLeftLayout = true;
            this.DiscoveryTimeDate.Size = new System.Drawing.Size(371, 22);
            this.DiscoveryTimeDate.TabIndex = 5;
            this.DiscoveryTimeDate.Value = new System.DateTime(2021, 11, 13, 0, 0, 0, 0);
            this.DiscoveryTimeDate.ValueChanged += new System.EventHandler(this.DiscoveryTimeDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Discoverer:";
            // 
            // DiscovererCombo
            // 
            this.DiscovererCombo.FormattingEnabled = true;
            this.DiscovererCombo.Location = new System.Drawing.Point(131, 137);
            this.DiscovererCombo.Name = "DiscovererCombo";
            this.DiscovererCombo.Size = new System.Drawing.Size(371, 24);
            this.DiscovererCombo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Component:";
            // 
            // ComponentTextBox
            // 
            this.ComponentTextBox.Location = new System.Drawing.Point(131, 172);
            this.ComponentTextBox.Name = "ComponentTextBox";
            this.ComponentTextBox.Size = new System.Drawing.Size(372, 22);
            this.ComponentTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status:";
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
            this.comboBox1.Location = new System.Drawing.Point(131, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Initial Description";
            // 
            // InitialDescriptionTextBox
            // 
            InitialDescriptionTextBox.Location = new System.Drawing.Point(132, 269);
            InitialDescriptionTextBox.Multiline = true;
            InitialDescriptionTextBox.Name = "InitialDescriptionTextBox";
            InitialDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            InitialDescriptionTextBox.Size = new System.Drawing.Size(371, 233);
            InitialDescriptionTextBox.TabIndex = 13;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(235, 532);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(109, 29);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateIssueButton
            // 
            this.CreateIssueButton.Location = new System.Drawing.Point(379, 532);
            this.CreateIssueButton.Name = "CreateIssueButton";
            this.CreateIssueButton.Size = new System.Drawing.Size(124, 29);
            this.CreateIssueButton.TabIndex = 15;
            this.CreateIssueButton.Text = "Create Issue";
            this.CreateIssueButton.UseVisualStyleBackColor = true;
            this.CreateIssueButton.Click += new System.EventHandler(this.CreateIssueButton_Click);
            // 
            // FormRecordIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 620);
            this.Controls.Add(this.CreateIssueButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(InitialDescriptionTextBox);
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
            this.Name = "FormRecordIssue";
            this.Text = "FormRecordIssue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DiscoveryTimeDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DiscovererCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ComponentTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateIssueButton;
    }
}