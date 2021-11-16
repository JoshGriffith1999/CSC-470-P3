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

        
        private List<Issue> Issues = new List<Issue>();
        Issue IssueInUse = new Issue();

        private string ValidateIssue(Issue issue)
        {
            string title = issue.Title.Trim();
            if (title == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            if (isDuplicateName(issue.Title)==true)
            {
                return DUPLICATE_TITLE_ERROR;
            }
            if (issue.DiscoveryDate == default(DateTime))
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            if (issue.DiscoveryDate > DateTime.Now)
            {
                return FUTURE_DISOVERY_DATETIME_ERROR;
            }
            if (issue.Discoverer == null || issue.Discoverer == "")
            {
                return EMPTY_DISCOVERY_ERROR;
            }
            return NO_ERROR;
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

            string validation = this.ValidateIssue(issue);
            if (validation == NO_ERROR) 
            {

                
                Issues.Add(issue);
                
                return NO_ERROR;
            }
            else
            {
                return validation;
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
            //YEAR - MONTH - AMOUNT IN THAT TIME
            List<Issue> ValidIssues = new List<Issue>();
            int[] monthYearCount= new int[24];
            /*
             
             
             
            */


            foreach(Issue i in Issues)
            {
                if (ProjectID == i.ProjectId) 
                {
                    if ((DateTime.Now-i.DiscoveryDate).TotalDays < 367)
                    {
                        ValidIssues.Add(i);
                        monthYearCount[(i.DiscoveryDate.Month-1)+((DateTime.Now.Year-i.DiscoveryDate.Year)*12)]++;
                    }
                }
            }
            int j = 0;
            foreach (int i in monthYearCount)
            {
                if (monthYearCount[j] > 0)
                {
                    if (j < 13)
                    {
                        IssuesByMonth.Add(DateTime.Now.Year.ToString() + " - " + (j + 1).ToString() + " - " + monthYearCount[j].ToString());
                    }
                    else
                    {
                        IssuesByMonth.Add((DateTime.Now.Year-1).ToString() + " - " + ((j + 1)-12).ToString() + " - " + monthYearCount[j].ToString());
                    }
                }
                j++;
            }
           
           
            return IssuesByMonth;
        }
        //GetIssueByDiscoverer is working perfectly!
        public List<string> GetIssueByDiscoverer(int ProjectID) {

            List<String> IssuesByDiscover = new List<string>();
            int[] discovererCount = new int[100];
            string[] discovererCountTracker = new string[100];
            int dct = 0;
            int j = 0;
            bool test = false;
            foreach(Issue i in Issues) {
                if (i.ProjectId == ProjectID)
                {

                    if (dct > 0)
                    {
                        foreach (string k in discovererCountTracker)
                        {
                            if (k == i.Discoverer)
                            {
                                discovererCount[j]++;
                                test = true;
                            }
                            j++;
                        }
                        j = 0;
                    }
                    else if (test == false)
                    {
                        discovererCountTracker[dct] = i.Discoverer;
                        discovererCount[dct]++;
                        dct++;
                    }
                    test = false;
                }
            }

            foreach (string k in discovererCountTracker)
            {
                //Discoverer - count
                if (k != null)
                {
                    IssuesByDiscover.Add(k + " - " + discovererCount[j]);
                }
            }
            j = 0;



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
