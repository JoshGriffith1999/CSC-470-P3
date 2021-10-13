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
        private AppUser User = new AppUser();
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
                this.Text = "Main - No Project Selected";
            }
        }

        private void selectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifyProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
