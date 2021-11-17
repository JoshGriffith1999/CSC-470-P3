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
        }
    }
}
