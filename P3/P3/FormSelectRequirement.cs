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
        List<Requirement> Requirements = new List<Requirement>();
        Requirement SelectedRequirement = new Requirement();
        public FormSelectRequirement(FakeRequirementRepositpry R, FakeFeatureRepository F, List<Feature> FL, List<Requirement> RL)
        {
            InitializeComponent();
            CenterToParent();
            this.RequirementsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RequirementsDataGridView.Enabled = false;
            Requirements = RL;
            FeatureRepo = F;
            RequirementRepo = R;
            Features = FL;
            Requirements = RL;

            foreach (Feature feature in FL)
            {
                comboBox1.Items.Add(feature.Title);
            }
        }

        private void selectRequirementButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = RequirementsDataGridView.SelectedRows;
            string selectedCell = (string)rows[0].Cells[0].Value;
            foreach (Requirement i in Requirements)
            {
                if (i.ID.ToString() == selectedCell)
                {
                    SelectedRequirement = i;
                    this.DialogResult = DialogResult.OK;
                    this.Hide();

                }
            }
        }


       
        public Requirement getSelectedRequirement()
        {
            return SelectedRequirement;
        }




        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequirementsDataGridView.Enabled = true;
            
            foreach (Requirement i in Requirements)
            {
                string[] row = new string[] { i.ID.ToString(), i.Statement };
                RequirementsDataGridView.Rows.Add(row);
            }
        }

        private void RequirementsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
