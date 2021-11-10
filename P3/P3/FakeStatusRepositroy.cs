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
        public void Add(int ID, string Value) {

            IssueStatus status = new IssueStatus();
            status.ID = ID;
            status.Value = Value;

            IssueStatuses.Add(IssueStatuses);

        }
        public List<IssueStatus> GetAll() {

            return IssueStatuses;
        }
        public int GetIDByStatus(string value) {

            foreach (int i in IssueStatuses) {
                if (i.Values == value) {
                    return i.ID;
                }
            }
        }
        public string GetValueByID(int ID) {
            foreach (int i in IssueStatuses)
            {
                if (i.ID == ID)
                {
                    return i.Values;
                }
            }
        }
    }
}
