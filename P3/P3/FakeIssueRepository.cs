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

            DateTime Today = DateTime.Today;
            //Checks for empty Issue Title
            if (issue.Title == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            //checks for empty issue date
            else if (issue.DiscoveryDate.To.ShortString == "")
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }

            //checks for Future Issue Date from year
            else if (issue.DiscoveryDate.Year > Today.Year)
            {
                return FUTURE_DISOVERY_DATETIME_ERROR;
            }

            else if (issue.DiscoveryDate.Month > Today.Month)
            {
                return FUTURE_DISOVERY_DATETIME_ERROR;
            }

            //Checks if a discoverer was added
            else if (issue.Discoverer == "")
            {
                return EMPTY_DISCOVERY_ERROR;
            }

            //All Tests passed
            else {
                issue.ID = Issues.Count + 1;
                Issues.Add(issue);
                return NO_ERROR;
            }
        }
        List<Issue> GetAll(int ProjectID) {
            return Issues;
        }
        public bool Remove(Issue issue) {
            bool inList = false;

            //Sees if issue passed in is actually in the repository
            //If so, sets inList to true
            foreach (int i in Issues) {
                if (i.ProjectId == issue.ProjectId) {
                    inList = true;
                    break;
                }
            }

            if (inList == false) {
                return inList;
            }
            else
            {
                Issues.Remove(issue);
                return inList;
            }
        }
        public int GetTotalNumberOfIssues(int ProjectID) {

            int numberOfIssues = 0;
            foreach(int i in Issues) {
                if (i.ProjectId == ProjectId)
                {
                    numberOfIssues++;
                }
            }

            return numberOfIssues;
        }
        public List<string> GetIssuesByMonth(int ProjectID) {
            List<string> IssuesByMonth;

            foreach (int i in Issues)
            {
                if (i.ProjectId == ProjectId)
                {
                    IssuesByDiscover.Add(i.DiscoveryDate.Month.ToString)
                }
            }
        }
        public List<string> GetIssueByDiscoverer(int ProjectID) {

            List<string> IssuesByDiscover;

            foreach(int i in Issues) {
                if (i.ProjectId == ProjectId)
                {
                    IssuesByDiscover.Add(i.Discoverer)
                }
            }

            return IssuesByDiscover;
        }
        public Issue GetUserByID(int ID) {
            foreach(int i in Issues) {
                if (i.ProjectId == ID)
                {
                    return i;
                }
            }
        }
    }
}
