using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class FakeIssueRepository : IIssueRepository
    {
        public string NO_ERROR = " ";
        public string EMPTY_TITLE_ERROR = "A title is required.";
        public string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a discovery Date/TIme";
        public string FUTURE_DISOVERY_DATETIME_ERROR = "Issue can't be from the future";
        public string EMPTY_DISCOVERY_ERROR = "A discoverer is required";
        public string DUPLICATE_TITLE_ERROR = "Issue title must be unique.";

        FakeIssueRepository IssueRepo = new FakeIssueRepository();
        private List<Issue> Issues = new List<Issue>();
        Issue IssueInUse = new Issue();

        private string ValidateIssue(Issue issue)
        {
            return "O";
        }
        public bool isDuplicateName(string IssueTitle)
        {
            bool checker = false;
            foreach (Issue k in Issues)
            {
                if (k.Title == IssueTitle)
                    checker = true;
            }
            return checker;
        }
        public int GetNextId()
        {
            int i = 0;
            foreach (Issue k in Issues)
            {
                if (i < k.Id)
                {
                    i = k.Id;
                }
            }
            i++;
            return i;
        }
        //////////////////////////////////////////////////////////////////
        public string Add(Issue issue) {
            DateTime Today = DateTime.Today;
            //Checks for empty Issue Title
            if (issue.Title == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            //Checks for duplicate Issue Title
            bool checker;
            checker = IssueRepo.isDuplicateName(issue.Title);
            if (checker == true)
            {
                return DUPLICATE_TITLE_ERROR;
            }
            //checks for future issue date
            else if (issue.DiscoveryDate > DateTime.Now)
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
                issue.Id = Issues.Count + 1;
                Issues.Add(issue);
                return NO_ERROR;
            }
        }
        public List<Issue> GetAll(int ProjectID) {
            return Issues;
        }
        public bool Remove(Issue issue) {
            bool inList = false;

            //Sees if issue passed in is actually in the repository
            //If so, sets inList to true
            foreach (Issue i in Issues) {
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
        public string Modify(int IssueID, Issue issue)
        {
            return "O";
        }
        public int GetTotalNumberOfIssues(int ProjectID) {

            int numberOfIssues = 0;
            foreach(Issue i in Issues) {
                if (i.ProjectId == ProjectID)
                {
                    numberOfIssues++;
                }
            }

            return numberOfIssues;
        }
        public List<string> GetIssuesByMonth(int ProjectID) {
            List<string> IssuesByMonth = new List<string>();

            foreach (Issue i in Issues)
            {
                if (i.ProjectId == ProjectID)
                {
                    IssuesByMonth.Add(i.DiscoveryDate.Month.ToString());
                }
            }
            return IssuesByMonth;
        }
        public List<string> GetIssueByDiscoverer(int ProjectID) {

            List<String> IssuesByDiscover = new List<string>();

            foreach(Issue i in Issues) {
                if (i.ProjectId == ProjectID)
                {
                    
                    IssuesByDiscover.Add(i.Discoverer);
                }
            }

            return IssuesByDiscover;
        }
        public Issue GetUserByID(int ID) {
            foreach(Issue i in Issues) {
                if (i.ProjectId == ID)
                {
                    return i;
                }
            }
            Issue k = new Issue();
            return k;
        }
    }
}
