namespace Gas_Analysis
{
    public partial class GasAnalysis : Form
    {
        public GasAnalysis()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ISMlogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the Place, Date, and percentages of gases. Click 'Analyze' to process the data or 'Import' to upload an Excel file.", "Help");
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Show a SaveFileDialog to let the user choose the save location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Save Gas Analysis Data as Text File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Path to save the file
                string filePath = saveFileDialog.FileName;

                // Collect all data entered in the form
                var reportContent = new System.Text.StringBuilder();
                reportContent.AppendLine("Gas Analysis Data Entry");
                reportContent.AppendLine();
                reportContent.AppendLine("Place: " + txtboxPlace.Text);
                reportContent.AppendLine("Date: " + dateTimePicker.Value.ToString("dd MMMM yyyy"));
                reportContent.AppendLine();

                // Append each gas percentage entered
                reportContent.AppendLine("Oxygen %: " + txtboxOxygen.Text);
                reportContent.AppendLine("Carbon Dioxide %: " + txtboxCO2.Text);
                reportContent.AppendLine("Methane %: " + txtboxch4.Text);
                reportContent.AppendLine("Hydrogen %: " + txtboxh2.Text);
                reportContent.AppendLine("Carbon Monoxide %: " + txtboxco.Text);
                reportContent.AppendLine("Hydrocarbons %: " + txtboxHydrocarbons.Text);
                reportContent.AppendLine("Hydrogen Sulfide %: " + textBoxH2S.Text);
                reportContent.AppendLine("Ethylene %: " + textBoxEthylene.Text);
                reportContent.AppendLine("Nitrogen %: " + textBoxN2.Text);

                // Write the content to the file
                System.IO.File.WriteAllText(filePath, reportContent.ToString());

                MessageBox.Show("Data saved successfully!", "Save Successful");
            }


        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values from the main form
                string place = txtboxPlace.Text;
                DateTime date = dateTimePicker.Value;


                // Parse gas values from TextBoxes, with error handling for invalid inputs
                double oxygen = double.Parse(txtboxOxygen.Text);
                double methane = double.Parse(txtboxch4.Text);
                double carbonDioxide = double.Parse(txtboxCO2.Text);
                double hydrogen = double.Parse(txtboxh2.Text);
                double carbonMonoxide = double.Parse(txtboxco.Text);
                double hydrocarbons = double.Parse(txtboxHydrocarbons.Text);
                double hydrogenSulfide = double.Parse(textBoxH2S.Text);
                double ethylene = double.Parse(textBoxEthylene.Text);
                double nitrogen = double.Parse(textBoxN2.Text);

                // Perform calculations for each ratio (use your actual formulas here)
                double grahamRatio = (carbonMonoxide / ((0.265 * nitrogen) - oxygen)) * 100;
                double jtRatio = (carbonDioxide + 0.75 * carbonMonoxide - 0.25 * hydrogen) / ((0.265 * nitrogen) - oxygen);
                double chRatio = (6 * (carbonDioxide + carbonMonoxide + methane + 2 * ethylene)) / ((2 * (nitrogen * (20.93 / 79.04) - oxygen - carbonDioxide + ethylene + methane)) + hydrogen - carbonMonoxide);
                double coResidual = carbonMonoxide / oxygen;
                double morrisRatio = hydrocarbons / hydrogenSulfide;
                double desorbedHydrocarbonIndex = 1000 * ((1.01 * hydrocarbons) - methane) / (hydrocarbons);
                double youngsRatio = (carbonDioxide * 100) / ((0.265 * nitrogen) - oxygen);
                //double willetsRatio = carbonMonoxide * 100 / (nitrogen - 79.04 + carbonDioxide - 0.03 + methane + hydrogen + carbonMonoxide + hydrocarbons + hydrogenSulfide + ethylene);
                double willetsRatio =  ( carbonMonoxide * 100) / ((nitrogen - 3.776 * oxygen) + (carbonDioxide - 0.03) + methane + hydrogen + carbonMonoxide + hydrogenSulfide + ethylene + hydrocarbons)
                double coCo2Ratio = carbonMonoxide / carbonDioxide;

                // Instantiate and pass calculated values to the AnalysisForm
                Analyse analysisForm = new Analyse();
                analysisForm.SetRatios(
                    place,
                    date,
                    grahamRatio,
                    jtRatio,
                    chRatio,
                    coResidual,
                    morrisRatio,
                    desorbedHydrocarbonIndex,
                    youngsRatio,
                    willetsRatio,
                    oxygen,
                    coCo2Ratio
                );

                // Show the AnalysisForm as a dialog
                analysisForm.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for all fields.", "Input Error");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Division by zero occurred in one of the calculations. Check your inputs.", "Calculation Error");
            }


        }

        private void btnCoward_Click(object sender, EventArgs e)
        {
            string place = txtboxPlace.Text;
            DateTime date = dateTimePicker.Value;
            double oxygen = double.Parse(txtboxOxygen.Text);
            double methane = double.Parse(txtboxch4.Text);

            CowardTriangle cowardTriangleForm = new CowardTriangle();

            cowardTriangleForm.set(
                place,
                date,
                oxygen,
                methane
             );
            cowardTriangleForm.ShowDialog();
        }

        private void btnEllicott_Click(object sender, EventArgs e)
        {
            
        }
    }
}
