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
        FakeIssueStatusRepository IssueRepo = new FakeIssueStatusRepository();
        Issue IssueInUse = new Issue();

        public FormRecordIssue()
        {
            InitializeComponent();
            CenterToScreen();
            IDTextBox.ToString();
            TitleTextBox.Focus();
        }

        public FormRecordIssue(FakeIssueStatusRepository I, List<Issue> Issues)
        {
            InitializeComponent();
            CenterToScreen();
            IDTextBox.Text = (I.GetNextId()).ToString();
            this.ActiveControl = TitleTextBox;
        }
        private void CreateIssueButton_Click(object sender, EventArgs e)
        {

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
