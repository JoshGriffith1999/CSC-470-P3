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

        private void featureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            requirementGridView.Enabled = true;

            foreach (Requirement i in requirements)
            {
                string[] row = new string[] { i.ID.ToString(), i.Statement };
                requirementGridView.Rows.Add(row);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Requirement SelectedRequirement = new Requirement();
            DataGridViewSelectedRowCollection rows = requirementGridView.SelectedRows;
            string selectedCell = (string)rows[0].Cells[0].Value;

            foreach (Requirement i in requirements)
            {
                if (i.ID.ToString() == selectedCell)
                {
                    SelectedRequirement = i;
                }
            }

            DialogResult result = MessageBox.Show("Are you sure that you want to remove this requirement?", "Attention", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Requirements.Remove(SelectedRequirement);
            }
            else {
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FakeRequirementRepositpry returnRepo() {
            return Requirements;
        }
    }
}
