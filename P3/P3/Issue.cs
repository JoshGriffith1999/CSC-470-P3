using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class Issue
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }

        public int IssueStatusID;
        public string Title { get; set; }
        public DateTime DiscoveryDate;
        public string Discoverer;
        public string InitialDescription;
        public string Component;
        public string Status;

        public Issue(int inputID, string inputTitle, DateTime inputDate, string inputDiscoverer, string inputInitialDescription, string inputComponent, string inputStatus)
        {
            Id = inputID;
            Title = inputTitle;
            DiscoveryDate = inputDate;
            Discoverer = inputDiscoverer;
            InitialDescription = inputInitialDescription;
            Component = inputComponent;
            Status = inputStatus;
        }
        public Issue() { }
    }
}
