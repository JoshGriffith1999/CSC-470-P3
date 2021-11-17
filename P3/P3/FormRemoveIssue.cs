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
    public partial class FormRemoveIssue : Form
    {
        FakeIssueRepository IssueRepo = new FakeIssueRepository();
        Issue IssueInUse = new Issue();
        public FormRemoveIssue()
        {
            InitializeComponent();
        }

        public FormRemoveIssue(Issue selectedIssue, FakeIssueRepository I, List<Issue> Issues, FakeAppUserRepository Users, int PId, List<AppUser> users)
        {
            InitializeComponent();
            CenterToScreen();
            IssueRepo = I;
            IssueInUse = selectedIssue;
            textBox1.Text = "Are you sure you want to remove: "+IssueInUse.Title+"?";
        }

        private void Confirm_click_Click(object sender, EventArgs e)
        {
            IssueRepo.Remove(IssueInUse);
            this.Close();
        }

        private void Cancel_click_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            MessageBox.Show("Remove Canceled");
            this.Close();
        }
    }
}
