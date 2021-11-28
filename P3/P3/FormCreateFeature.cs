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
    public partial class FormCreateFeature : Form
    {
        Feature FeatureInUse = new Feature();
        FakeFeatureRepository FeatureRepo = new FakeFeatureRepository();
        int ProjectID;
        public FormCreateFeature()
        {
            InitializeComponent();
            CenterToScreen();
            TitleTextBox.Focus();
        }
        public FormCreateFeature(Project CurrentProject, FakeFeatureRepository F)
        {
            InitializeComponent();
            CenterToScreen();
            TitleTextBox.Focus();
            ProjectID = CurrentProject.ID;
            FeatureRepo = F;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void CreateFeatureButton_Click(object sender, EventArgs e)
        {
            FeatureInUse.Title = TitleTextBox.Text;
            FeatureInUse.ProjectID = ProjectID;

            string result = FeatureRepo.Add(FeatureInUse);
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
        public FakeFeatureRepository GetFeatureRepo()
        {
            return FeatureRepo;
        }
    }
}
