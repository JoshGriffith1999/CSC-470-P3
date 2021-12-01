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
    public partial class FormRemoveRequirement : Form
    {
        FakeFeatureRepository Features = new FakeFeatureRepository();
        FakeRequirementRepositpry Requirements = new FakeRequirementRepositpry();

        List<Feature> features = new List<Feature>();
        List<Requirement> requirements = new List<Requirement>();
        public FormRemoveRequirement()
        {
            InitializeComponent();
        }

        public FormRemoveRequirement(FakeFeatureRepository F, FakeRequirementRepositpry R, List<Feature> FL, List<Requirement> RL)
        {
            InitializeComponent();
            CenterToScreen();
            featureComboBox.Focus();

            Features = F;
            Requirements = R;
            features = FL;
            requirements = RL;

            //Fill Features
            foreach (Feature x in features) {

                featureComboBox.Items.Add(x.Title);
            }
        }
    }
}
