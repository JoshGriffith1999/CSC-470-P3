using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace P3
{
    class FakeAppUserRepository : IAppUserRepository
    {
        private static Dictionary<string, AppUser> AppUsers;
        //Methods from the IAppUserRepositry Interface
        private bool ValidateUserName(string userName)
        {
            foreach (KeyValuePair<string, AppUser> keyValuePair in AppUsers)
            {

                if (keyValuePair.Key == userName)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private bool ValidatePassword(string password)
        {
            foreach (KeyValuePair<string, AppUser> keyValuePair in AppUsers)
            {

                if (keyValuePair.Key == password)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool Login(string UserName, string Password)
        {
            if (string.IsNullOrEmpty(UserName))
            {
                return false;

            }
            else if (string.IsNullOrEmpty(Password))
            {
                return false;
            }
            else
            {
                string StringWithoutSpclCharac;
                StringWithoutSpclCharac = Regex.Replace(UserName, @"[^0-9a-zA-Z:,]+", "");
                bool testUserName = ValidateUserName(StringWithoutSpclCharac);
                StringWithoutSpclCharac = Regex.Replace(Password, @"[^0-9a-zA-Z:,]+", "");
                bool testPassword = ValidatePassword(StringWithoutSpclCharac);
                if (testUserName == true &&testPassword == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }           
        public List<AppUser> GetALL() {
            List<AppUser> users = new List<AppUser>();
            foreach (KeyValuePair<string, AppUser> user in AppUsers)
            {
                users.Add(user.Value);
            }
            return users;
        }
        public void SetAuthentication(string UserName, bool IsAuthenticated) {
            
        }
        public AppUser GetByUserName(string UserName) {
            AppUser user;
            bool ignore = AppUsers.TryGetValue(UserName, out user);
            return user;
        }
    }
}
