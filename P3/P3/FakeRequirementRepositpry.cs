using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class FakeRequirementRepositpry : IRequirementRepository
    {
        private List<Requirement> requirements;

        string NO_ERROR = "";
        string DUPLICATE_STATEMENT_ERROR = "Statements must be unique";
        string EMPYT_STATEMENT_ERROR = "Statement must have a value";
        string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist";
        string MISSING_FEATRUREID_ERROR = "Must select a feature for this requirement";
        string MISSING_PROJECTID_ERROR = "Must select a project for this requirement";

        public string Add(Requirement requirement) {

            //Test if statement is empty
            if (requirement.Statement == "") {
                return EMPYT_STATEMENT_ERROR;
            }

            //Tetsn if state is a duplicate
            for (int x = 0; x < requirements.Count; x++) {
                if (requirements[x].Statement == requirement.Statement) {
                    return DUPLICATE_STATEMENT_ERROR;
                }
            }

            //Test if project ID is empty
            if (requirement.ProjectID == -1) {
                return MISSING_PROJECTID_ERROR;
            }

            //Test if feature ID is empty
            if (requirement.FeatureID == -1) {
                return MISSING_FEATRUREID_ERROR;
            }

            requirements.Append(requirement);
            return NO_ERROR;
        }
        public List<Requirement> GetALL(int ProjectID) {
            List<Requirement> requirement = new List<Requirement>();

            for (int x = 0; x < requirements.Count; x++) {
                if (requirements[x].ProjectID == ProjectID) {
                    requirement.Append(requirements[x]);
                }
            }

            return requirement;
        
        }
        public string Remove(Requirement requirement) {

            bool removed = requirements.Remove(requirement);

            if (removed == false) {
                return REQUIREMENT_NOT_FOUND_ERROR;
            }

            return NO_ERROR;
        }
        public string Modify(Requirement requirement) {

            bool changed = false;

            for (int x = 0; x < requirements.Count; x++) {
                if (requirements[x].ID == requirement.ID) {
                    requirements[x] = requirement;
                    changed = true;
                    break;
                }
            }

            if (changed == false) {
                return REQUIREMENT_NOT_FOUND_ERROR;
            }
            return NO_ERROR;
        }
        public Requirement GetRequirementByID(int RequirementID) {
            Requirement requirement = new Requirement();
            requirement.Statement = REQUIREMENT_NOT_FOUND_ERROR;


            for (int x = 0; x < requirements.Count; x++) {
                if (requirements[x].ID == RequirementID) {
                    return requirements[x];
                }
            }

            return requirement;
        }
        public int CountByFeature(int featureID) {
            int count = 0;

            for (int x = 0; x < requirements.Count; x++) {
                if (requirements[x].FeatureID == featureID) {
                    count += 1;
                }
            }

            return count;
        }
        public void RemoveByFeature(int featureID) {

            for (int x = 0; x < requirements.Count; x++) {
                if (requirements[x].FeatureID == featureID) {
                    requirements.Remove(requirements[x]);
                }
            }
        }

    }
}
