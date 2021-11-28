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
    public partial class FormSelectFeature : Form
    {
        FakeFeatureRepository issueRepo = new FakeFeatureRepository();
        Feature selectedFeature = new Feature();
        List<Feature> iss = new List<Feature>();
        public FormSelectFeature()
        {
            InitializeComponent();
            CenterToParent();
        }
        public FormSelectFeature(List<Feature> Features)
        {
            InitializeComponent();
            CenterToParent();
            iss = Features;
            this.SelectFeatureDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (Feature i in Features)
            {
                string[] row = new string[] { i.id.ToString(), i.Title};
                SelectFeatureDataGridView.Rows.Add(row);
            }

        }

        private void modifyCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void modifySelect_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = SelectFeatureDataGridView.SelectedRows;
            string selectedCell = (string)rows[0].Cells[0].Value;
            foreach (Feature i in iss)
            {
                if (i.id.ToString() == selectedCell)
                {
                    selectedFeature = i;
                    this.DialogResult = DialogResult.OK;
                    this.Hide();

                }
            }



        }
        public Feature getSelectedFeature()
        {
            return selectedFeature;
        }

        private void SelectFeatureDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
