namespace Gas_Analysis
{
    partial class GasAnalysis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GasAnalysis));
            logo = new PictureBox();
            lblPlace = new Label();
            txtboxPlace = new TextBox();
            lblDate = new Label();
            ISMlogo = new PictureBox();
            lbloxygen = new Label();
            txtboxOxygen = new TextBox();
            lblco2 = new Label();
            txtboxCO2 = new TextBox();
            lblch4 = new Label();
            txtboxch4 = new TextBox();
            lblh2 = new Label();
            txtboxh2 = new TextBox();
            lblco = new Label();
            txtboxco = new TextBox();
            lblHydrocarbons = new Label();
            txtboxHydrocarbons = new TextBox();
            lblH2S = new Label();
            textBoxH2S = new TextBox();
            lblEthylene = new Label();
            textBoxEthylene = new TextBox();
            lblN2 = new Label();
            textBoxN2 = new TextBox();
            btnEllicott = new Button();
            btnAnalyse = new Button();
            btnCoward = new Button();
            dateTimePicker = new DateTimePicker();
            btnHelp = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ISMlogo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(473, 22);
            logo.Name = "logo";
            logo.Size = new Size(1033, 111);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // lblPlace
            // 
            lblPlace.AutoSize = true;
            lblPlace.BackColor = Color.Transparent;
            lblPlace.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblPlace.Location = new Point(567, 175);
            lblPlace.Name = "lblPlace";
            lblPlace.Size = new Size(199, 35);
            lblPlace.TabIndex = 1;
            lblPlace.Text = "Mine Location";
            lblPlace.Click += label1_Click;
            // 
            // txtboxPlace
            // 
            txtboxPlace.Font = new Font("Times New Roman", 18F);
            txtboxPlace.Location = new Point(837, 168);
            txtboxPlace.Name = "txtboxPlace";
            txtboxPlace.Size = new Size(447, 42);
            txtboxPlace.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblDate.Location = new Point(685, 220);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(74, 35);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date";
            lblDate.Click += label1_Click_1;
            // 
            // ISMlogo
            // 
            ISMlogo.BackColor = Color.Transparent;
            ISMlogo.Image = (Image)resources.GetObject("ISMlogo.Image");
            ISMlogo.Location = new Point(38, 12);
            ISMlogo.Name = "ISMlogo";
            ISMlogo.Size = new Size(214, 211);
            ISMlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ISMlogo.TabIndex = 5;
            ISMlogo.TabStop = false;
            ISMlogo.Click += ISMlogo_Click;
            // 
            // lbloxygen
            // 
            lbloxygen.AutoSize = true;
            lbloxygen.BackColor = Color.Transparent;
            lbloxygen.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lbloxygen.Location = new Point(626, 276);
            lbloxygen.Name = "lbloxygen";
            lbloxygen.Size = new Size(159, 35);
            lbloxygen.TabIndex = 6;
            lbloxygen.Text = "Oxygen % ";
            // 
            // txtboxOxygen
            // 
            txtboxOxygen.Font = new Font("Times New Roman", 18F);
            txtboxOxygen.Location = new Point(837, 276);
            txtboxOxygen.Name = "txtboxOxygen";
            txtboxOxygen.Size = new Size(447, 42);
            txtboxOxygen.TabIndex = 7;
            // 
            // lblco2
            // 
            lblco2.AutoSize = true;
            lblco2.BackColor = Color.Transparent;
            lblco2.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblco2.Location = new Point(520, 331);
            lblco2.Name = "lblco2";
            lblco2.Size = new Size(265, 35);
            lblco2.TabIndex = 8;
            lblco2.Text = " Carbon Dioxide% ";
            // 
            // txtboxCO2
            // 
            txtboxCO2.Font = new Font("Times New Roman", 18F);
            txtboxCO2.Location = new Point(837, 331);
            txtboxCO2.Name = "txtboxCO2";
            txtboxCO2.Size = new Size(447, 42);
            txtboxCO2.TabIndex = 9;
            // 
            // lblch4
            // 
            lblch4.AutoSize = true;
            lblch4.BackColor = Color.Transparent;
            lblch4.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblch4.Location = new Point(619, 386);
            lblch4.Name = "lblch4";
            lblch4.Size = new Size(166, 35);
            lblch4.TabIndex = 10;
            lblch4.Text = "Methane% ";
            // 
            // txtboxch4
            // 
            txtboxch4.Font = new Font("Times New Roman", 18F);
            txtboxch4.Location = new Point(837, 379);
            txtboxch4.Name = "txtboxch4";
            txtboxch4.Size = new Size(447, 42);
            txtboxch4.TabIndex = 11;
            // 
            // lblh2
            // 
            lblh2.AutoSize = true;
            lblh2.BackColor = Color.Transparent;
            lblh2.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblh2.Location = new Point(600, 445);
            lblh2.Name = "lblh2";
            lblh2.Size = new Size(172, 35);
            lblh2.TabIndex = 12;
            lblh2.Text = "Hydrogen%";
            // 
            // txtboxh2
            // 
            txtboxh2.Font = new Font("Times New Roman", 18F);
            txtboxh2.Location = new Point(839, 438);
            txtboxh2.Name = "txtboxh2";
            txtboxh2.Size = new Size(445, 42);
            txtboxh2.TabIndex = 13;
            // 
            // lblco
            // 
            lblco.AutoSize = true;
            lblco.BackColor = Color.Transparent;
            lblco.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblco.Location = new Point(499, 502);
            lblco.Name = "lblco";
            lblco.Size = new Size(286, 35);
            lblco.TabIndex = 14;
            lblco.Text = "Carbon Monoxide% ";
            // 
            // txtboxco
            // 
            txtboxco.Font = new Font("Times New Roman", 18F);
            txtboxco.Location = new Point(837, 495);
            txtboxco.Name = "txtboxco";
            txtboxco.Size = new Size(447, 42);
            txtboxco.TabIndex = 15;
            // 
            // lblHydrocarbons
            // 
            lblHydrocarbons.AutoSize = true;
            lblHydrocarbons.BackColor = Color.Transparent;
            lblHydrocarbons.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblHydrocarbons.Location = new Point(486, 561);
            lblHydrocarbons.Name = "lblHydrocarbons";
            lblHydrocarbons.Size = new Size(280, 35);
            lblHydrocarbons.TabIndex = 16;
            lblHydrocarbons.Text = "Hydrocarbons (ppm)";
            lblHydrocarbons.Click += label1_Click_2;
            // 
            // txtboxHydrocarbons
            // 
            txtboxHydrocarbons.Font = new Font("Times New Roman", 18F);
            txtboxHydrocarbons.Location = new Point(836, 554);
            txtboxHydrocarbons.Name = "txtboxHydrocarbons";
            txtboxHydrocarbons.Size = new Size(448, 42);
            txtboxHydrocarbons.TabIndex = 17;
            // 
            // lblH2S
            // 
            lblH2S.AutoSize = true;
            lblH2S.BackColor = Color.Transparent;
            lblH2S.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblH2S.Location = new Point(485, 618);
            lblH2S.Name = "lblH2S";
            lblH2S.Size = new Size(300, 35);
            lblH2S.TabIndex = 18;
            lblH2S.Text = "Hydrogen Sulphide% ";
            // 
            // textBoxH2S
            // 
            textBoxH2S.Font = new Font("Times New Roman", 18F);
            textBoxH2S.Location = new Point(836, 611);
            textBoxH2S.Name = "textBoxH2S";
            textBoxH2S.Size = new Size(448, 42);
            textBoxH2S.TabIndex = 19;
            // 
            // lblEthylene
            // 
            lblEthylene.AutoSize = true;
            lblEthylene.BackColor = Color.Transparent;
            lblEthylene.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblEthylene.Location = new Point(574, 670);
            lblEthylene.Name = "lblEthylene";
            lblEthylene.Size = new Size(211, 35);
            lblEthylene.TabIndex = 20;
            lblEthylene.Text = "Ethylene(ppm) ";
            // 
            // textBoxEthylene
            // 
            textBoxEthylene.Font = new Font("Times New Roman", 18F);
            textBoxEthylene.Location = new Point(836, 663);
            textBoxEthylene.Name = "textBoxEthylene";
            textBoxEthylene.Size = new Size(448, 42);
            textBoxEthylene.TabIndex = 21;
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.BackColor = Color.Transparent;
            lblN2.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblN2.Location = new Point(619, 720);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(166, 35);
            lblN2.TabIndex = 22;
            lblN2.Text = "Nitrogen% ";
            // 
            // textBoxN2
            // 
            textBoxN2.Font = new Font("Times New Roman", 18F);
            textBoxN2.Location = new Point(836, 713);
            textBoxN2.Name = "textBoxN2";
            textBoxN2.Size = new Size(448, 42);
            textBoxN2.TabIndex = 23;
            // 
            // btnEllicott
            // 
            btnEllicott.BackColor = Color.FromArgb(192, 255, 192);
            btnEllicott.FlatStyle = FlatStyle.Popup;
            btnEllicott.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnEllicott.Location = new Point(1126, 809);
            btnEllicott.Name = "btnEllicott";
            btnEllicott.Size = new Size(205, 97);
            btnEllicott.TabIndex = 24;
            btnEllicott.Text = "Ellicott's Extension";
            btnEllicott.UseVisualStyleBackColor = false;
            btnEllicott.Click += btnEllicott_Click;
            // 
            // btnAnalyse
            // 
            btnAnalyse.BackColor = Color.FromArgb(255, 255, 192);
            btnAnalyse.FlatStyle = FlatStyle.Popup;
            btnAnalyse.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnAnalyse.Location = new Point(626, 809);
            btnAnalyse.Name = "btnAnalyse";
            btnAnalyse.Size = new Size(205, 97);
            btnAnalyse.TabIndex = 25;
            btnAnalyse.Text = "Analyze";
            btnAnalyse.UseVisualStyleBackColor = false;
            btnAnalyse.Click += btnAnalyse_Click;
            // 
            // btnCoward
            // 
            btnCoward.BackColor = Color.FromArgb(255, 192, 192);
            btnCoward.FlatStyle = FlatStyle.Popup;
            btnCoward.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnCoward.Location = new Point(876, 806);
            btnCoward.Name = "btnCoward";
            btnCoward.Size = new Size(205, 100);
            btnCoward.TabIndex = 26;
            btnCoward.Text = "Coward's Triangle";
            btnCoward.UseVisualStyleBackColor = false;
            btnCoward.Click += btnCoward_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd-mm-yyyy";
            dateTimePicker.Font = new Font("Times New Roman", 18F);
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(836, 215);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(448, 42);
            dateTimePicker.TabIndex = 29;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.FromArgb(192, 255, 255);
            btnHelp.FlatStyle = FlatStyle.Popup;
            btnHelp.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnHelp.Location = new Point(737, 927);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(205, 68);
            btnHelp.TabIndex = 30;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 192, 255);
            btnSave.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnSave.Location = new Point(1015, 927);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(205, 68);
            btnSave.TabIndex = 31;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // GasAnalysis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1799, 1055);
            Controls.Add(btnSave);
            Controls.Add(btnHelp);
            Controls.Add(dateTimePicker);
            Controls.Add(btnCoward);
            Controls.Add(btnAnalyse);
            Controls.Add(btnEllicott);
            Controls.Add(textBoxN2);
            Controls.Add(lblN2);
            Controls.Add(textBoxEthylene);
            Controls.Add(lblEthylene);
            Controls.Add(textBoxH2S);
            Controls.Add(lblH2S);
            Controls.Add(txtboxHydrocarbons);
            Controls.Add(lblHydrocarbons);
            Controls.Add(txtboxco);
            Controls.Add(lblco);
            Controls.Add(txtboxh2);
            Controls.Add(lblh2);
            Controls.Add(txtboxch4);
            Controls.Add(lblch4);
            Controls.Add(txtboxCO2);
            Controls.Add(lblco2);
            Controls.Add(txtboxOxygen);
            Controls.Add(lbloxygen);
            Controls.Add(ISMlogo);
            Controls.Add(lblDate);
            Controls.Add(txtboxPlace);
            Controls.Add(lblPlace);
            Controls.Add(logo);
            Name = "GasAnalysis";
            Text = "Gas Analysis";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ISMlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label lblPlace;
        private TextBox txtboxPlace;
        private Label lblDate;
        private PictureBox ISMlogo;
        private Label lbloxygen;
        private TextBox txtboxOxygen;
        private Label lblco2;
        private TextBox txtboxCO2;
        private Label lblch4;
        private TextBox txtboxch4;
        private Label lblh2;
        private TextBox txtboxh2;
        private Label lblco;
        private TextBox txtboxco;
        private Label lblHydrocarbons;
        private TextBox txtboxHydrocarbons;
        private Label lblH2S;
        private TextBox textBoxH2S;
        private Label lblEthylene;
        private TextBox textBoxEthylene;
        private Label lblN2;
        private TextBox textBoxN2;
        private Button btnEllicott;
        private Button btnAnalyse;
        private Button btnCoward;
        private DateTimePicker dateTimePicker;
        private Button btnHelp;
        private Button btnSave;
    }
}
