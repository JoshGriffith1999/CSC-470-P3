using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class FakeIssueRepository : IIssueRepository
    {
        public string NO_ERROR = " ";
        public string EMPTY_TITLE_ERROR = "A title is required.";
        public string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a discovery Date/TIme";
        public string FUTURE_DISOVERY_DATETIME_ERROR = "Issue can't be from the future";
        public string EMPTY_DISCOVERY_ERROR = "A discoverer is required";

        private List<Issue> Issues;


        private string ValidateIssue(Issue issue);
        private bool isDuplicate(string title);

        //////////////////////////////////////////////////////////////////
        public string Add(Issue issue) { 
            
        }
        List<Issue> GetAll(int ProjectID);
        public bool Remove(Issue issue);
        public int GetTotalNumberOfIssues(int ProjectID);
        public List<string> GetIssuesByMonth(int ProjectID);
        public List<string> GetIssueByDiscoverer(int ProjectID);
        public Issue GetUserByID(int ID);
    }
}
