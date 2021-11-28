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
    public partial class FormModifyFeature : Form
    {
        Feature FeatureInUse = new Feature();
        FakeFeatureRepository FeatureRepo = new FakeFeatureRepository();
        int ProjectID;

        public FormModifyFeature()
        {
            InitializeComponent();
            CenterToScreen();
            TitleTextBox.Focus();
        }
        public FormModifyFeature(Project CurrentProject, FakeFeatureRepository F, Feature SF)
        {
            InitializeComponent();
            CenterToScreen();
            TitleTextBox.Focus();
            ProjectID = CurrentProject.ID;
            FeatureRepo = F;
            FeatureInUse = SF;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
       
        private void ModifyFeatureButton_Click_1(object sender, EventArgs e)
        {
            FeatureInUse.Title = TitleTextBox.Text;
            

            string result = FeatureRepo.Modify(FeatureInUse);
            if (result != FeatureRepo.NO_ERROR)
            {
                MessageBox.Show(result, "Attention");
            }
            else
            {
                MessageBox.Show("Feature added.");

                this.Hide();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
