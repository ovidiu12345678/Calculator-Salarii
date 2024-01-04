namespace CalculatorSalarii
{
    partial class FormularCalculatorSalarii
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
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            BtnAngajati = new Panel();
            BtnClient = new Button();
            BtnAdmin = new Button();
            BtnRapoarte = new Button();
            BtnAngajat = new Button();
            BtnSalarii = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            BtnDespre = new Button();
            BtnLogOut = new Button();
            BtnAngajati.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = null;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Location = new Point(0, 64);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(1541, 34);
            materialTabSelector1.TabIndex = 0;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // BtnAngajati
            // 
            BtnAngajati.BackColor = Color.FromArgb(41, 128, 185);
            BtnAngajati.Controls.Add(BtnSalarii);
            BtnAngajati.Controls.Add(BtnClient);
            BtnAngajati.Controls.Add(BtnAdmin);
            BtnAngajati.Controls.Add(BtnRapoarte);
            BtnAngajati.Controls.Add(BtnAngajat);
            BtnAngajati.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAngajati.Location = new Point(0, 98);
            BtnAngajati.Name = "BtnAngajati";
            BtnAngajati.Size = new Size(248, 895);
            BtnAngajati.TabIndex = 1;
            // 
            // BtnClient
            // 
            BtnClient.FlatStyle = FlatStyle.Flat;
            BtnClient.ForeColor = Color.White;
            BtnClient.Image = Properties.Resources._3709754_assistance_business_client_service_support_icon;
            BtnClient.Location = new Point(12, 602);
            BtnClient.Name = "BtnClient";
            BtnClient.Size = new Size(220, 95);
            BtnClient.TabIndex = 4;
            BtnClient.Text = "Client";
            BtnClient.TextAlign = ContentAlignment.BottomCenter;
            BtnClient.UseVisualStyleBackColor = true;
            BtnClient.Click += BtnClient_Click;
            // 
            // BtnAdmin
            // 
            BtnAdmin.FlatStyle = FlatStyle.Flat;
            BtnAdmin.ForeColor = Color.White;
            BtnAdmin.Image = Properties.Resources._5764259_admin_brand_google_logo_product_icon;
            BtnAdmin.Location = new Point(12, 491);
            BtnAdmin.Name = "BtnAdmin";
            BtnAdmin.Size = new Size(220, 95);
            BtnAdmin.TabIndex = 3;
            BtnAdmin.Text = "Admin";
            BtnAdmin.TextAlign = ContentAlignment.BottomCenter;
            BtnAdmin.UseVisualStyleBackColor = true;
            BtnAdmin.Click += BtnAdmin_Click;
            // 
            // BtnRapoarte
            // 
            BtnRapoarte.FlatStyle = FlatStyle.Flat;
            BtnRapoarte.ForeColor = Color.White;
            BtnRapoarte.Image = Properties.Resources._8960612_reports_heartbeat_report_heartbeat_report_clipboard_icon;
            BtnRapoarte.Location = new Point(12, 241);
            BtnRapoarte.Name = "BtnRapoarte";
            BtnRapoarte.Size = new Size(220, 95);
            BtnRapoarte.TabIndex = 2;
            BtnRapoarte.Text = "Rapoarte";
            BtnRapoarte.TextAlign = ContentAlignment.BottomCenter;
            BtnRapoarte.UseVisualStyleBackColor = true;
            BtnRapoarte.Click += BtnRapoarte_Click;
            // 
            // BtnAngajat
            // 
            BtnAngajat.FlatStyle = FlatStyle.Flat;
            BtnAngajat.ForeColor = Color.White;
            BtnAngajat.Image = Properties.Resources._2530816_align_employee_general_human_human_list_icon__1_;
            BtnAngajat.Location = new Point(12, 19);
            BtnAngajat.Name = "BtnAngajat";
            BtnAngajat.Size = new Size(220, 95);
            BtnAngajat.TabIndex = 0;
            BtnAngajat.Text = "Angajati";
            BtnAngajat.TextAlign = ContentAlignment.BottomCenter;
            BtnAngajat.UseVisualStyleBackColor = true;
            BtnAngajat.Click += BtnAngajat_Click;
            // 
            // BtnSalarii
            // 
            BtnSalarii.FlatStyle = FlatStyle.Flat;
            BtnSalarii.ForeColor = Color.White;
            BtnSalarii.Image = Properties.Resources._5027823_calculator_coin_dollar_money_icon;
            BtnSalarii.Location = new Point(12, 130);
            BtnSalarii.Name = "BtnSalarii";
            BtnSalarii.Size = new Size(220, 95);
            BtnSalarii.TabIndex = 5;
            BtnSalarii.Text = "Salarii";
            BtnSalarii.TextAlign = ContentAlignment.BottomCenter;
            BtnSalarii.UseVisualStyleBackColor = true;
            BtnSalarii.Click += BtnSalarii_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(248, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(1254, 711);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.meeting_g31c436da3_19201;
            pictureBox1.Location = new Point(-2, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1256, 615);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(41, 128, 185);
            panel2.Controls.Add(BtnLogOut);
            panel2.Controls.Add(BtnDespre);
            panel2.Location = new Point(-2, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1256, 97);
            panel2.TabIndex = 1;
            // 
            // BtnDespre
            // 
            BtnDespre.FlatStyle = FlatStyle.Flat;
            BtnDespre.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDespre.ForeColor = Color.White;
            BtnDespre.Image = Properties.Resources._4011296_about_help_smart_smart_watch_watch_icon;
            BtnDespre.Location = new Point(789, 7);
            BtnDespre.Name = "BtnDespre";
            BtnDespre.Size = new Size(220, 82);
            BtnDespre.TabIndex = 0;
            BtnDespre.Text = "Despre";
            BtnDespre.TextAlign = ContentAlignment.BottomCenter;
            BtnDespre.UseVisualStyleBackColor = true;
            BtnDespre.Click += BtnDespre_Click;
            // 
            // BtnLogOut
            // 
            BtnLogOut.FlatStyle = FlatStyle.Flat;
            BtnLogOut.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogOut.ForeColor = Color.White;
            BtnLogOut.Image = Properties.Resources._5172972_arrow_entrance_exit_internet_log_icon;
            BtnLogOut.Location = new Point(1023, 8);
            BtnLogOut.Name = "BtnLogOut";
            BtnLogOut.Size = new Size(220, 82);
            BtnLogOut.TabIndex = 1;
            BtnLogOut.Text = "Log Out";
            BtnLogOut.TextAlign = ContentAlignment.BottomCenter;
            BtnLogOut.UseVisualStyleBackColor = true;
            BtnLogOut.Click += BtnLogOut_Click;
            // 
            // FormularCalculatorSalarii
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1501, 808);
            Controls.Add(panel1);
            Controls.Add(BtnAngajati);
            Controls.Add(materialTabSelector1);
            MinimizeBox = false;
            Name = "FormularCalculatorSalarii";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator Salarii";
            BtnAngajati.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private Panel BtnAngajati;
        private Button BtnClient;
        private Button BtnAdmin;
        private Button BtnRapoarte;
        private Button BtnAngajat;
        private Button BtnSalarii;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button BtnLogOut;
        private Button BtnDespre;
    }
}