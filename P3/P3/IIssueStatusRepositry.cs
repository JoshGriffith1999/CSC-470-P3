using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    interface IIssueStatusRepositry
    {
        void Add(int ID, string Value);
        List<IssueStatus> GetAll();
        int GetIDByStatus(string value);
        string GetValueByID(int ID);
    }
}
