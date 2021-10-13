using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class Project
    {
        public int ID;
        public string Name;
        public Project(int inputID, string inputName)
        {
            ID = inputID;
            Name = inputName;
        }
        public Project() { }
    }
}
