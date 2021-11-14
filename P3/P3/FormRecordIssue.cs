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
    public partial class FormRecordIssue : Form
    {
        FakeIssueRepository IssueRepo = new FakeIssueRepository();
        Issue IssueInUse = new Issue();

        

            public FormRecordIssue()
        {
            InitializeComponent();
            CenterToScreen();
            IDTextBox.ToString();
            TitleTextBox.Focus();
        }

        public FormRecordIssue(FakeIssueRepository I, List<Issue> Issues, FakeAppUserRepository Users)
        {
            InitializeComponent();
            CenterToScreen();
            List<AppUser> users = new List<AppUser>();
            users = Users.GetALL();
            foreach (AppUser user in users)
            {
                DiscovererCombo.Items.Add(user.LastName + "," +user.FirstName);
            }
            
            
            IDTextBox.Text = (I.GetNextId()).ToString();
            this.ActiveControl = TitleTextBox;
            DiscoveryTimeDate.MaxDate = DateTime.Now;

        }
        private void CreateIssueButton_Click(object sender, EventArgs e)
        {
            Issue createdIssue = new Issue();
            createdIssue.ProjectId = ProjectId;
            createdIssue.Id = Int32.Parse(IDTextBox.Text.Trim());
            createdIssue.Title = TitleTextBox.Text.Trim();
            createdIssue.DiscoveryDate = DiscoveryTimeDate.Value;
            createdIssue.Discoverer = DiscovererCombo.SelectedItem.ToString().Trim();
            createdIssue.Component = ComponentTextBox.Text.Trim();
            createdIssue.InitialDescription = InitialDescriptionTextBox.Text.Trim();
            
            if (TitleTextBox.TextLength != 0)
            {
                bool checker;
                checker = IssueRepo.IsDuplicateName(TitleTextBox.Text);
                if (checker == true)
                {
                    MessageBox.Show("Issue title must be unique.");
                }
                else
                {
                    if (DiscoveryTimeDate.Value <= DateTime.Now)
                    {
                        if (DiscovererCombo.SelectedItem != null)
                        {
                            
                            this.Hide();
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Issue must contain a discoverer.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Time and Date must be in the past or present.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Issue must contain a title.");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void DiscoveryTimeDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
