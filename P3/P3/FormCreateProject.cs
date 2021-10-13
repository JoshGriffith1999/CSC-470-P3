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
    public partial class FormCreateProject : Form
    {
        Project projects = new Project();
        FakeProjectRepository ProjectRepository = new FakeProjectRepository();

        public FormCreateProject()
        {
            InitializeComponent();
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            
                

            string outputMessage;
            string NewProjectName=AddProjectNameBox.Text.ToString();
            projects.Name = NewProjectName;
            //MessageBox.Show(projects.Name, "Attention");
            outputMessage = this.ProjectRepository.Add(projects, 0);
            MessageBox.Show(outputMessage, "Attention");
            this.Hide();

        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
