using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {

        private static List<Issue> Issues = new List<Issue>();

        public string Add(Issue issue, int out_id)
        {
            return "O";
        }
        public string Remove(int IssueID)
        {
            return "O";
        }
        public string Modify(int IssueID, Issue issue)
        {
            return "O";
        }
        public List<Issue> GetAll()
        {
            return Issues;
        }
        public bool IsDuplicateName(string IssueTitle)
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
                if (i < k.ID)
                {
                    i = k.ID;
                }
            }
            i++;
            return i;
        }

    }

}
