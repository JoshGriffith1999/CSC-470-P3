using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class FakeAppUserRepository : IAppUserRepository
    {
        private static Dictionary<string, AppUser> AppUsers;
        public FakeAppUserRepository()
        {
            if (AppUsers == null)
            {
                // A temporary dictionary to fake a database
                AppUsers = new Dictionary<string, AppUser>();
                AppUsers.Add("john", new AppUser
                {
                    UserName = "john",
                    Password = "go",
                    FirstName = "John",
                    LastName = "Doe",
                    EmailAddress = "john.doe@gmail.com",
                    IsAuthenticated = false
                });
            }
        }
        public bool Login(string UserName, string givenPassword)
        {
            bool match = false;
            AppUser appUser;
            if (AppUsers.TryGetValue(UserName, out appUser))
            {
                match = appUser.Password == givenPassword;
            }
            return match;
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
            AppUsers[UserName].IsAuthenticated = IsAuthenticated;
        }
        public AppUser GetByUserName(string UserName) {
            AppUser user;
            bool ignore = AppUsers.TryGetValue(UserName, out user);
            return user;
        }
    }
}
