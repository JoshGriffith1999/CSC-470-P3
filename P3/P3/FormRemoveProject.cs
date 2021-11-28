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
    public partial class FormRemoveProject : Form
    {
        private FakeProjectRepository Repo = new FakeProjectRepository();
        private List<Project> Projects = new List<Project>();
        private Project ProjectInUse = new Project();

        public FormRemoveProject()
        {
            InitializeComponent();

        }

        public FormRemoveProject(FakeProjectRepository R, Project U)
        {
            InitializeComponent();
            CenterToScreen();
            this.Repo = R;
            this.Projects = R.GetAll();
            this.ProjectInUse = U;
            this.RemoveProjectTextBox.Focus();


        }
        private void Remove_Button_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FakeProjectRepository returnRepo()
        {
            return this.Repo;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int RemoveProjectID = Int32.Parse(this.RemoveProjectTextBox.Text);
            bool found = false;
            DialogResult result;

            if (RemoveProjectID == ProjectInUse.ID)
            {
                MessageBox.Show("Cannot Remove Current Session Project", "Attention");
                this.Close();
            }
            else
            {
                foreach (Project P in Projects)
                {
                    if (RemoveProjectID == P.ID)
                    {
                        result = MessageBox.Show("Are you sure you want to remove " + P.Name, "Attention", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            found = true;
                        }
                        else
                        {
                            this.Close();
                        }

                    }

                }

                if (found == true)
                {
                    this.Repo.Remove(RemoveProjectID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No Project Found");
                }
            }
        }
    }
}
