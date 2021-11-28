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
        public void Add(int ID, string Value)
        {

            IssueStatus status = new IssueStatus();
            status.ID = ID;
            status.Value = Value;

            IssueStatuses.Add(status);

        }
        public List<IssueStatus> GetAll()
        {

            return IssueStatuses;
        }
        public int GetIDByStatus(string value)
        {

            foreach (IssueStatus i in IssueStatuses)
            {
                if (i.Value == value)
                {
                    return i.ID;
                }
            }
            //NOT SURE IF THIS IS CORRECT
            return -1;
        }
        public string GetValueByID(int ID)
        {
            foreach (IssueStatus i in IssueStatuses)
            {
                if (i.ID == ID)
                {
                    return i.Value.ToString();
                }
            }
            return "ERROR GetValByID";
        }
    }
}
