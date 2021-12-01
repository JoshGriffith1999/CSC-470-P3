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

        public FormCreateRequirement(FakeFeatureRepository F, FakeRequirementRepositpry R, List<Feature> FL, List<Requirement> RL)
        {
            InitializeComponent();
            CenterToScreen();
            RequirementTextBox.Enabled = false;

            FeatureRepository = F;
            RequirementRepositpory = R;
            Requirements = RL;


            foreach (Feature feature in FL) {
                FeatureComboBox.Items.Add(feature.Title);
            }
        }

        private void AddRequirementButton_Click(object sender, EventArgs e)
        {
            var selected = FeatureComboBox.SelectedItem;

            Feature temp =  FeatureRepository.GetFeatureByTitle(1, selected.ToString());

            if (Requirements.Count != 0)
            {
                requirementInUse.ID = (Requirements.Last().ID) + 1;
            }
            else
            {
                requirementInUse.ID = 0;
            }
            requirementInUse.ProjectID = temp.ProjectID;
            requirementInUse.FeatureID = temp.id;
            requirementInUse.Statement = this.RequirementTextBox.Text.ToString();
            string result = RequirementRepositpory.Add(requirementInUse);
            
            if (result != RequirementRepositpory.NO_ERROR)
            {
                MessageBox.Show(result, "Attention");
            }
            else
            {
                MessageBox.Show("Requirement added.");

                this.Hide();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
