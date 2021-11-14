using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class Issue
    {
        public int ID;
        public string Title;
        public DateTime Date;
        public string Discoverer;
        public string InitialDescription;
        public string Component;
        public string Status;
         
        public Issue(int inputID, string inputTitle, DateTime inputDate, string inputDiscoverer, string inputInitialDescription, string inputComponent, string inputStatus)
        {
            ID = inputID;
            Title = inputTitle;
            Date = inputDate;
            Discoverer = inputDiscoverer;
            InitialDescription = inputInitialDescription;
            Component = inputComponent;
            Status = inputStatus;
        }
        public Issue() { }
    }
}
