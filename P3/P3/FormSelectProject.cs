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
    public partial class FormSelectProject : Form
    {
        Project project = new Project();
        FakeProjectRepository P = new FakeProjectRepository();
        public FormSelectProject()
        {
            InitializeComponent();
            
            string fillbox = "Hello";
            List<Project> Projects = P.GetAll();
            //SelectProjectListBox.DataSource = Projects;
            if(Projects != null)
                fillbox = Projects[1].ID + " - " + Projects[1].Name;
            MessageBox.Show(fillbox);
            foreach (Project p in Projects)
            {
                fillbox = p.ID + " - " + p.Name;
                
                SelectProjectListBox.Items.Add(fillbox);
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void SelectProjectButton_Click(object sender, EventArgs e)
        {

        }
    }
}
