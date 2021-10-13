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
    public partial class FormCreateNewProject : Form
    {
        Project project = new Project();
        FakeProjectRepository ProjectRepository = new FakeProjectRepository();
        List<Project> Projects = new List<Project>();
        
        public FormCreateNewProject()
        {
            InitializeComponent();
        }
        public FormCreateNewProject(FakeProjectRepository P)
        {
            InitializeComponent();
            ProjectRepository = P;
            Projects = P.GetAll();
        }
        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            this.project.Name = AddNewProjectName.Text.ToString();
            bool checker = ProjectRepository.IsDuplicateName(project.Name);
            if (checker == true)
            {
                MessageBox.Show("This name is already in use.", "Attention");
            }
            else
            {
                ProjectRepository.Add(project,0);
                MessageBox.Show(Projects[4].Name, "Attention");
            }
            this.Hide();
        }

        
        public FakeProjectRepository ReturnRepository()
        {
            return ProjectRepository;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
