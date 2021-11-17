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
    public partial class FormSelectIssue : Form
    {
        FakeIssueRepository issueRepo = new FakeIssueRepository();
        public FormSelectIssue()
        {
            InitializeComponent();
            CenterToParent();
        }
        public FormSelectIssue(List<Issue> Issues)
        {
            InitializeComponent();
            CenterToParent();
            foreach(Issue i in Issues)
            {
                string[] row = new string[] { i.Id.ToString(), i.DiscoveryDate.ToString(), i.Discoverer, i.InitialDescription, i.Component, i.Status };
                SelectIssueDataGridView.Rows.Add(row);
            }
        }

        private void modifyCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
