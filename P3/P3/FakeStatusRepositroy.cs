using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class FakeStatusRepositroy : IIssueStatusRepositry
    {
        private List<IssueStatus> IssueStatuses;
        /////////////////////////////////////
        public void Add(int ID, string Value);
        public List<IssueStatus> GetAll();
        public int GetIDByStatus(string value);
        public string GetValueByID(int ID);
    }
}
