
namespace P3
{
    partial class FormSelectFeature
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
            this.modifyCancel = new System.Windows.Forms.Button();
            this.modifySelect = new System.Windows.Forms.Button();
            this.SelectFeatureDataGridView = new System.Windows.Forms.DataGridView();
            this.FeatureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeatureTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SelectFeatureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyCancel
            // 
            this.modifyCancel.Location = new System.Drawing.Point(705, 335);
            this.modifyCancel.Name = "modifyCancel";
            this.modifyCancel.Size = new System.Drawing.Size(122, 36);
            this.modifyCancel.TabIndex = 0;
            this.modifyCancel.Text = "Cancel";
            this.modifyCancel.UseVisualStyleBackColor = true;
            this.modifyCancel.Click += new System.EventHandler(this.modifyCancel_Click);
            // 
            // modifySelect
            // 
            this.modifySelect.Location = new System.Drawing.Point(844, 335);
            this.modifySelect.Name = "modifySelect";
            this.modifySelect.Size = new System.Drawing.Size(122, 38);
            this.modifySelect.TabIndex = 1;
            this.modifySelect.Text = "Select Issue";
            this.modifySelect.UseVisualStyleBackColor = true;
            this.modifySelect.Click += new System.EventHandler(this.modifySelect_Click);
            // 
            // SelectFeatureDataGridView
            // 
            this.SelectFeatureDataGridView.AllowUserToAddRows = false;
            this.SelectFeatureDataGridView.AllowUserToDeleteRows = false;
            this.SelectFeatureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectFeatureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeatureID,
            this.FeatureTitle});
            this.SelectFeatureDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SelectFeatureDataGridView.Location = new System.Drawing.Point(12, 34);
            this.SelectFeatureDataGridView.MultiSelect = false;
            this.SelectFeatureDataGridView.Name = "SelectFeatureDataGridView";
            this.SelectFeatureDataGridView.ReadOnly = true;
            this.SelectFeatureDataGridView.RowHeadersWidth = 51;
            this.SelectFeatureDataGridView.RowTemplate.Height = 24;
            this.SelectFeatureDataGridView.Size = new System.Drawing.Size(954, 264);
            this.SelectFeatureDataGridView.TabIndex = 2;
            this.SelectFeatureDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectFeatureDataGridView_CellContentClick);
            // 
            // FeatureID
            // 
            this.FeatureID.HeaderText = "Id";
            this.FeatureID.MinimumWidth = 6;
            this.FeatureID.Name = "FeatureID";
            this.FeatureID.ReadOnly = true;
            this.FeatureID.Width = 60;
            // 
            // FeatureTitle
            // 
            this.FeatureTitle.HeaderText = "Title";
            this.FeatureTitle.MinimumWidth = 6;
            this.FeatureTitle.Name = "FeatureTitle";
            this.FeatureTitle.ReadOnly = true;
            this.FeatureTitle.Width = 600;
            // 
            // FormSelectFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 407);
            this.Controls.Add(this.SelectFeatureDataGridView);
            this.Controls.Add(this.modifySelect);
            this.Controls.Add(this.modifyCancel);
            this.Name = "FormSelectFeature";
            this.Text = "Select Issue";
            ((System.ComponentModel.ISupportInitialize)(this.SelectFeatureDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modifyCancel;
        private System.Windows.Forms.Button modifySelect;
        private System.Windows.Forms.DataGridView SelectFeatureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureTitle;
    }
}