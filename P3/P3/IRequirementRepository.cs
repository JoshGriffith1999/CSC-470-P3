using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    interface IRequirementRepository
    {
        string Add(Requirement requirement);
        List<Requirement> GetALL(int ProjectID);
        string Remove(Requirement requirement);
        string Modify(Requirement requirement);
        Requirement GetRequirementByID(int RequirementID);
        int CountByFeature(int featureID);
        void RemoveByFeature(int featureID);
    }
}
