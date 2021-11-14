using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    interface IIssueStatusRepository
    {
        string Add(Issue issue, int out_id);
        string Remove(int IssueID);
        string Modify(int IssueID, Issue issue);
        List<Issue> GetAll();
        bool IsDuplicateName(string IssueTitle);
    }
}
