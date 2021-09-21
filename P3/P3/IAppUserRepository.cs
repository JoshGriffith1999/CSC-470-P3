using System;
using System.Collections.Generic;
using System.Text;

namespace P3
{
    interface IAppUserRepository
    {
        public bool Login(string UserName, string Password);
        public List<AppUser> GetALL();
        public void SetAuthentication(string UserName,  bool IsAuthenticated);
        public AppUser GetByUserName(string UserName);

    }
}
