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
        private AppUser User = new AppUser();
        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();
            Load += new EventHandler(FormMain_load);
        }

        private void FormMain_load(object sender, System.EventArgs e)
        {
            this.Hide();
            FormLogin Login = new FormLogin();
            Login.ShowDialog();
            DialogResult result = Login.ShowDialog();
            this.User.IsAuthenticated = Login.IsUserAuthenticated();

            //This triggers if the user has failed three login in attempts
            if (Login.returnPassed() == false)
            {
                //Exit application entirely
                this.Close();
                Application.Exit();
            }

            //These trigger if the number of failed attempts are less then 3
            if (this.User.IsAuthenticated != true && result != DialogResult.OK)
            {
                Login.setAuthentication(User.UserName);
            }
            else
            {
                this.User = Login.returnUser();
                this.Text = "Main - No Project Selected";
            }
        }

        
    }
}
