using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class FakeProjectRepository : IProjectRepository
    {
        public const string NO_ERROR = "No Errors";
        public const string MODIFIED_PROJECT_ID = "MODIFIED_PROJECT_ID";
        public const string DUPICATE_PROJECT_NAME_ERROR = "DUPICATE_PROJECT_NAME_ERROR";
        public const string NO_PROJECT_FOUND_ERROR = "NO_PROJECT_FOUND_ERROR";
        public const string EMPTY_PROJECT_NAME_ERROR = "EMPTY_PROJECT_NAME_ERROR";
        private static List<Project> Projects = new List<Project>();
        /****************************************************************************/
        public FakeProjectRepository()
        {
            if (Projects.Count <= 1)
            {
                Project test0 = new Project(0, "test0");
                Projects.Insert(0, test0);
                Project test1 = new Project(1, "test1");
                Projects.Insert(1, test1);
                Project test2 = new Project(2, "test2");
                Projects.Insert(2, test2);
                Project test3 = new Project(3, "test3");
                Projects.Insert(3, test3);
            }
            
        }
       public  string Add(Project project, int out_id) {
            //The following line might work? I do not know as of now
            int i = this.GetNextInt();
            project.ID = i;
            Projects.Append(project);
            return "New Project created";
        }
       public string Remove(int ProjectID) {
            //This might work? Not sure exactly. We will need to create a form to be able to select the one we want to remove.
            Projects.RemoveAt(ProjectID);
            return "Project Removed";
        }
       public string Modify(int ProjectID, Project project) {
            return "Test";
        }
       public List<Project> GetAll() {
            return Projects;
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
