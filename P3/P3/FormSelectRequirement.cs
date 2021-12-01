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
    public partial class FormSelectRequirement : Form
    {
        FakeFeatureRepository FeatureRepo = new FakeFeatureRepository();
        FakeRequirementRepositpry RequirementRepo = new FakeRequirementRepositpry();
        List<Feature> Features = new List<Feature>();
        public FormSelectRequirement(FakeRequirementRepositpry R, FakeFeatureRepository F, List<Feature> FL, List<Requirement> RL)
        {
            InitializeComponent();
            CenterToParent();
        }

        private void selectRequirementButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
