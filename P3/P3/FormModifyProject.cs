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
    public partial class FormModifyProject : Form
    {
        private FakeProjectRepository Repo = new FakeProjectRepository();
        private List<Project> Projects;
        private Project ProjectInUse;
        private Project selectProject;

        public FormModifyProject()
        {
            InitializeComponent();
        }

        public FormModifyProject(Project ProjInUse, Project selectedProj)
        {
            InitializeComponent();
            CenterToParent();
            this.ProjectInUse = ProjInUse;
            this.selectProject = selectedProj;
            this.textBox1.Text = selectedProj.Name.ToString();
            this.textBox1.Focus();
        }

        private void CancelModify_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            if (this.ProjectInUse.Name == this.selectProject.Name || this.ProjectInUse.ID == this.selectProject.ID)
            {
                MessageBox.Show("Cannot modify your current session project.");
                this.Close();
            }
            else
            {
                //remove blanks
                string newProjName = this.textBox1.Text.ToString();
                newProjName.Trim();
                if (newProjName.Length < 1)
                {
                    MessageBox.Show("Project Name is Empty or Blank");
                }
                else
                {
                    //duplicate names
                    if (Repo.IsDuplicateName(newProjName))
                    {
                        MessageBox.Show("Project Name already exists.");
                    }
                    else
                    {
                        this.selectProject.Name = newProjName;
                    }
                }
                string m = this.Repo.Modify(this.selectProject.ID, this.selectProject);
                MessageBox.Show(m);
                this.Close();
            }

        }

        private void FormModifyProject_Load(object sender, EventArgs e)
        {

        }
    }
}
