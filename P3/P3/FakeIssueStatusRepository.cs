using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private List<IssueStatus> IssueStatuses;
        /////////////////////////////////////
        void Add(int ID, string Value);
        List<IssueStatus> GetAll();
        int GetIDByStatus(string value);
        string GetValueByID(int ID);
    }
}
