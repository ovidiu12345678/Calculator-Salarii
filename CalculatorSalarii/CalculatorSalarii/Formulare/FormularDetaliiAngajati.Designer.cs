namespace CalculatorSalarii.Formulare
{
    partial class FormularDetaliiAngajati
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
            panel1 = new Panel();
            BtnSterge = new Button();
            BtnActualizeaza = new Button();
            BtnAdauga = new Button();
            BtnSalvare = new Button();
            dataGridView1 = new DataGridView();
            AngajatID = new DataGridViewTextBoxColumn();
            Cnp = new DataGridViewTextBoxColumn();
            Nume = new DataGridViewTextBoxColumn();
            Prenume = new DataGridViewTextBoxColumn();
            DataNasterii = new DataGridViewTextBoxColumn();
            Gen = new DataGridViewTextBoxColumn();
            Localitate = new DataGridViewTextBoxColumn();
            Judet = new DataGridViewTextBoxColumn();
            Adresa = new DataGridViewTextBoxColumn();
            CodPostal = new DataGridViewTextBoxColumn();
            Telefon = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            TextEmail = new TextBox();
            TextTelefon = new TextBox();
            TextCodPostal = new TextBox();
            TextAdresa = new TextBox();
            TextJudet = new TextBox();
            TextLocalitate = new TextBox();
            TextGen = new ComboBox();
            BtnDataNasterii = new DateTimePicker();
            TextPrenume = new TextBox();
            TextNume = new TextBox();
            TextCnp = new TextBox();
            TextAngajatID = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnStergePozaAdauga = new Button();
            BtnAdaugaPoza = new Button();
            pictureImage = new PictureBox();
            BtnExit = new Button();
            BtnTablouBord = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(BtnSterge);
            panel1.Controls.Add(BtnActualizeaza);
            panel1.Controls.Add(BtnAdauga);
            panel1.Controls.Add(BtnSalvare);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(TextEmail);
            panel1.Controls.Add(TextTelefon);
            panel1.Controls.Add(TextCodPostal);
            panel1.Controls.Add(TextAdresa);
            panel1.Controls.Add(TextJudet);
            panel1.Controls.Add(TextLocalitate);
            panel1.Controls.Add(TextGen);
            panel1.Controls.Add(BtnDataNasterii);
            panel1.Controls.Add(TextPrenume);
            panel1.Controls.Add(TextNume);
            panel1.Controls.Add(TextCnp);
            panel1.Controls.Add(TextAngajatID);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnStergePozaAdauga);
            panel1.Controls.Add(BtnAdaugaPoza);
            panel1.Controls.Add(pictureImage);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnTablouBord);
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(1487, 703);
            panel1.TabIndex = 0;
            // 
            // BtnSterge
            // 
            BtnSterge.FlatStyle = FlatStyle.Flat;
            BtnSterge.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSterge.ForeColor = Color.Red;
            BtnSterge.Location = new Point(1214, 449);
            BtnSterge.Name = "BtnSterge";
            BtnSterge.Size = new Size(102, 28);
            BtnSterge.TabIndex = 34;
            BtnSterge.Text = "Sterge";
            BtnSterge.UseVisualStyleBackColor = true;
            BtnSterge.Click += BtnSterge_Click;
            // 
            // BtnActualizeaza
            // 
            BtnActualizeaza.FlatStyle = FlatStyle.Flat;
            BtnActualizeaza.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnActualizeaza.ForeColor = Color.Gold;
            BtnActualizeaza.Location = new Point(1040, 449);
            BtnActualizeaza.Name = "BtnActualizeaza";
            BtnActualizeaza.Size = new Size(168, 28);
            BtnActualizeaza.TabIndex = 33;
            BtnActualizeaza.Text = "Actualizare";
            BtnActualizeaza.UseVisualStyleBackColor = true;
            BtnActualizeaza.Click += BtnActualizeaza_Click;
            // 
            // BtnAdauga
            // 
            BtnAdauga.FlatStyle = FlatStyle.Flat;
            BtnAdauga.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAdauga.ForeColor = Color.MediumBlue;
            BtnAdauga.Location = new Point(932, 449);
            BtnAdauga.Name = "BtnAdauga";
            BtnAdauga.Size = new Size(102, 28);
            BtnAdauga.TabIndex = 32;
            BtnAdauga.Text = "Adauga";
            BtnAdauga.UseVisualStyleBackColor = true;
            BtnAdauga.Click += BtnAdauga_Click;
            // 
            // BtnSalvare
            // 
            BtnSalvare.FlatStyle = FlatStyle.Flat;
            BtnSalvare.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSalvare.ForeColor = Color.Lime;
            BtnSalvare.Location = new Point(824, 449);
            BtnSalvare.Name = "BtnSalvare";
            BtnSalvare.Size = new Size(102, 28);
            BtnSalvare.TabIndex = 31;
            BtnSalvare.Text = "Salvare";
            BtnSalvare.UseVisualStyleBackColor = true;
            BtnSalvare.Click += BtnSalvare_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AngajatID, Cnp, Nume, Prenume, DataNasterii, Gen, Localitate, Judet, Adresa, CodPostal, Telefon, Email });
            dataGridView1.Location = new Point(31, 516);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1425, 172);
            dataGridView1.TabIndex = 30;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AngajatID
            // 
            AngajatID.HeaderText = "Angajat ID";
            AngajatID.MinimumWidth = 6;
            AngajatID.Name = "AngajatID";
            AngajatID.Width = 125;
            // 
            // Cnp
            // 
            Cnp.HeaderText = "Cnp";
            Cnp.MinimumWidth = 6;
            Cnp.Name = "Cnp";
            Cnp.Width = 125;
            // 
            // Nume
            // 
            Nume.HeaderText = "Nume";
            Nume.MinimumWidth = 6;
            Nume.Name = "Nume";
            Nume.Width = 125;
            // 
            // Prenume
            // 
            Prenume.HeaderText = "Prenume";
            Prenume.MinimumWidth = 6;
            Prenume.Name = "Prenume";
            Prenume.Width = 125;
            // 
            // DataNasterii
            // 
            DataNasterii.HeaderText = "Data Dasterii";
            DataNasterii.MinimumWidth = 6;
            DataNasterii.Name = "DataNasterii";
            DataNasterii.Width = 125;
            // 
            // Gen
            // 
            Gen.HeaderText = "Gen";
            Gen.MinimumWidth = 6;
            Gen.Name = "Gen";
            Gen.Width = 125;
            // 
            // Localitate
            // 
            Localitate.HeaderText = "Localitate";
            Localitate.MinimumWidth = 6;
            Localitate.Name = "Localitate";
            Localitate.Width = 125;
            // 
            // Judet
            // 
            Judet.HeaderText = "Judet";
            Judet.MinimumWidth = 6;
            Judet.Name = "Judet";
            Judet.Width = 125;
            // 
            // Adresa
            // 
            Adresa.HeaderText = "Adresa";
            Adresa.MinimumWidth = 6;
            Adresa.Name = "Adresa";
            Adresa.Width = 125;
            // 
            // CodPostal
            // 
            CodPostal.HeaderText = "Cod Postal";
            CodPostal.MinimumWidth = 6;
            CodPostal.Name = "CodPostal";
            CodPostal.Width = 125;
            // 
            // Telefon
            // 
            Telefon.HeaderText = "Telefon";
            Telefon.MinimumWidth = 6;
            Telefon.Name = "Telefon";
            Telefon.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // TextEmail
            // 
            TextEmail.Location = new Point(1065, 379);
            TextEmail.Name = "TextEmail";
            TextEmail.Size = new Size(251, 27);
            TextEmail.TabIndex = 29;
            TextEmail.TextChanged += TextEmail_TextChanged;
            // 
            // TextTelefon
            // 
            TextTelefon.Location = new Point(1065, 334);
            TextTelefon.Name = "TextTelefon";
            TextTelefon.Size = new Size(251, 27);
            TextTelefon.TabIndex = 28;
            TextTelefon.TextChanged += TextTelefon_TextChanged;
            // 
            // TextCodPostal
            // 
            TextCodPostal.Location = new Point(1065, 296);
            TextCodPostal.Name = "TextCodPostal";
            TextCodPostal.Size = new Size(251, 27);
            TextCodPostal.TabIndex = 27;
            TextCodPostal.TextChanged += TextCodPostal_TextChanged;
            // 
            // TextAdresa
            // 
            TextAdresa.Location = new Point(1065, 252);
            TextAdresa.Name = "TextAdresa";
            TextAdresa.Size = new Size(251, 27);
            TextAdresa.TabIndex = 26;
            TextAdresa.TextChanged += TextAdresa_TextChanged;
            // 
            // TextJudet
            // 
            TextJudet.Location = new Point(1065, 212);
            TextJudet.Name = "TextJudet";
            TextJudet.Size = new Size(251, 27);
            TextJudet.TabIndex = 25;
            TextJudet.TextChanged += TextJudet_TextChanged;
            // 
            // TextLocalitate
            // 
            TextLocalitate.Location = new Point(1065, 173);
            TextLocalitate.Name = "TextLocalitate";
            TextLocalitate.Size = new Size(251, 27);
            TextLocalitate.TabIndex = 24;
            TextLocalitate.TextChanged += TextLocalitate_TextChanged;
            // 
            // TextGen
            // 
            TextGen.FormattingEnabled = true;
            TextGen.Items.AddRange(new object[] { "Feminin", "Masculin", "Altele" });
            TextGen.Location = new Point(454, 369);
            TextGen.Name = "TextGen";
            TextGen.Size = new Size(251, 28);
            TextGen.TabIndex = 23;
            TextGen.SelectedIndexChanged += TextGen_SelectedIndexChanged;
            // 
            // BtnDataNasterii
            // 
            BtnDataNasterii.CustomFormat = "dd/MM/yyy";
            BtnDataNasterii.Format = DateTimePickerFormat.Custom;
            BtnDataNasterii.Location = new Point(454, 330);
            BtnDataNasterii.Name = "BtnDataNasterii";
            BtnDataNasterii.Size = new Size(251, 27);
            BtnDataNasterii.TabIndex = 22;
            BtnDataNasterii.ValueChanged += BtnDataNasterii_ValueChanged;
            // 
            // TextPrenume
            // 
            TextPrenume.Location = new Point(454, 293);
            TextPrenume.Name = "TextPrenume";
            TextPrenume.Size = new Size(251, 27);
            TextPrenume.TabIndex = 21;
            TextPrenume.TextChanged += TextPrenume_TextChanged;
            // 
            // TextNume
            // 
            TextNume.Location = new Point(454, 256);
            TextNume.Name = "TextNume";
            TextNume.Size = new Size(251, 27);
            TextNume.TabIndex = 20;
            TextNume.TextChanged += TextNume_TextChanged;
            // 
            // TextCnp
            // 
            TextCnp.Location = new Point(454, 216);
            TextCnp.Name = "TextCnp";
            TextCnp.Size = new Size(251, 27);
            TextCnp.TabIndex = 19;
            TextCnp.TextChanged += TextCnp_TextChanged;
            // 
            // TextAngajatID
            // 
            TextAngajatID.Location = new Point(454, 177);
            TextAngajatID.Name = "TextAngajatID";
            TextAngajatID.Size = new Size(251, 27);
            TextAngajatID.TabIndex = 18;
            TextAngajatID.TextChanged += TextAngajatID_TextChanged;
            // 
            // label13
            // 
            label13.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(646, 30);
            label13.Name = "label13";
            label13.Size = new Size(347, 47);
            label13.TabIndex = 17;
            label13.Text = "Detalii Angajati";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(938, 382);
            label12.Name = "label12";
            label12.Size = new Size(65, 22);
            label12.TabIndex = 16;
            label12.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(938, 339);
            label11.Name = "label11";
            label11.Size = new Size(85, 22);
            label11.TabIndex = 15;
            label11.Text = "Telefon";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(938, 217);
            label10.Name = "label10";
            label10.Size = new Size(66, 22);
            label10.TabIndex = 14;
            label10.Text = "Judet";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(938, 301);
            label9.Name = "label9";
            label9.Size = new Size(116, 22);
            label9.TabIndex = 13;
            label9.Text = "Cod Postal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(938, 178);
            label8.Name = "label8";
            label8.Size = new Size(108, 22);
            label8.TabIndex = 12;
            label8.Text = "Localitate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(938, 257);
            label7.Name = "label7";
            label7.Size = new Size(81, 22);
            label7.TabIndex = 11;
            label7.Text = "Adresa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(288, 375);
            label6.Name = "label6";
            label6.Size = new Size(50, 22);
            label6.TabIndex = 10;
            label6.Text = "Gen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(288, 335);
            label5.Name = "label5";
            label5.Size = new Size(142, 22);
            label5.TabIndex = 9;
            label5.Text = "Data Nasterii";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(288, 292);
            label4.Name = "label4";
            label4.Size = new Size(101, 22);
            label4.TabIndex = 8;
            label4.Text = "Prenume";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(288, 255);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 7;
            label3.Text = "Nume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(288, 211);
            label2.Name = "label2";
            label2.Size = new Size(49, 22);
            label2.TabIndex = 6;
            label2.Text = "Cnp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(288, 168);
            label1.Name = "label1";
            label1.Size = new Size(120, 22);
            label1.TabIndex = 5;
            label1.Text = "Angajat ID";
            // 
            // BtnStergePozaAdauga
            // 
            BtnStergePozaAdauga.FlatStyle = FlatStyle.Flat;
            BtnStergePozaAdauga.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnStergePozaAdauga.ForeColor = Color.Crimson;
            BtnStergePozaAdauga.Location = new Point(160, 210);
            BtnStergePozaAdauga.Name = "BtnStergePozaAdauga";
            BtnStergePozaAdauga.Size = new Size(94, 36);
            BtnStergePozaAdauga.TabIndex = 4;
            BtnStergePozaAdauga.Text = "Sterge";
            BtnStergePozaAdauga.UseVisualStyleBackColor = true;
            BtnStergePozaAdauga.Click += BtnStergePozaAdauga_Click;
            // 
            // BtnAdaugaPoza
            // 
            BtnAdaugaPoza.FlatStyle = FlatStyle.Flat;
            BtnAdaugaPoza.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAdaugaPoza.ForeColor = Color.Chartreuse;
            BtnAdaugaPoza.Location = new Point(30, 210);
            BtnAdaugaPoza.Name = "BtnAdaugaPoza";
            BtnAdaugaPoza.Size = new Size(94, 36);
            BtnAdaugaPoza.TabIndex = 3;
            BtnAdaugaPoza.Text = "Poza";
            BtnAdaugaPoza.UseVisualStyleBackColor = true;
            BtnAdaugaPoza.Click += BtnAdaugaPoza_Click;
            // 
            // pictureImage
            // 
            pictureImage.BackColor = Color.FromArgb(128, 128, 255);
            pictureImage.Location = new Point(30, 30);
            pictureImage.Name = "pictureImage";
            pictureImage.Size = new Size(224, 174);
            pictureImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureImage.TabIndex = 2;
            pictureImage.TabStop = false;
            // 
            // BtnExit
            // 
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExit.ForeColor = Color.Red;
            BtnExit.Location = new Point(1319, 36);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(136, 41);
            BtnExit.TabIndex = 1;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnTablouBord
            // 
            BtnTablouBord.FlatStyle = FlatStyle.Flat;
            BtnTablouBord.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTablouBord.ForeColor = Color.Lime;
            BtnTablouBord.Location = new Point(1061, 36);
            BtnTablouBord.Name = "BtnTablouBord";
            BtnTablouBord.Size = new Size(218, 41);
            BtnTablouBord.TabIndex = 0;
            BtnTablouBord.Text = "Tablou De Bord";
            BtnTablouBord.UseVisualStyleBackColor = true;
            BtnTablouBord.Click += BtnTablouBord_Click;
            // 
            // FormularDetaliiAngajati
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1487, 762);
            Controls.Add(panel1);
            Name = "FormularDetaliiAngajati";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalii Angajati";
            Load += DetaliiAngajati_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnExit;
        private Button BtnTablouBord;
        private Button BtnStergePozaAdauga;
        private Button BtnAdaugaPoza;
        private PictureBox pictureImage;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label13;
        private ComboBox TextGen;
        private DateTimePicker BtnDataNasterii;
        private TextBox TextPrenume;
        private TextBox TextNume;
        private TextBox TextCnp;
        private TextBox TextAngajatID;
        private TextBox TextEmail;
        private TextBox TextTelefon;
        private TextBox TextCodPostal;
        private TextBox TextAdresa;
        private TextBox TextJudet;
        private TextBox TextLocalitate;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn AngajatID;
        private DataGridViewTextBoxColumn Cnp;
        private DataGridViewTextBoxColumn Nume;
        private DataGridViewTextBoxColumn Prenume;
        private DataGridViewTextBoxColumn DataNasterii;
        private DataGridViewTextBoxColumn Gen;
        private DataGridViewTextBoxColumn Localitate;
        private DataGridViewTextBoxColumn Judet;
        private DataGridViewTextBoxColumn Adresa;
        private DataGridViewTextBoxColumn CodPostal;
        private DataGridViewTextBoxColumn Telefon;
        private DataGridViewTextBoxColumn Email;
        private Button BtnSterge;
        private Button BtnActualizeaza;
        private Button BtnAdauga;
        private Button BtnSalvare;
    }
}