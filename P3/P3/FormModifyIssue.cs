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
    public partial class FormModifyIssue : Form
    {
        FakeIssueRepository IssueRepo = new FakeIssueRepository();
        Issue IssueInUse = new Issue();

        int ProjectId;

        public FormModifyIssue()
        {
            InitializeComponent();
        }

        public FormModifyIssue(Issue selectedIssue, FakeIssueRepository I, List<Issue> Issues, FakeAppUserRepository Users, int PId, List<AppUser> users)
        {
            InitializeComponent();
            CenterToScreen();
            IssueRepo = I;
            IssueInUse = selectedIssue;

            TitleTextBox.Text = IssueInUse.Title;
            //DiscoveryTimeDate = IssueInUse.DiscoveryDate;
            DiscovererCombo.Text = IssueInUse.Discoverer;
            ComponentTextBox.Text = IssueInUse.Component;
            comboBox1.Text = IssueInUse.Status; //not sure why this  isnt populating status text area when modifying
            InitialDescriptionTextBox.Text = IssueInUse.InitialDescription;

            users = Users.GetALL();
            foreach (AppUser user in users)
            {
                DiscovererCombo.Items.Add(user.LastName + "," + user.FirstName);
            }
            ProjectId = PId;

            IDTextBox.Text = (I.GetNextId()).ToString();
            this.ActiveControl = TitleTextBox;
            DiscoveryTimeDate.MaxDate = DateTime.Now;

        }

        private void ModifyIssueButton_Click(object sender, EventArgs e)
        {
            //Issue createdIssue = new Issue();
            //createdIssue.ProjectId = ProjectId;
            //createdIssue.Id = Int32.Parse(IDTextBox.Text.Trim());

            IssueInUse.Title = TitleTextBox.Text.Trim();
            IssueInUse.DiscoveryDate = DiscoveryTimeDate.Value;
            var Discoverertester = DiscovererCombo.SelectedItem;
            if (Discoverertester == null)
            {
            }
            else
            {
                IssueInUse.Discoverer = DiscovererCombo.SelectedItem.ToString().Trim();
            }

            IssueInUse.Component = ComponentTextBox.Text.Trim();
            IssueInUse.Status = comboBox1.Text.Trim();
            IssueInUse.InitialDescription = InitialDescriptionTextBox.Text.Trim();

            string result = IssueRepo.Modify(IssueInUse.Id, IssueInUse);
            if (result != IssueRepo.NO_ERROR)
            {
                MessageBox.Show(result, "Attention");
            }
            else
            {
                MessageBox.Show("Issue Modified.");

                this.Hide();
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public FakeIssueRepository GetIssueRepo()
        {
            return IssueRepo;
        }
    }
}
