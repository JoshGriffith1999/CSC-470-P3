
namespace P3
{
    partial class FormRemoveRequirement
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
            this.featurelabel = new System.Windows.Forms.Label();
            this.requirementLabel = new System.Windows.Forms.Label();
            this.featureComboBox = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.requirementGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.requirementGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // featurelabel
            // 
            this.featurelabel.AutoSize = true;
            this.featurelabel.Location = new System.Drawing.Point(74, 43);
            this.featurelabel.Name = "featurelabel";
            this.featurelabel.Size = new System.Drawing.Size(43, 13);
            this.featurelabel.TabIndex = 0;
            this.featurelabel.Text = "Feature";
            // 
            // requirementLabel
            // 
            this.requirementLabel.AutoSize = true;
            this.requirementLabel.Location = new System.Drawing.Point(77, 89);
            this.requirementLabel.Name = "requirementLabel";
            this.requirementLabel.Size = new System.Drawing.Size(72, 13);
            this.requirementLabel.TabIndex = 1;
            this.requirementLabel.Text = "Requirements";
            // 
            // featureComboBox
            // 
            this.featureComboBox.FormattingEnabled = true;
            this.featureComboBox.Location = new System.Drawing.Point(152, 43);
            this.featureComboBox.Name = "featureComboBox";
            this.featureComboBox.Size = new System.Drawing.Size(474, 21);
            this.featureComboBox.TabIndex = 2;
            this.featureComboBox.SelectedIndexChanged += new System.EventHandler(this.featureComboBox_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(551, 304);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(401, 304);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // requirementGridView
            // 
            this.requirementGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requirementGridView.Location = new System.Drawing.Point(155, 89);
            this.requirementGridView.Name = "requirementGridView";
            this.requirementGridView.Size = new System.Drawing.Size(471, 155);
            this.requirementGridView.TabIndex = 5;
            // 
            // FormRemoveRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.requirementGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.featureComboBox);
            this.Controls.Add(this.requirementLabel);
            this.Controls.Add(this.featurelabel);
            this.Name = "FormRemoveRequirement";
            this.Text = "FormRemoveRequirement";
            ((System.ComponentModel.ISupportInitialize)(this.requirementGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label featurelabel;
        private System.Windows.Forms.Label requirementLabel;
        private System.Windows.Forms.ComboBox featureComboBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView requirementGridView;
    }
}