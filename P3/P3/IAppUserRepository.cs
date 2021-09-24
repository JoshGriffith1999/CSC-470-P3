using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    interface IAppUserRepository
    {
        bool Login(string UserName, string Password);
        List<AppUser> GetALL();
        void SetAuthentication(string UserName, bool IsAuthenticated);
        AppUser GetByUserName(string UserName);

    }
}
