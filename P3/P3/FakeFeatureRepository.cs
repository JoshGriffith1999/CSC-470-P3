using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class FakeFeatureRepository : IFeatureRepository
    {

        private List<Feature> features = new List<Feature>();
        /************************************************/
        public string NO_ERROR = "";
        public string DUPLICATE_TITLE_ERROR = "Title must be unique";
        public string EMPTY_TITLE_ERROR = "Title must have a value";
        public string NOT_FOUND_ERROR = "Feature not found";
        public string INVALID_PROJECT_ID_ERROR = "Invalid Project ID for feature";

        /********************************************8*/
        public string Add(Feature feature)
        {

            //Test to see if title is empty
            if (feature.Title == "")
            {
                return EMPTY_TITLE_ERROR;
            }

            //Test to see if there is a duplicate title
            foreach (Feature x in features)
            {
                if (feature.Title == x.Title)
                {
                    return DUPLICATE_TITLE_ERROR;
                }
            }
            feature.id = GetNextId();
            features.Add(feature);
            return NO_ERROR;
        }
        public List<Feature> GetAll(int ProjectID)
        {

            return features;
        }
        private int GetNextId()
        {
            int i = 0;
            foreach (Feature k in features)
            {
                if (i < k.id)
                {
                    i = k.id;
                }
            }
            i++;
            return i;
        }
        public string Remove(Feature feature)
        {

            bool isRemoved = features.Remove(feature);

            if (isRemoved == false)
            {
                return NOT_FOUND_ERROR;
            }
            return NO_ERROR;
        }
        public string Modify(Feature feature)
        {

            bool successfullChange = false;
            //Test to see if title is empty
            if (feature.Title == "")
            {
                return EMPTY_TITLE_ERROR;
            }

            //Test to see if there is a duplicate title
            foreach (Feature x in features)
            {
                if (feature.Title == x.Title)
                {
                    return DUPLICATE_TITLE_ERROR;
                }
            }
            foreach (Feature x in features)
            {

                if (x.id == feature.id)
                {
                    x.ProjectID = feature.ProjectID;
                    x.Title = feature.Title;
                    successfullChange = true;
                }

            }

            if (successfullChange == false)
            {
                return NOT_FOUND_ERROR;
            }
            return NO_ERROR;
        }
        public Feature GetFeatureByID(int projectID, int featureID)
        {
            Feature feature = new Feature();
            feature.Title = NOT_FOUND_ERROR;

            for (int x = 0; x < features.Count; x++)
            {
                if (features[x].id == featureID && features[x].ProjectID == projectID)
                {
                    feature = features[x];
                }
            }

            return feature;
        }
        public Feature GetFeatureByTitle(int projecID, string title)
        {
            Feature feature = new Feature();
            feature.Title = NOT_FOUND_ERROR;

            for (int x = 0; x < features.Count; x++)
            {
                if (features[x].Title == title && features[x].ProjectID == projecID)
                {
                    feature = features[x];
                }
            }

            return feature;
        }
    }
}
