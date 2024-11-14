using System;
using System.Drawing;
using System.Windows.Forms;
// Use FastReport.DataVisualization namespace instead of System.Windows.Forms.DataVisualization.Charting
using FastReport.DataVisualization.Charting;

namespace Gas_Analysis
{
    public partial class CowardTriangle : Form
    {
        private Chart chartCowardTriangle;  // Declare the chart as a class-level field

        public CowardTriangle()
        {
            InitializeComponent();
            InitializeChart();  // Call InitializeChart from the constructor
        }

        private void InitializeChart()
        {
            chtCowardsTriangle.Dock = DockStyle.None;

            // Create and configure a ChartArea
            ChartArea chartArea = new ChartArea("MainArea")
            {
                AxisX = { Title = "Methane (%)", Minimum = 0, Maximum = 20, Interval = 2 },
                AxisY = { Title = "Oxygen (%)", Minimum = 0, Maximum = 22, Interval = 2 }
            };

            chtCowardsTriangle.ChartAreas.Clear(); // Clear any default ChartArea added by the Designer
            chtCowardsTriangle.ChartAreas.Add(chartArea);

            // Add a Legend to the chart
            Legend legend = new Legend("Zone Legend")
            {
                Docking = Docking.Right,
                Alignment = StringAlignment.Center,
                LegendStyle = LegendStyle.Table
            };
            chtCowardsTriangle.Legends.Clear(); // Clear any existing legends
            chtCowardsTriangle.Legends.Add(legend); // Add the configured legend

            // Call DrawZones to add the zones to the chart
            DrawZones();
        }

        private void DrawZones()
        {
            // Red Zone: Explosive Zone
            AddPolygonSeries(
                new double[] { 5.4, 15, 6 }, // Methane % (X-axis)
                new double[] { 20, 18, 12 }, // Oxygen % (Y-axis)
                Color.Red,
                "Explosive Zone"
            );

            // Light Green Zone: May Become Explosive When Diluted by Air
            AddPolygonSeries(
                new double[] { 0, 5.4, 6 }, // Methane % (X-axis)
                new double[] { 21, 20, 12 }, // Oxygen % (Y-axis)
                Color.LightGreen,
                "May Become Explosive When Diluted"
            );

            // Yellow Zone: Potentially Explosive Zone
            AddPolygonSeries(
                new double[] { 6, 15, 20, 20, 14 }, // Methane % (X-axis)
                new double[] { 12, 18, 17, 0, 0 }, // Oxygen % (Y-axis)
                Color.Yellow,
                "Potentially Explosive Zone"
            );

            // Dark Green Zone: Cannot Become Explosive
            AddPolygonSeries(
                new double[] { 0, 0, 14 }, // Methane % (X-axis)
                new double[] { 0, 21, 0 }, // Oxygen % (Y-axis)
                Color.DarkGreen,
                "Cannot Become Explosive"
            );
        }

        private void AddPolygonSeries(double[] xPoints, double[] yPoints, Color color, string label)
        {
            var series = new Series
            {
                ChartType = SeriesChartType.Area,  // Set the type to Area for filled polygons
                Color = color,
                BorderWidth = 0,
                IsVisibleInLegend = true, // Show in legend
                LegendText = label         // Set the legend text to describe the zone
            };

            for (int i = 0; i < xPoints.Length; i++)
            {
                series.Points.AddXY(xPoints[i], yPoints[i]);
            }

            chtCowardsTriangle.Series.Add(series);  // Add the series to the chart
        }

        public void set(string place, DateTime date, double oxygen, double methane)
        {
            txtboxPlace.Text = place;
            txtboxDate.Text = date.ToString();

            // plot the point
            var pointSeries = new Series
            {
                ChartType = SeriesChartType.Point, // Type to show a single point
                Color = Color.Black,                // Set color of the point (customize as needed)
                MarkerSize = 10,                    // Size of the marker for visibility
                MarkerStyle = MarkerStyle.Circle,   // Marker style, e.g., circle
                IsVisibleInLegend = false           // No need to show this point in the legend
            };

            // Add the point with Methane concentration (X) and Oxygen concentration (Y)
            pointSeries.Points.AddXY(methane, oxygen);

            // Add the point series to the chart
            chtCowardsTriangle.Series.Add(pointSeries);
        }


        private void CowardTriangle_Load(object sender, EventArgs e)
        {
            // Optional: Any additional code you want to execute when the form loads
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Specify the file path and name for saving
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Save Chart as Image";
                saveFileDialog.FileName = "CowardTriangle.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Capture the form as an image
                    using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                        bitmap.Save(saveFileDialog.FileName); // Save the bitmap to the chosen path
                    }

                    MessageBox.Show("Chart saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
