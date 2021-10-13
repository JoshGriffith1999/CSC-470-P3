using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class FakeProjectRepository : IProjectRepository
    {
        public const string NO_ERROR = "No Errors";
        public const string MODIFIED_PROJECT_ID = "MODIFIED_PROJECT_ID";
        public const string DUPICATE_PROJECT_NAME_ERROR = "DUPICATE_PROJECT_NAME_ERROR";
        public const string NO_PROJECT_FOUND_ERROR = "NO_PROJECT_FOUND_ERROR";
        public const string EMPTY_PROJECT_NAME_ERROR = "EMPTY_PROJECT_NAME_ERROR";
        private static List<Project> Projects = new List<Project>();
        /****************************************************************************/
       public  string Add(Project project, int out_id) {
            //The following line might work? I do not know as of now
            Projects.Insert(out_id, project);
            return "New Project created";
        }
       public string Remove(int ProjectID) {
            return "Test";
        }
       public string Modify(int ProjectID, Project project) {
            return "Test";
        }
       public Project GetAll() {
            return Projects[0];
        }
       public bool IsDuplicateName(string ProjectName) {
            bool checker = false;
            foreach(Project p in Projects)
            {
                if (p.Name == ProjectName)
                    checker = true;
            }
            return checker;
        }
        private int GetNextInt()
        {
            int i = 0;
            foreach(Project p in Projects)
            {
                if(i < p.ID)
                {
                    i = p.ID;
                }
            }
            i++;
            return i;
        }

    }
}
