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
        FakeProjectRepository fakeProjectRepo = new FakeProjectRepository();
        FakeIssueRepository fakeIssueRepo = new FakeIssueRepository();
        List<Project> projects;
        List<Issue> allIssues;
        
        public FormModifyIssue()
        {
            projects = fakeProjectRepo.GetAll();
            curProjID = fakeProjectRepo.
            allIssues = fakeIssueRepo.GetAll();
            InitializeComponent();
        }
    }
}
