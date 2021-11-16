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
    public partial class FormMain : Form
    {
        FakeAppUserRepository UserRepository = new FakeAppUserRepository();
        FakeProjectRepository ProjectRepository = new FakeProjectRepository();
        FakeIssueRepository IssueRepository = new FakeIssueRepository();
        Issue IssueInUse = new Issue();
        Project ProjectInUse = new Project();
        
        private AppUser User = new AppUser();
        private List<Project> Projects = new List<Project>();
        private List<Issue> Issues = new List<Issue>();
        private List<AppUser> users = new List<AppUser>();
       
        DialogResult result = DialogResult.None;
        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();
            Load += new EventHandler(FormMain_load);
        }

        private void FormMain_load(object sender, System.EventArgs e)
        {
            FormLogin Login = new FormLogin();
            
            int FailedAttempts = 0;
            int MaxFailedAttempts = 3;
            User.IsAuthenticated = false;

            while(User.IsAuthenticated != true && result != DialogResult.OK)
            {
                result = Login.ShowDialog();
                User = Login.GetUser();

                if (result == DialogResult.Cancel)
                {
                    break;
                }

                if(result != DialogResult.OK)
                {
                    FailedAttempts += 1;
                    if (FailedAttempts == MaxFailedAttempts)
                    {
                        result = DialogResult.Cancel;
                        break;
                    }
                    
                }
               
            }

            if(result == DialogResult.Cancel)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                User = Login.GetUser();
                FormSelectProject S = new FormSelectProject(ProjectRepository, Projects);

                int cancelCtr = 0;
                while (cancelCtr < 2)
                {
                    result = S.ShowDialog();
                    if (result != DialogResult.OK)
                    {
                        MessageBox.Show("A Project must be selected");
                        cancelCtr++;
                    }
                    else
                    {
                        ProjectInUse = S.returnProject();
                        this.Text = "Main - " + ProjectInUse.Name;
                        break;
                    }
                    if (cancelCtr >= 2)
                    {
                        //Quit program if no project is selected after 2 cancel clicks
                        Application.Exit();
                    }
                }
             
                
                //this.Text = "Main - No Project Selected";
            }
        }

        private void selectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectProject S = new FormSelectProject(ProjectRepository, Projects);
            S.ShowDialog();
            ProjectInUse = S.returnProject();
            this.Text = "Main - " + ProjectInUse.Name;
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateNewProject C = new FormCreateNewProject(ProjectRepository);
            C.ShowDialog();
            ProjectRepository = C.ReturnRepository();
            Projects = ProjectRepository.GetAll();
        }

        private void modifyProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectProject M = new FormSelectProject(ProjectRepository, Projects);
            M.ShowDialog();
            Project selectedProject = M.returnProject();
            FormModifyProject Modifier = new FormModifyProject(ProjectInUse, selectedProject);
            Modifier.ShowDialog();
            this.Text = "Main - " + ProjectInUse.Name;
        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRemoveProject removeProject = new FormRemoveProject(ProjectRepository, ProjectInUse);
            removeProject.ShowDialog();
            ProjectRepository = removeProject.returnRepo();
            this.Projects = ProjectRepository.GetAll();

        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            users = UserRepository.GetALL();
            FormRecordIssue recordIssue = new FormRecordIssue(IssueRepository, Issues, UserRepository, ProjectInUse.ID,users);
            recordIssue.ShowDialog();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIssueStatus recordIssue = new FormIssueStatus(IssueRepository, ProjectInUse);
            recordIssue.ShowDialog();
        }
    }
}
