
namespace P3
{
    partial class FormMain
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
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trendByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 28);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(1067, 24);
            this.MainFormMenuStrip.TabIndex = 0;
            this.MainFormMenuStrip.Text = "menuStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.issueToolStripMenuItem,
            this.requirementToolStripMenuItem,
            this.designToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectProjectToolStripMenuItem,
            this.createProjectToolStripMenuItem,
            this.modifyProjectToolStripMenuItem,
            this.removeProjectToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // selectProjectToolStripMenuItem
            // 
            this.selectProjectToolStripMenuItem.Name = "selectProjectToolStripMenuItem";
            this.selectProjectToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.selectProjectToolStripMenuItem.Text = "Select Project";
            this.selectProjectToolStripMenuItem.Click += new System.EventHandler(this.selectProjectToolStripMenuItem_Click);
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.createProjectToolStripMenuItem.Text = "Create Project";
            this.createProjectToolStripMenuItem.Click += new System.EventHandler(this.createProjectToolStripMenuItem_Click);
            // 
            // modifyProjectToolStripMenuItem
            // 
            this.modifyProjectToolStripMenuItem.Name = "modifyProjectToolStripMenuItem";
            this.modifyProjectToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.modifyProjectToolStripMenuItem.Text = "Modify Project";
            this.modifyProjectToolStripMenuItem.Click += new System.EventHandler(this.modifyProjectToolStripMenuItem_Click);
            // 
            // removeProjectToolStripMenuItem
            // 
            this.removeProjectToolStripMenuItem.Name = "removeProjectToolStripMenuItem";
            this.removeProjectToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.removeProjectToolStripMenuItem.Text = "Remove Project";
            this.removeProjectToolStripMenuItem.Click += new System.EventHandler(this.removeProjectToolStripMenuItem_Click);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.issueToolStripMenuItem.Text = "Issue";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.recordToolStripMenuItem.Text = "Record";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countByAssigneeToolStripMenuItem,
            this.listByAssigneeToolStripMenuItem,
            this.countByArtifactToolStripMenuItem,
            this.listByArtifactToolStripMenuItem,
            this.countByDateRangeToolStripMenuItem,
            this.listByDateRangeToolStripMenuItem,
            this.trendByDateRangeToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // countByAssigneeToolStripMenuItem
            // 
            this.countByAssigneeToolStripMenuItem.Name = "countByAssigneeToolStripMenuItem";
            this.countByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.countByAssigneeToolStripMenuItem.Text = "Count by Assignee";
            // 
            // listByAssigneeToolStripMenuItem
            // 
            this.listByAssigneeToolStripMenuItem.Name = "listByAssigneeToolStripMenuItem";
            this.listByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.listByAssigneeToolStripMenuItem.Text = "List by Assignee";
            // 
            // countByArtifactToolStripMenuItem
            // 
            this.countByArtifactToolStripMenuItem.Name = "countByArtifactToolStripMenuItem";
            this.countByArtifactToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.countByArtifactToolStripMenuItem.Text = "Count by Artifact";
            // 
            // listByArtifactToolStripMenuItem
            // 
            this.listByArtifactToolStripMenuItem.Name = "listByArtifactToolStripMenuItem";
            this.listByArtifactToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.listByArtifactToolStripMenuItem.Text = "List by Artifact";
            // 
            // countByDateRangeToolStripMenuItem
            // 
            this.countByDateRangeToolStripMenuItem.Name = "countByDateRangeToolStripMenuItem";
            this.countByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.countByDateRangeToolStripMenuItem.Text = "Count by Date Range";
            // 
            // listByDateRangeToolStripMenuItem
            // 
            this.listByDateRangeToolStripMenuItem.Name = "listByDateRangeToolStripMenuItem";
            this.listByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.listByDateRangeToolStripMenuItem.Text = "List by Date Range";
            // 
            // trendByDateRangeToolStripMenuItem
            // 
            this.trendByDateRangeToolStripMenuItem.Name = "trendByDateRangeToolStripMenuItem";
            this.trendByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.trendByDateRangeToolStripMenuItem.Text = "Trend by Date Range";
            // 
            // requirementToolStripMenuItem
            // 
            this.requirementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featureToolStripMenuItem,
            this.createToolStripMenuItem,
            this.modifyToolStripMenuItem1,
            this.removeToolStripMenuItem1});
            this.requirementToolStripMenuItem.Name = "requirementToolStripMenuItem";
            this.requirementToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.requirementToolStripMenuItem.Text = "Requirement";
            // 
            // featureToolStripMenuItem
            // 
            this.featureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.modifyToolStripMenuItem2,
            this.removeToolStripMenuItem2});
            this.featureToolStripMenuItem.Name = "featureToolStripMenuItem";
            this.featureToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.featureToolStripMenuItem.Text = "Feature";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.createToolStripMenuItem1.Text = "Create";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // modifyToolStripMenuItem2
            // 
            this.modifyToolStripMenuItem2.Name = "modifyToolStripMenuItem2";
            this.modifyToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.modifyToolStripMenuItem2.Text = "Modify";
            this.modifyToolStripMenuItem2.Click += new System.EventHandler(this.modifyToolStripMenuItem2_Click);
            // 
            // removeToolStripMenuItem2
            // 
            this.removeToolStripMenuItem2.Name = "removeToolStripMenuItem2";
            this.removeToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.removeToolStripMenuItem2.Text = "Remove";
            this.removeToolStripMenuItem2.Click += new System.EventHandler(this.removeToolStripMenuItem2_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // modifyToolStripMenuItem1
            // 
            this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            this.modifyToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.modifyToolStripMenuItem1.Text = "Modify";
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.removeToolStripMenuItem1.Text = "Remove";
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.designToolStripMenuItem.Text = "Design";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.MainFormMenuStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trendByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
    }
}

