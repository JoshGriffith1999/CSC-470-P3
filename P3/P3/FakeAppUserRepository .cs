using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace P3
{
    class FakeAppUserRepository : IAppUserRepository
    {
        private static Dictionary<int, AppUser> AppUsers;
        //Methods from the IAppUserRepositry Interface
        public bool Login(string UserName, string Password) {
          
        }
        public List<AppUser> GetALL() {
            List<AppUser> users = new List<AppUser>();
            foreach (KeyValuePair<int, AppUser> user in AppUsers)
            {
                users.Add(user.Value);
            }
            return users;
        }
        public void SetAuthentication(string UserName, bool IsAuthenticated) {
            
        }
        public AppUser GetByUserName(string UserName) {
            AppUser user;
            bool ignore = AppUser.TryGetValue(UserName, out user);
            return user;
        }
    }
}
