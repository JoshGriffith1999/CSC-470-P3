
namespace P3
{
    partial class FormSelectIssue
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
            this.SelectIssueDataGridView = new System.Windows.Forms.DataGridView();
            this.IssueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDiscoveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDiscoverer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueInitialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SelectIssueDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyCancel
            // 
            this.modifyCancel.Location = new System.Drawing.Point(498, 378);
            this.modifyCancel.Name = "modifyCancel";
            this.modifyCancel.Size = new System.Drawing.Size(122, 36);
            this.modifyCancel.TabIndex = 0;
            this.modifyCancel.Text = "Cancel";
            this.modifyCancel.UseVisualStyleBackColor = true;
            this.modifyCancel.Click += new System.EventHandler(this.modifyCancel_Click);
            // 
            // modifySelect
            // 
            this.modifySelect.Location = new System.Drawing.Point(644, 378);
            this.modifySelect.Name = "modifySelect";
            this.modifySelect.Size = new System.Drawing.Size(122, 38);
            this.modifySelect.TabIndex = 1;
            this.modifySelect.Text = "Select Issue";
            this.modifySelect.UseVisualStyleBackColor = true;
            // 
            // SelectIssueDataGridView
            // 
            this.SelectIssueDataGridView.AllowUserToAddRows = false;
            this.SelectIssueDataGridView.AllowUserToDeleteRows = false;
            this.SelectIssueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectIssueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssueID,
            this.IssueDiscoveryDate,
            this.IssueDiscoverer,
            this.IssueInitialDescription,
            this.IssueComponent,
            this.IssueStatus});
            this.SelectIssueDataGridView.Location = new System.Drawing.Point(12, 89);
            this.SelectIssueDataGridView.Name = "SelectIssueDataGridView";
            this.SelectIssueDataGridView.ReadOnly = true;
            this.SelectIssueDataGridView.RowHeadersWidth = 51;
            this.SelectIssueDataGridView.RowTemplate.Height = 24;
            this.SelectIssueDataGridView.Size = new System.Drawing.Size(754, 264);
            this.SelectIssueDataGridView.TabIndex = 2;
            // 
            // IssueID
            // 
            this.IssueID.HeaderText = "Id";
            this.IssueID.MinimumWidth = 6;
            this.IssueID.Name = "IssueID";
            this.IssueID.ReadOnly = true;
            this.IssueID.Width = 60;
            // 
            // IssueDiscoveryDate
            // 
            this.IssueDiscoveryDate.HeaderText = "Discovery Date";
            this.IssueDiscoveryDate.MinimumWidth = 6;
            this.IssueDiscoveryDate.Name = "IssueDiscoveryDate";
            this.IssueDiscoveryDate.ReadOnly = true;
            this.IssueDiscoveryDate.Width = 125;
            // 
            // IssueDiscoverer
            // 
            this.IssueDiscoverer.HeaderText = "Discoverer";
            this.IssueDiscoverer.MinimumWidth = 6;
            this.IssueDiscoverer.Name = "IssueDiscoverer";
            this.IssueDiscoverer.ReadOnly = true;
            this.IssueDiscoverer.Width = 125;
            // 
            // IssueInitialDescription
            // 
            this.IssueInitialDescription.HeaderText = "Initial Description";
            this.IssueInitialDescription.MinimumWidth = 6;
            this.IssueInitialDescription.Name = "IssueInitialDescription";
            this.IssueInitialDescription.ReadOnly = true;
            this.IssueInitialDescription.Width = 125;
            // 
            // IssueComponent
            // 
            this.IssueComponent.HeaderText = "Component";
            this.IssueComponent.MinimumWidth = 6;
            this.IssueComponent.Name = "IssueComponent";
            this.IssueComponent.ReadOnly = true;
            this.IssueComponent.Width = 125;
            // 
            // IssueStatus
            // 
            this.IssueStatus.HeaderText = "Status";
            this.IssueStatus.MinimumWidth = 6;
            this.IssueStatus.Name = "IssueStatus";
            this.IssueStatus.ReadOnly = true;
            this.IssueStatus.Width = 125;
            // 
            // FormSelectIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectIssueDataGridView);
            this.Controls.Add(this.modifySelect);
            this.Controls.Add(this.modifyCancel);
            this.Name = "FormSelectIssue";
            this.Text = "Select Issue";
            ((System.ComponentModel.ISupportInitialize)(this.SelectIssueDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modifyCancel;
        private System.Windows.Forms.Button modifySelect;
        private System.Windows.Forms.DataGridView SelectIssueDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDiscoveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDiscoverer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueInitialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueComponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueStatus;
    }
}