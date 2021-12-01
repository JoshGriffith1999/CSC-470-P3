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
    public partial class FormModifyRequirement : Form
    {
        List<Feature> FeatureList = new List<Feature>();
        Requirement Requirement = new Requirement();
        Feature Feature = new Feature();
        public FormModifyRequirement(List<Feature> featureList, Requirement requirement, FakeFeatureRepository FR, FakeRequirementRepositpry RR)
        {
            InitializeComponent();
            CenterToParent();
            FeatureList = featureList;
            comboBox1.Text = Feature.Title.Trim();
            statementLabel.Text = requirement.Statement.Trim();
        }

        private void FormModifyRequirement_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void selectRequirementButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Statement must have a value");
            }
            else
            {
                Requirement.FeatureID = Feature.id;
                Requirement.Statement = textBox1.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
