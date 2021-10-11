using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class FakeProjectRepository : IProjectRepository
    {
        public const string NO_ERROR = "No Erros";
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
       public string Remove(int ProjectID) { }
       public string Modify(int ProjectID, Project project) { }
        Project GetAll() {       }
       public bool IsDuplicateName(string ProjectName) { }

    }
}
