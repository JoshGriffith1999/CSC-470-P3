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
    public partial class FormLogin : Form
    {
        private int FailedAttempts = 0;
        private bool Passed = true;
        private AppUser User = new AppUser();

        FakeAppUserRepository UserRepository = new FakeAppUserRepository();
        public FormLogin()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.User.UserName = UserNameTextBox.Text.ToString();
            this.User.Password = PasswordTextBox.Text.ToString();

            bool canSignIn = UserRepository.Login(this.User.UserName, this.User.Password);
                  
            //This here is for by passing the authentication step - delete before final commit
            if (this.User.UserName == "john" && this.User.Password == "go")
            {
                UserRepository.SetAuthentication(this.User.UserName, true);
                this.DialogResult = DialogResult.OK;
            }

            if(canSignIn != true)
            {
                this.FailedAttempts += 1;
                if(this.FailedAttempts == 3)
                {
                    this.Passed = false;
                    this.Close();
                }
                MessageBox.Show("Invalid Login, Please Reenter", "Attention");
            }
            else
            {
                UserRepository.SetAuthentication(this.User.UserName, true);
            }



        }

        /***************Public Methods**************************/
        /// <returns></returns>
        public bool IsUserAuthenticated()
        {
            return this.User.IsAuthenticated;
        }

        public bool returnPassed()
        {
            return this.Passed;
        }

        public AppUser returnUser() {

            return this.User;
        }

        public bool setAuthentication(string UserName) {

            UserRepository.SetAuthentication(UserName, true);
            return true;
        }
    }

}