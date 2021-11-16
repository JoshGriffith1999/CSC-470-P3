﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3
{
    public partial class FormIssueStatus : Form
    {
        public FormIssueStatus()
        {
            InitializeComponent();
        }
        public FormIssueStatus(FakeIssueRepository IssueRepo, Project ProjectInUse)
        {
            InitializeComponent();
            this.ActiveControl = CloseButton;
            MessageBox.Show(ProjectInUse.ID.ToString());
            int totalIssues = IssueRepo.GetTotalNumberOfIssues(ProjectInUse.ID);
            labelTotalNumberofIssues.Text = totalIssues.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}