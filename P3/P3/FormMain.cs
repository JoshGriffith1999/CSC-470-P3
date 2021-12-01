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
        FakeFeatureRepository FeatureRepository = new FakeFeatureRepository();
        FakeRequirementRepositpry RequirementRepositpry = new FakeRequirementRepositpry();

        Issue IssueInUse = new Issue();
        Project ProjectInUse = new Project();
        Feature FeatureInUse = new Feature();

        private AppUser User = new AppUser();
        private List<Project> Projects = new List<Project>();
        private List<Issue> Issues = new List<Issue>();
        private List<AppUser> users = new List<AppUser>();
        private List<Feature> Features = new List<Feature>();
        private List<Requirement> Requirements = new List<Requirement>();

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

            while (User.IsAuthenticated != true && result != DialogResult.OK)
            {
                result = Login.ShowDialog();
                User = Login.GetUser();

                if (result == DialogResult.Cancel)
                {
                    break;
                }

                if (result != DialogResult.OK)
                {
                    FailedAttempts += 1;
                    if (FailedAttempts == MaxFailedAttempts)
                    {
                        result = DialogResult.Cancel;
                        break;
                    }

                }

            }

            if (result == DialogResult.Cancel)
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
            FormRecordIssue recordIssue = new FormRecordIssue(IssueRepository, Issues, UserRepository, ProjectInUse.ID, users);
            recordIssue.ShowDialog();
            IssueRepository = recordIssue.GetIssueRepo();
            Issues = IssueRepository.GetAll(ProjectInUse.ID);

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Issues = IssueRepository.GetAll(ProjectInUse.ID);
            FormIssueStatus recordIssue = new FormIssueStatus(IssueRepository, ProjectInUse, Issues);
            recordIssue.ShowDialog();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issues = IssueRepository.GetAll(ProjectInUse.ID);
            if (Issues.Count != 0)
            {
                FormSelectIssue selectIssue = new FormSelectIssue(Issues);
                result = selectIssue.ShowDialog();
                Issue selectedIssue = new Issue();
                selectedIssue = selectIssue.getSelectedIssue();
                //selectedIssue now contains a selected Issue
                FormModifyIssue modifiedIssue = new FormModifyIssue(selectedIssue, IssueRepository, Issues, UserRepository, ProjectInUse.ID, users);
                if (result != DialogResult.Cancel)
                {
                    modifiedIssue.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("There are no issues to modify.");
            }

            //
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issues = IssueRepository.GetAll(ProjectInUse.ID);
            if (Issues.Count != 0)
            {
                FormSelectIssue selectIssue = new FormSelectIssue(Issues);
                result = selectIssue.ShowDialog();
                Issue selectedIssue = new Issue();
                selectedIssue = selectIssue.getSelectedIssue();
                //selectedIssue now contains a selected Issue
                FormRemoveIssue modifiedIssue = new FormRemoveIssue(selectedIssue, IssueRepository, Issues, UserRepository, ProjectInUse.ID, users);
                if (result != DialogResult.Cancel)
                {
                    modifiedIssue.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("There are no issues to remove.");
            }
            //
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            FormCreateFeature createFeature = new FormCreateFeature(ProjectInUse, FeatureRepository);
            createFeature.ShowDialog();
            FeatureRepository = createFeature.GetFeatureRepo();
            Features = FeatureRepository.GetAll(ProjectInUse.ID);
        }

        private void modifyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Features = FeatureRepository.GetAll(ProjectInUse.ID);
            if (Features.Count != 0)
            {
                FormSelectFeature selectFeature = new FormSelectFeature(Features);
                result = selectFeature.ShowDialog();
                Feature selectedFeature = new Feature();
                selectedFeature = selectFeature.getSelectedFeature();
                //selectedFeature now contains a selected Feature
                FormModifyFeature modifiedFeature = new FormModifyFeature(ProjectInUse, FeatureRepository, selectedFeature);
                if (result != DialogResult.Cancel)
                {
                    modifiedFeature.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("There are no features to modify.");
            }
        }

        private void removeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Features = FeatureRepository.GetAll(ProjectInUse.ID);
            if (Features.Count != 0)
            {
                FormSelectFeature selectFeature = new FormSelectFeature(Features);
                result = selectFeature.ShowDialog();
                Feature selectedFeature = new Feature();
                selectedFeature = selectFeature.getSelectedFeature();
                //selectedFeature now contains a selected Feature

                List<Requirement> temp = RequirementRepositpry.GetALL(selectedFeature.id);

                if (temp.Any() == true)
                {

                    DialogResult result = MessageBox.Show("Are you sure that you want to remove this feature considering that there are requirments " +
                        "attached to this feature?", "Attention", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        FormRemoveFeature removedFeature = new FormRemoveFeature(selectedFeature, FeatureRepository);
                        if (result != DialogResult.Cancel)
                        {
                            removedFeature.ShowDialog();
                        }
                    }
                }
                else {

                    FormRemoveFeature removedFeature = new FormRemoveFeature(selectedFeature, FeatureRepository);
                    if (result != DialogResult.Cancel)
                    {
                        removedFeature.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no features to modify.");
            }




        }

        //For add in a new requirement
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Features.Count != 0)
            {
                FormCreateRequirement createRequirement = new FormCreateRequirement(FeatureRepository, RequirementRepositpry, Features, Requirements);
                createRequirement.ShowDialog();
                RequirementRepositpry = createRequirement.returnRepo();
                Requirements = RequirementRepositpry.GetALL(ProjectInUse.ID);
            }
            else {
                MessageBox.Show("Cannot add in a requirement since there are no features currently");
            }
          
        }

        //Used to modify a requirement assciated to a featre
        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Requirement SelectedRequirement = new Requirement();
            if (Features.Count != 0)
            {
                FormSelectRequirement SelectRequirement = new FormSelectRequirement(RequirementRepositpry, FeatureRepository,Features, Requirements);
                SelectRequirement.ShowDialog();
                SelectedRequirement = SelectRequirement.getSelectedRequirement();
            }
            else
            {
                MessageBox.Show("Cannot modify a requirement since there are no features currently");
            }

            //FormModifyRequirement
            FormModifyRequirement modifyRequirement = new FormModifyRequirement(Features,SelectedRequirement,FeatureRepository,RequirementRepositpry);
            modifyRequirement.ShowDialog();
        }

        //Used to remove a requirement assiciated to a feature
        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Requirement SelectedRequirement = new Requirement();
            if (Features.Count != 0)
            {
                FormSelectRequirement SelectRequirement = new FormSelectRequirement(RequirementRepositpry, FeatureRepository, Features, Requirements);
                SelectRequirement.ShowDialog();
                SelectedRequirement = SelectRequirement.getSelectedRequirement();
            }
            else
            {
                MessageBox.Show("Cannot modify a requirement since there are no features currently");
            }


            DialogResult result = MessageBox.Show("Are you sure that you want to remove this requirement?", "Attention", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Requirements.Remove(SelectedRequirement);
            }
        }
    }
}
