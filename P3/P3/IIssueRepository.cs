using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    interface IIssueRepository
    {
        
        int GetNextId();
        bool isDuplicateName(string IssueTitle);
        string Add(Issue issue);
        List<Issue> GetAll(int ProjectID);
        string Modify(int IssueID, Issue issue);
        bool Remove(Issue issue);
        int GetTotalNumberOfIssues(int ProjectID);
        List<string> GetIssuesByMonth(int ProjectID);
        List<string> GetIssueByDiscoverer(int ProjectID);
        Issue GetUserByID(int ID);
    }
}
