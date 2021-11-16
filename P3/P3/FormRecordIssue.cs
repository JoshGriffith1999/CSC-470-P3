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
        
        int ProjectId;
            public FormRecordIssue()
        {
            InitializeComponent();
            CenterToScreen();
            IDTextBox.ToString();
            TitleTextBox.Focus();
        }

        public FormRecordIssue(FakeIssueRepository I, List<Issue> Issues, FakeAppUserRepository Users, int PId, List<AppUser> users)
        {
            InitializeComponent();
            CenterToScreen();
            IssueRepo =I;

            users = Users.GetALL();
            foreach (AppUser user in users)
            {
                DiscovererCombo.Items.Add(user.LastName + "," +user.FirstName);
            }
            ProjectId = PId;
            
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
            var Discoverertester = DiscovererCombo.SelectedItem;
            if( Discoverertester == null)
            {
            }
            else 
            { 
            createdIssue.Discoverer = DiscovererCombo.SelectedItem.ToString().Trim();
            }
           
            createdIssue.Component = ComponentTextBox.Text.Trim();
            createdIssue.InitialDescription = InitialDescriptionTextBox.Text.Trim();
            
            string result = IssueRepo.Add(createdIssue);
            if(result != IssueRepo.NO_ERROR)
            {
                MessageBox.Show(result, "Attention");
            }
            else
            {
                MessageBox.Show("Issue added.");
               
                this.Hide();
                this.DialogResult = DialogResult.OK;
            }
            
              
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DiscoveryTimeDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InitialDescriptionTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
        public FakeIssueRepository GetIssueRepo()
        {
            return IssueRepo;
        }
    }
}
