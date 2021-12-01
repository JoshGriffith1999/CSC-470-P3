using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3
{
    
    public partial class FormCreateRequirement : Form
    {
        FakeFeatureRepository FeatureRepository = new FakeFeatureRepository();
        FakeRequirementRepositpry RequirementRepositpory = new FakeRequirementRepositpry();
       
        List<Feature> Features = new List<Feature>();
        List<Requirement> Requirements = new List<Requirement>();
       
        Requirement requirementInUse = new Requirement();
        
        public FormCreateRequirement()
        {
            InitializeComponent();
        }

        public FormCreateRequirement(FakeFeatureRepository F, FakeRequirementRepositpry R, List<Feature> FL)
        {
            InitializeComponent();
            CenterToScreen();
            RequirementTextBox.Enabled = false;

            FeatureRepository = F;
            RequirementRepositpory = R;

            foreach (Feature feature in FL) {
                FeatureComboBox.Items.Add(feature.Title);
            }
        }

        private void AddRequirementButton_Click(object sender, EventArgs e)
        {
            requirementInUse.ID = 0;
            requirementInUse.ProjectID = 0;
            requirementInUse.FeatureID = 0;
            requirementInUse.Statement = this.RequirementTextBox.Text.ToString();
            RequirementRepositpory.Add(requirementInUse);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FakeRequirementRepositpry returnRepo() {

            return RequirementRepositpory;
        }

        private void FeatureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequirementTextBox.Enabled= true;
        }
    }
}
