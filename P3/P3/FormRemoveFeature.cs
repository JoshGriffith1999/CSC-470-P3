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
    public partial class FormRemoveFeature : Form
    {
        FakeFeatureRepository FeatureRepo = new FakeFeatureRepository();
        Feature FeatureInUse = new Feature();
        public FormRemoveFeature()
        {
            InitializeComponent();
        }

        public FormRemoveFeature(Feature SelectedFeature, FakeFeatureRepository F)
        {
            InitializeComponent();
            CenterToScreen();
            FeatureRepo = F;
            FeatureInUse = SelectedFeature;
            RemoveTitleLabel.Text = FeatureInUse.Title + "?";
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            //Need to create confirmation dialog if there are attached requirements
            FeatureRepo.Remove(FeatureInUse);
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            MessageBox.Show("Remove Canceled");
            this.Close();
        }
    }
}
