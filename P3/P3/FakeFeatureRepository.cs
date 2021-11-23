using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class FakeFeatureRepository : IFeatureRepository
    {

        private List<Feature> features;
        /************************************************/
        string NO_ERROR = "";
        string DUPLICATE_TITLE_ERROR = "Title must be unique";
        string EMPTY_TITLE_ERROR = "Title must have a value";
        string NOT_FOUND_ERROR = "Feature not found";
        string INVALID_PROJECT_ID_ERROR = "Invalid Project ID for feature";

        /********************************************8*/
        public string Add(Feature feature) {

            //Test to see if title is empty
            if (feature.Title == "") {
                return EMPTY_TITLE_ERROR;
            }

            //Test to see if there is a duplicate titel
            for (int x = 0; x < features.Count; x++) {
                if (feature.Title == features[x].Title) {
                    return DUPLICATE_TITLE_ERROR;
                }
            }

            return NO_ERROR;
        }
        public List<Feature> GetAll(int ProjectID) {

            List<Feature> returnFeature = new List<Feature>();

            for (int x = 0; x < features.Count; x++) {
                if (features[x].ProjecyID == ProjectID) {
                    returnFeature.Append(features[x]);
                }
            }
                return returnFeature;
        }
        public string Remove(Feature feature) {

            bool isRemoved = features.Remove(feature);

            if (isRemoved == false) {
                return NOT_FOUND_ERROR;
            }
            return NO_ERROR;
        }
        public string Modify(Feature feature) {

            bool successfullChange = false;
            for (int x = 0; x < features.Count; x++) {

                if (features[x].id == feature.id) {
                    features[x].ProjecyID = feature.ProjecyID;
                    features[x].Title = feature.Title;
                    successfullChange = true;
                }
            
            }

            if (successfullChange == false) {
                return NOT_FOUND_ERROR;
            }
            return NO_ERROR;
        }
        public Feature GetFeatureByID(int projectID, int featureID) {
            Feature feature = new Feature();
            feature.Title = NOT_FOUND_ERROR;

            for (int x = 0; x < features.Count; x++) {
                if (features[x].id == featureID && features[x].ProjecyID == projectID) {
                    feature = features[x];
                }
            }

            return feature;
        }
        public Feature GetFeatureByTitle(int projecID, string title) {
            Feature feature = new Feature();
            feature.Title = NOT_FOUND_ERROR;

            for (int x = 0; x < features.Count; x++)
            {
                if (features[x].Title == title && features[x].ProjecyID == projecID)
                {
                    feature = features[x];
                }
            }

            return feature;
        }
    }
}
