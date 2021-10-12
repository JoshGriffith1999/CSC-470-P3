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
        private AppUser User = new AppUser();
        FakeAppUserRepository UserRepository = new FakeAppUserRepository();

        public FormLogin()
        {
            InitializeComponent();
            CenterToScreen();
            PasswordTextBox.PasswordChar = '*';
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.User.UserName = UserNameTextBox.Text.ToString();
            this.User.Password = PasswordTextBox.Text.ToString();
            this.User.IsAuthenticated = false;
            this.DialogResult = DialogResult.None;

            Login();
            this.Hide();
        }

        public AppUser GetUser()
        {
            return this.User;
        }

        public void Login() {

            bool IsAuthenticatied = UserRepository.Login(this.User.UserName, this.User.Password);

            if (IsAuthenticatied == true)
            {
                this.DialogResult = DialogResult.OK;
                setAuthentication(this.User.UserName, true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Attention");
            }

        }

        public void setAuthentication(string UserToAuthent, bool authent) {
            UserRepository.SetAuthentication(UserToAuthent, authent);
            User = UserRepository.GetByUserName(UserToAuthent);
        }

    }

}
