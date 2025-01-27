﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class FakeRequirementRepositpry : IRequirementRepository
    {
        private List<Requirement> requirements= new List<Requirement>();

        public string NO_ERROR = "";
        public string DUPLICATE_STATEMENT_ERROR = "Statements must be unique";
        public string EMPYT_STATEMENT_ERROR = "Statement must have a value";
        public string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist";
        public string MISSING_FEATRUREID_ERROR = "Must select a feature for this requirement";
        public string MISSING_PROJECTID_ERROR = "Must select a project for this requirement";

        public string Add(Requirement requirement)
        {

            //Test if statement is empty
            if (requirement.Statement == "")
            {
                return EMPYT_STATEMENT_ERROR;
            }

            //Tetsn if state is a duplicate
            foreach (Requirement x in requirements)
            {
                if (x.Statement == requirement.Statement)
                {
                    return DUPLICATE_STATEMENT_ERROR;
                }
            }

            //Test if project ID is empty
            if (requirement.ProjectID == -1)
            {
                return MISSING_PROJECTID_ERROR;
            }

            //Test if feature ID is empty
            if (requirement.FeatureID == -1)
            {
                return MISSING_FEATRUREID_ERROR;
            }

            requirements.Add(requirement);
            return NO_ERROR;
        }
        public List<Requirement> GetALL(int ProjectID)
        {
            return requirements;
        }
        public string Remove(Requirement requirement)
        {

            bool removed = requirements.Remove(requirement);

            if (removed == false)
            {
                return REQUIREMENT_NOT_FOUND_ERROR;
            }

            return NO_ERROR;
        }
        public string Modify(Requirement requirement)
        {

            bool changed = false;

            foreach (Requirement x in requirements)
            {
                if (x.ID == requirement.ID)
                {
                    x.Statement = requirement.Statement;
                    changed = true;
                    break;
                }
            }

            if (changed == false)
            {
                return REQUIREMENT_NOT_FOUND_ERROR;
            }
            return NO_ERROR;
        }
        public Requirement GetRequirementByID(int RequirementID)
        {
            Requirement requirement = new Requirement();
            requirement.Statement = REQUIREMENT_NOT_FOUND_ERROR;


            foreach (Requirement x in requirements)
            {
                if (x.ID == RequirementID)
                {
                    return x;
                }
            }

            return requirement;
        }
        public int CountByFeature(int featureID)
        {
            int count = 0;

            foreach (Requirement x in requirements)
            {
                if (x.FeatureID == featureID)
                {
                    count += 1;
                }
            }

            return count;
        }
        public void RemoveByFeature(int featureID)
        {

            foreach (Requirement x in requirements)
            {
                if (x.FeatureID == featureID)
                {
                    requirements.Remove(x);
                }
            }
        }

    }
}
