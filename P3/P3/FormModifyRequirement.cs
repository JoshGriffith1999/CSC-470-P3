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
        Feature Feature = new Feature();
        Requirement Requirement = new Requirement();
        public FormModifyRequirement(Feature feature, Requirement requirement)
        {
            InitializeComponent();
            CenterToParent();
            Feature = feature;
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
