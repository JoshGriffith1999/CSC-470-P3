﻿
namespace P3
{
    partial class FormCreateRequirement
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
            this.RequirementTextBox = new System.Windows.Forms.TextBox();
            this.FeatureLabel = new System.Windows.Forms.Label();
            this.RequirementLabel = new System.Windows.Forms.Label();
            this.AddRequirementButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FeatureComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RequirementTextBox
            // 
            this.RequirementTextBox.Location = new System.Drawing.Point(151, 141);
            this.RequirementTextBox.Multiline = true;
            this.RequirementTextBox.Name = "RequirementTextBox";
            this.RequirementTextBox.Size = new System.Drawing.Size(508, 124);
            this.RequirementTextBox.TabIndex = 0;
            // 
            // FeatureLabel
            // 
            this.FeatureLabel.AutoSize = true;
            this.FeatureLabel.Location = new System.Drawing.Point(75, 88);
            this.FeatureLabel.Name = "FeatureLabel";
            this.FeatureLabel.Size = new System.Drawing.Size(46, 13);
            this.FeatureLabel.TabIndex = 1;
            this.FeatureLabel.Text = "Feature:";
            // 
            // RequirementLabel
            // 
            this.RequirementLabel.AutoSize = true;
            this.RequirementLabel.Location = new System.Drawing.Point(78, 148);
            this.RequirementLabel.Name = "RequirementLabel";
            this.RequirementLabel.Size = new System.Drawing.Size(67, 13);
            this.RequirementLabel.TabIndex = 2;
            this.RequirementLabel.Text = "Requirement";
            // 
            // AddRequirementButton
            // 
            this.AddRequirementButton.Location = new System.Drawing.Point(584, 297);
            this.AddRequirementButton.Name = "AddRequirementButton";
            this.AddRequirementButton.Size = new System.Drawing.Size(75, 23);
            this.AddRequirementButton.TabIndex = 3;
            this.AddRequirementButton.Text = "Add Requirement";
            this.AddRequirementButton.UseVisualStyleBackColor = true;
            this.AddRequirementButton.Click += new System.EventHandler(this.AddRequirementButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(431, 297);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FeatureComboBox
            // 
            this.FeatureComboBox.FormattingEnabled = true;
            this.FeatureComboBox.Location = new System.Drawing.Point(151, 88);
            this.FeatureComboBox.Name = "FeatureComboBox";
            this.FeatureComboBox.Size = new System.Drawing.Size(508, 21);
            this.FeatureComboBox.TabIndex = 5;
            this.FeatureComboBox.Text = "Select A Feature";
            // 
            // FormCreateRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeatureComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddRequirementButton);
            this.Controls.Add(this.RequirementLabel);
            this.Controls.Add(this.FeatureLabel);
            this.Controls.Add(this.RequirementTextBox);
            this.Name = "FormCreateRequirement";
            this.Text = "Add Requirement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RequirementTextBox;
        private System.Windows.Forms.Label FeatureLabel;
        private System.Windows.Forms.Label RequirementLabel;
        private System.Windows.Forms.Button AddRequirementButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox FeatureComboBox;
    }
}