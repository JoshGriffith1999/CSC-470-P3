using System;
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
        public FormIssueStatus(FakeIssueRepository IssueRepo, Project ProjectInUse, List<Issue> Issues)
        {
            InitializeComponent();
            this.ActiveControl = CloseButton;

            int totalIssues = IssueRepo.GetTotalNumberOfIssues(ProjectInUse.ID);
            labelTotalNumberofIssues.Text = totalIssues.ToString();
            foreach (string i in IssueRepo.GetIssuesByMonth(ProjectInUse.ID))
            {
                IssuesByMonthTextBox.AppendText(i);
                IssuesByMonthTextBox.AppendText(Environment.NewLine);
            }
            foreach (string i in IssueRepo.GetIssueByDiscoverer(ProjectInUse.ID))
            {
                IssuesByDiscovererTextBox.AppendText(i);
                IssuesByDiscovererTextBox.AppendText(Environment.NewLine);
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
