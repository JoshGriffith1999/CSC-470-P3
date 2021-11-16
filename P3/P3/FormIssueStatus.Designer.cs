namespace P3
{
    partial class FormIssueStatus
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
            this.labelTotalNumberofIssues = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IssuesByMonthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IssuesByDiscovererTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number of Issues:";
            // 
            // labelTotalNumberofIssues
            // 
            this.labelTotalNumberofIssues.AutoSize = true;
            this.labelTotalNumberofIssues.Location = new System.Drawing.Point(258, 83);
            this.labelTotalNumberofIssues.Name = "labelTotalNumberofIssues";
            this.labelTotalNumberofIssues.Size = new System.Drawing.Size(0, 17);
            this.labelTotalNumberofIssues.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Issues by Month";
            // 
            // IssuesByMonthTextBox
            // 
            this.IssuesByMonthTextBox.Location = new System.Drawing.Point(87, 168);
            this.IssuesByMonthTextBox.Multiline = true;
            this.IssuesByMonthTextBox.Name = "IssuesByMonthTextBox";
            this.IssuesByMonthTextBox.ReadOnly = true;
            this.IssuesByMonthTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IssuesByMonthTextBox.Size = new System.Drawing.Size(210, 115);
            this.IssuesByMonthTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Issues by Discoverer";
            // 
            // IssuesByDiscovererTextBox
            // 
            this.IssuesByDiscovererTextBox.Location = new System.Drawing.Point(87, 352);
            this.IssuesByDiscovererTextBox.Multiline = true;
            this.IssuesByDiscovererTextBox.Name = "IssuesByDiscovererTextBox";
            this.IssuesByDiscovererTextBox.ReadOnly = true;
            this.IssuesByDiscovererTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IssuesByDiscovererTextBox.Size = new System.Drawing.Size(210, 115);
            this.IssuesByDiscovererTextBox.TabIndex = 5;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(222, 500);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FormIssueStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 616);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.IssuesByDiscovererTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IssuesByMonthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotalNumberofIssues);
            this.Controls.Add(this.label1);
            this.Name = "FormIssueStatus";
            this.Text = "Issue Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalNumberofIssues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IssuesByMonthTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IssuesByDiscovererTextBox;
        private System.Windows.Forms.Button CloseButton;
    }
}