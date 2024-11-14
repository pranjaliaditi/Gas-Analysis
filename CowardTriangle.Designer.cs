namespace Gas_Analysis
{
    partial class CowardTriangle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CowardTriangle));
            FastReport.DataVisualization.Charting.ChartArea chartArea1 = new FastReport.DataVisualization.Charting.ChartArea();
            pictureBox1 = new PictureBox();
            lblPlace = new Label();
            txtboxPlace = new TextBox();
            lblDate = new Label();
            txtboxDate = new TextBox();
            lblHeading = new Label();
            chkMethaneOnly = new CheckBox();
            btnSave = new Button();
            chtCowardsTriangle = new FastReport.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtCowardsTriangle).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblPlace
            // 
            lblPlace.AutoSize = true;
            lblPlace.BackColor = Color.Transparent;
            lblPlace.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblPlace.Location = new Point(368, 185);
            lblPlace.Name = "lblPlace";
            lblPlace.Size = new Size(199, 35);
            lblPlace.TabIndex = 2;
            lblPlace.Text = "Mine Location";
            // 
            // txtboxPlace
            // 
            txtboxPlace.Font = new Font("Times New Roman", 18F);
            txtboxPlace.Location = new Point(583, 178);
            txtboxPlace.Name = "txtboxPlace";
            txtboxPlace.ReadOnly = true;
            txtboxPlace.Size = new Size(447, 42);
            txtboxPlace.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblDate.Location = new Point(493, 242);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(74, 35);
            lblDate.TabIndex = 26;
            lblDate.Text = "Date";
            // 
            // txtboxDate
            // 
            txtboxDate.Font = new Font("Times New Roman", 18F);
            txtboxDate.Location = new Point(583, 242);
            txtboxDate.Name = "txtboxDate";
            txtboxDate.ReadOnly = true;
            txtboxDate.Size = new Size(447, 42);
            txtboxDate.TabIndex = 27;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Times New Roman", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.Blue;
            lblHeading.Location = new Point(270, 13);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(1011, 135);
            lblHeading.TabIndex = 28;
            lblHeading.Text = "Coward's Triangle";
            // 
            // chkMethaneOnly
            // 
            chkMethaneOnly.AutoSize = true;
            chkMethaneOnly.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkMethaneOnly.Location = new Point(533, 358);
            chkMethaneOnly.Name = "chkMethaneOnly";
            chkMethaneOnly.Size = new Size(595, 39);
            chkMethaneOnly.TabIndex = 29;
            chkMethaneOnly.Text = "Plot using Methane as the only explosive gas";
            chkMethaneOnly.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnSave.Location = new Point(1523, 883);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(205, 68);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // chtCowardsTriangle
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Combustibles (%)";
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 25D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Oxygen (%)";
            chartArea1.Name = "ChartArea1";
            chtCowardsTriangle.ChartAreas.Add(chartArea1);
            chtCowardsTriangle.Location = new Point(52, 345);
            chtCowardsTriangle.Name = "chtCowardsTriangle";
            chtCowardsTriangle.Size = new Size(1719, 630);
            chtCowardsTriangle.TabIndex = 35;
            chtCowardsTriangle.Text = "Coward's Triangle";
            // 
            // CowardTriangle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1022);
            Controls.Add(btnSave);
            Controls.Add(chkMethaneOnly);
            Controls.Add(lblHeading);
            Controls.Add(txtboxDate);
            Controls.Add(lblDate);
            Controls.Add(txtboxPlace);
            Controls.Add(lblPlace);
            Controls.Add(pictureBox1);
            Controls.Add(chtCowardsTriangle);
            Name = "CowardTriangle";
            Text = "CowardTriangle";
            Load += CowardTriangle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chtCowardsTriangle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private PictureBox pictureBox1;
        private Label lblPlace;
        private TextBox txtboxPlace;
        private Label lblDate;
        private TextBox txtboxDate;
        private Label lblHeading;
        private CheckBox chkMethaneOnly;
        private Button btnSave;
        private FastReport.DataVisualization.Charting.Chart chtCowardsTriangle;
    }
}