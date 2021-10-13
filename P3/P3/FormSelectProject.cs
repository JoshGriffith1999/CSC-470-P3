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

        FakeProjectRepository Repository = new FakeProjectRepository();
        Project ProjectInUse = new Project();
        public FormSelectProject()
        {
            InitializeComponent();
        }

        public FormSelectProject(FakeProjectRepository P, List<Project> Projects)
        {

            InitializeComponent();
            Projects = P.GetAll();
            
            string fillbox = "Hello";
            int i = 0;
           // SelectProjectListBox.DataSource = Projects;

            //MessageBox.Show(fillbox);
            foreach (Project p in Projects)
            {
                i = p.ID;
                fillbox = p.ID + " - " + p.Name;

                SelectProjectListBox.Items.Insert(i,fillbox);
                
            }

        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void SelectProjectButton_Click(object sender, EventArgs e)
        {
            string listitem = SelectProjectListBox.SelectedItem.ToString();
            string[] split = listitem.Split(' ');
            int index = Int32.Parse(split[0]);
            string itemName = split[2];
            ProjectInUse.ID = index;
            ProjectInUse.Name = itemName;
            this.Hide();
        }
        
        public Project returnProject()
        {
            return ProjectInUse;
        }
        
    }
}
