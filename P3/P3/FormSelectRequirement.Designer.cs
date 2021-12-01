
namespace P3
{
    partial class FormSelectRequirement
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
            this.featureLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.requirementsLabel = new System.Windows.Forms.Label();
            this.selectRequirementButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.RequirementsDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RequirementsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // featureLabel
            // 
            this.featureLabel.AutoSize = true;
            this.featureLabel.Location = new System.Drawing.Point(43, 54);
            this.featureLabel.Name = "featureLabel";
            this.featureLabel.Size = new System.Drawing.Size(61, 17);
            this.featureLabel.TabIndex = 0;
            this.featureLabel.Text = "Feature:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(603, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // requirementsLabel
            // 
            this.requirementsLabel.AutoSize = true;
            this.requirementsLabel.Location = new System.Drawing.Point(8, 92);
            this.requirementsLabel.Name = "requirementsLabel";
            this.requirementsLabel.Size = new System.Drawing.Size(96, 17);
            this.requirementsLabel.TabIndex = 3;
            this.requirementsLabel.Text = "Requirements";
            // 
            // selectRequirementButton
            // 
            this.selectRequirementButton.Location = new System.Drawing.Point(579, 392);
            this.selectRequirementButton.Name = "selectRequirementButton";
            this.selectRequirementButton.Size = new System.Drawing.Size(133, 32);
            this.selectRequirementButton.TabIndex = 5;
            this.selectRequirementButton.Text = "Select Requirement";
            this.selectRequirementButton.UseVisualStyleBackColor = true;
            this.selectRequirementButton.Click += new System.EventHandler(this.selectRequirementButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(416, 392);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 32);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RequirementsDataGridView
            // 
            this.RequirementsDataGridView.AllowUserToAddRows = false;
            this.RequirementsDataGridView.AllowUserToDeleteRows = false;
            this.RequirementsDataGridView.AllowUserToResizeColumns = false;
            this.RequirementsDataGridView.AllowUserToResizeRows = false;
            this.RequirementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequirementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Requirement});
            this.RequirementsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RequirementsDataGridView.Location = new System.Drawing.Point(110, 92);
            this.RequirementsDataGridView.MultiSelect = false;
            this.RequirementsDataGridView.Name = "RequirementsDataGridView";
            this.RequirementsDataGridView.RowHeadersWidth = 51;
            this.RequirementsDataGridView.RowTemplate.Height = 24;
            this.RequirementsDataGridView.RowTemplate.ReadOnly = true;
            this.RequirementsDataGridView.Size = new System.Drawing.Size(602, 294);
            this.RequirementsDataGridView.TabIndex = 7;
            this.RequirementsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RequirementsDataGridView_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 75;
            // 
            // Requirement
            // 
            this.Requirement.HeaderText = "Requirement";
            this.Requirement.MinimumWidth = 6;
            this.Requirement.Name = "Requirement";
            this.Requirement.Width = 400;
            // 
            // FormSelectRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RequirementsDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectRequirementButton);
            this.Controls.Add(this.requirementsLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.featureLabel);
            this.Name = "FormSelectRequirement";
            this.Text = "FormSelectRequirement";
            ((System.ComponentModel.ISupportInitialize)(this.RequirementsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label featureLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label requirementsLabel;
        private System.Windows.Forms.Button selectRequirementButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView RequirementsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requirement;
    }
}