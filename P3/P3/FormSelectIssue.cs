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
        Issue selectedIssue = new Issue();
        List<Issue> iss = new List<Issue>();
        public FormSelectIssue()
        {
            InitializeComponent();
            CenterToParent();
        }
        public FormSelectIssue(List<Issue> Issues)
        {
            InitializeComponent();
            CenterToParent();
            iss = Issues;
            this.SelectIssueDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (Issue i in Issues)
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

        private void modifySelect_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = SelectIssueDataGridView.SelectedRows;
            string selectedCell = (string)rows[0].Cells[0].Value;
            foreach (Issue i in iss)
            {
                if (i.Id.ToString() == selectedCell)
                {
                    selectedIssue = i;
                    this.DialogResult = DialogResult.OK;
                    this.Hide();

                }
            }



        }
        public Issue getSelectedIssue()
        {
            return selectedIssue;
        }
    }
}
