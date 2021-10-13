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
        FakeProjectRepository Projects = new FakeProjectRepository();
        public FormCreateNewProject()
        {
            InitializeComponent();
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            this.project.Name = AddNewProjectName.Text.ToString();
            bool checker = Projects.IsDuplicateName(project.Name);
            if (checker == true)
            {
                MessageBox.Show("This Name is already in use.", "Attention");
            }
            else
                MessageBox.Show( Projects.Add(project, 0) , "Attention"); 
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
