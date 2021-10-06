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
            setUp();
        }

        void setUp()
        {
            FormLogin Login = new FormLogin();

            DialogResult result = Login.ShowDialog();
            this.User.IsAuthenticated = Login.IsUserAuthenticated();

            //This triggers if the user has failed three login in attempts
            if (Login.returnPassed() == false)
            {
                this.Close();
            }

            //These trigger if the number of failed attempts are less then 3
            if (this.User.IsAuthenticated != true && result != DialogResult.OK)
            {
                Login.setAuthentication(User.UserName);
            }
            else
            {
                this.User = Login.returnUser();
            }
        }

        
    }
}
