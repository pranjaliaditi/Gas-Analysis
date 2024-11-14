using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gas_Analysis
{
    public partial class Analyse : Form
    {
        public Analyse()
        {
            InitializeComponent();
            this.Text = "Gas Analysis Results";
        }

        public void SetRatios(
            string place, DateTime date, double graham, double jt, double ch, double coResidual,
            double morris, double desorbedHydrocarbon, double youngs, double willets,
            double oxygenConcentration, double coCo2)
        {
            txtboxPlace.Text = place;
            txtboxDate.Text = date.ToString();
            txtGrahamRatio.Text = graham.ToString("F4");
            txtJTRatio.Text = jt.ToString("F4");
            txtCHRatio.Text = ch.ToString("F4");
            txtCOResidual.Text = coResidual.ToString("F4");
            txtMorrisRatio.Text = morris.ToString("F4");
            txtDesorbedHydrocarbon.Text = desorbedHydrocarbon.ToString("F4");
            txtYoungsRatio.Text = youngs.ToString("F4");
            txtWilletsRatio.Text = willets.ToString("F4");
            txtOxygenConcentration.Text = oxygenConcentration.ToString("F4");
            txtCOCO2Ratio.Text = coCo2.ToString("F4");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblWilletsRatio_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                // Show a SaveFileDialog to let the user choose the save location
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files|*.txt";
                saveFileDialog.Title = "Save Analysis Report as Text File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Path to save the file
                    string filePath = saveFileDialog.FileName;

                    // Create a string with all the data to save
                    var reportContent = new System.Text.StringBuilder();
                    reportContent.AppendLine("Gas Analysis Report");
                    reportContent.AppendLine();
                    reportContent.AppendLine("Place: " + txtboxPlace.Text);
                    reportContent.AppendLine("Date: " + txtboxDate.Text);
                    reportContent.AppendLine();
                    reportContent.AppendLine("Graham's Ratio: " + txtGrahamRatio.Text);
                    reportContent.AppendLine("JT Ratio: " + txtJTRatio.Text);
                    reportContent.AppendLine("C/H Ratio: " + txtCHRatio.Text);
                    reportContent.AppendLine("CO Residual Gas Relation: " + txtCOResidual.Text);
                    reportContent.AppendLine("Morris Ratio: " + txtMorrisRatio.Text);
                    reportContent.AppendLine("Desorbed Hydrocarbon Index: " + txtDesorbedHydrocarbon.Text);
                    reportContent.AppendLine("Young's Ratio: " + txtYoungsRatio.Text);
                    reportContent.AppendLine("Willet's Ratio: " + txtWilletsRatio.Text);
                    reportContent.AppendLine("CO/CO2 Ratio: " + txtCOCO2Ratio.Text);

                    // Write the content to the file
                    System.IO.File.WriteAllText(filePath, reportContent.ToString());

                    MessageBox.Show("Report saved successfully!", "Save Successful");
                }
            

        }
    }
}
