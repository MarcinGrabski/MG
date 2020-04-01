namespace Poltrone_Electronics
{
    partial class Zlecenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zlecenie));
            this.lblTypUrzadzenia = new System.Windows.Forms.Label();
            this.cbTypUrzadzenia = new System.Windows.Forms.ComboBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblNrSeryjny = new System.Windows.Forms.Label();
            this.tbNrSeryjny = new System.Windows.Forms.TextBox();
            this.tbImei = new System.Windows.Forms.TextBox();
            this.lblImei = new System.Windows.Forms.Label();
            this.tbProcesor = new System.Windows.Forms.TextBox();
            this.lblProcesor = new System.Windows.Forms.Label();
            this.cbPamiec = new System.Windows.Forms.ComboBox();
            this.lblPamiec = new System.Windows.Forms.Label();
            this.tbPlytaGlowna = new System.Windows.Forms.TextBox();
            this.lblPlytaGlowna = new System.Windows.Forms.Label();
            this.cbDyskTwardy = new System.Windows.Forms.ComboBox();
            this.lblDyskTwardy = new System.Windows.Forms.Label();
            this.cbDyskSSD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKartaGraficzna = new System.Windows.Forms.TextBox();
            this.lblKartaGraficzna = new System.Windows.Forms.Label();
            this.tbZasilacz = new System.Windows.Forms.TextBox();
            this.lblZasilacz = new System.Windows.Forms.Label();
            this.tbEkran = new System.Windows.Forms.TextBox();
            this.lblEkran = new System.Windows.Forms.Label();
            this.cbSystemOperacyjny = new System.Windows.Forms.ComboBox();
            this.lblSystemOperacyjny = new System.Windows.Forms.Label();
            this.lblRysy = new System.Windows.Forms.Label();
            this.lblPlamy = new System.Windows.Forms.Label();
            this.lblUszkodzenia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRysy = new System.Windows.Forms.ComboBox();
            this.cbPlamy = new System.Windows.Forms.ComboBox();
            this.cbUszkodzenia = new System.Windows.Forms.ComboBox();
            this.tbUwagi = new System.Windows.Forms.RichTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.btnDodajZlecenie = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbKlient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTypZlecenia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOpisUsterki = new System.Windows.Forms.RichTextBox();
            this.lblOpisUsterki = new System.Windows.Forms.Label();
            this.cbGwarancja = new System.Windows.Forms.ComboBox();
            this.lblGwarancja = new System.Windows.Forms.Label();
            this.chbFirma = new System.Windows.Forms.CheckBox();
            this.chbOsoba = new System.Windows.Forms.CheckBox();
            this.pbKlient = new System.Windows.Forms.PictureBox();
            this.tbCenaUsluga = new System.Windows.Forms.TextBox();
            this.tbCenaCzesci = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbKlient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTypUrzadzenia
            // 
            this.lblTypUrzadzenia.AutoSize = true;
            this.lblTypUrzadzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTypUrzadzenia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTypUrzadzenia.Location = new System.Drawing.Point(23, 10);
            this.lblTypUrzadzenia.Name = "lblTypUrzadzenia";
            this.lblTypUrzadzenia.Size = new System.Drawing.Size(118, 16);
            this.lblTypUrzadzenia.TabIndex = 1;
            this.lblTypUrzadzenia.Text = "Typ urządzenia:";
            // 
            // cbTypUrzadzenia
            // 
            this.cbTypUrzadzenia.BackColor = System.Drawing.Color.BurlyWood;
            this.cbTypUrzadzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTypUrzadzenia.ForeColor = System.Drawing.Color.DarkRed;
            this.cbTypUrzadzenia.FormattingEnabled = true;
            this.cbTypUrzadzenia.Items.AddRange(new object[] {
            "Komputer",
            "Laptop",
            "Smartfon",
            "Telefon"});
            this.cbTypUrzadzenia.Location = new System.Drawing.Point(169, 6);
            this.cbTypUrzadzenia.Name = "cbTypUrzadzenia";
            this.cbTypUrzadzenia.Size = new System.Drawing.Size(162, 24);
            this.cbTypUrzadzenia.TabIndex = 1;
            this.cbTypUrzadzenia.Text = "Komputer";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMarka.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMarka.Location = new System.Drawing.Point(23, 37);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(55, 16);
            this.lblMarka.TabIndex = 11;
            this.lblMarka.Text = "Marka:";
            // 
            // cbMarka
            // 
            this.cbMarka.BackColor = System.Drawing.Color.BurlyWood;
            this.cbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMarka.ForeColor = System.Drawing.Color.DarkRed;
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(169, 33);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(162, 24);
            this.cbMarka.TabIndex = 2;
            this.cbMarka.SelectedIndexChanged += new System.EventHandler(this.cbMarka_SelectedIndexChanged);
            // 
            // cbModel
            // 
            this.cbModel.BackColor = System.Drawing.Color.BurlyWood;
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbModel.ForeColor = System.Drawing.Color.DarkRed;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(169, 62);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(162, 24);
            this.cbModel.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblModel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblModel.Location = new System.Drawing.Point(23, 66);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(55, 16);
            this.lblModel.TabIndex = 13;
            this.lblModel.Text = "Model:";
            // 
            // lblNrSeryjny
            // 
            this.lblNrSeryjny.AutoSize = true;
            this.lblNrSeryjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNrSeryjny.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNrSeryjny.Location = new System.Drawing.Point(23, 94);
            this.lblNrSeryjny.Name = "lblNrSeryjny";
            this.lblNrSeryjny.Size = new System.Drawing.Size(82, 16);
            this.lblNrSeryjny.TabIndex = 15;
            this.lblNrSeryjny.Text = "Nr seryjny:";
            // 
            // tbNrSeryjny
            // 
            this.tbNrSeryjny.BackColor = System.Drawing.Color.BurlyWood;
            this.tbNrSeryjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNrSeryjny.ForeColor = System.Drawing.Color.DarkRed;
            this.tbNrSeryjny.Location = new System.Drawing.Point(169, 91);
            this.tbNrSeryjny.MaxLength = 80;
            this.tbNrSeryjny.Name = "tbNrSeryjny";
            this.tbNrSeryjny.Size = new System.Drawing.Size(225, 22);
            this.tbNrSeryjny.TabIndex = 4;
            // 
            // tbImei
            // 
            this.tbImei.BackColor = System.Drawing.Color.BurlyWood;
            this.tbImei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbImei.ForeColor = System.Drawing.Color.DarkRed;
            this.tbImei.Location = new System.Drawing.Point(169, 118);
            this.tbImei.MaxLength = 15;
            this.tbImei.Name = "tbImei";
            this.tbImei.Size = new System.Drawing.Size(225, 22);
            this.tbImei.TabIndex = 5;
            // 
            // lblImei
            // 
            this.lblImei.AutoSize = true;
            this.lblImei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImei.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblImei.Location = new System.Drawing.Point(23, 121);
            this.lblImei.Name = "lblImei";
            this.lblImei.Size = new System.Drawing.Size(41, 16);
            this.lblImei.TabIndex = 17;
            this.lblImei.Text = "Imei:";
            // 
            // tbProcesor
            // 
            this.tbProcesor.BackColor = System.Drawing.Color.BurlyWood;
            this.tbProcesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbProcesor.ForeColor = System.Drawing.Color.DarkRed;
            this.tbProcesor.Location = new System.Drawing.Point(169, 146);
            this.tbProcesor.MaxLength = 80;
            this.tbProcesor.Name = "tbProcesor";
            this.tbProcesor.Size = new System.Drawing.Size(225, 22);
            this.tbProcesor.TabIndex = 6;
            // 
            // lblProcesor
            // 
            this.lblProcesor.AutoSize = true;
            this.lblProcesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProcesor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProcesor.Location = new System.Drawing.Point(23, 149);
            this.lblProcesor.Name = "lblProcesor";
            this.lblProcesor.Size = new System.Drawing.Size(75, 16);
            this.lblProcesor.TabIndex = 19;
            this.lblProcesor.Text = "Procesor:";
            // 
            // cbPamiec
            // 
            this.cbPamiec.BackColor = System.Drawing.Color.BurlyWood;
            this.cbPamiec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPamiec.ForeColor = System.Drawing.Color.DarkRed;
            this.cbPamiec.FormattingEnabled = true;
            this.cbPamiec.Items.AddRange(new object[] {
            "512 MB",
            "1 GB",
            "2 GB",
            "3 GB",
            "4 GB",
            "6 GB",
            "8 GB",
            "12 GB",
            "16 GB",
            "32 GB",
            "64 GB",
            "128 GB"});
            this.cbPamiec.Location = new System.Drawing.Point(169, 173);
            this.cbPamiec.Name = "cbPamiec";
            this.cbPamiec.Size = new System.Drawing.Size(162, 24);
            this.cbPamiec.TabIndex = 7;
            this.cbPamiec.Text = "4 GB";
            // 
            // lblPamiec
            // 
            this.lblPamiec.AutoSize = true;
            this.lblPamiec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPamiec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPamiec.Location = new System.Drawing.Point(23, 177);
            this.lblPamiec.Name = "lblPamiec";
            this.lblPamiec.Size = new System.Drawing.Size(64, 16);
            this.lblPamiec.TabIndex = 21;
            this.lblPamiec.Text = "Pamięć:";
            // 
            // tbPlytaGlowna
            // 
            this.tbPlytaGlowna.BackColor = System.Drawing.Color.BurlyWood;
            this.tbPlytaGlowna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPlytaGlowna.ForeColor = System.Drawing.Color.DarkRed;
            this.tbPlytaGlowna.Location = new System.Drawing.Point(169, 203);
            this.tbPlytaGlowna.MaxLength = 80;
            this.tbPlytaGlowna.Name = "tbPlytaGlowna";
            this.tbPlytaGlowna.Size = new System.Drawing.Size(225, 22);
            this.tbPlytaGlowna.TabIndex = 8;
            // 
            // lblPlytaGlowna
            // 
            this.lblPlytaGlowna.AutoSize = true;
            this.lblPlytaGlowna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlytaGlowna.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlytaGlowna.Location = new System.Drawing.Point(23, 206);
            this.lblPlytaGlowna.Name = "lblPlytaGlowna";
            this.lblPlytaGlowna.Size = new System.Drawing.Size(106, 16);
            this.lblPlytaGlowna.TabIndex = 23;
            this.lblPlytaGlowna.Text = "Płyta główna:";
            // 
            // cbDyskTwardy
            // 
            this.cbDyskTwardy.BackColor = System.Drawing.Color.BurlyWood;
            this.cbDyskTwardy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDyskTwardy.ForeColor = System.Drawing.Color.DarkRed;
            this.cbDyskTwardy.FormattingEnabled = true;
            this.cbDyskTwardy.Items.AddRange(new object[] {
            "60 GB",
            "120 GB",
            "320 GB",
            "500 GB",
            "1 TB",
            "2 TB",
            "nie dotyczy"});
            this.cbDyskTwardy.Location = new System.Drawing.Point(169, 231);
            this.cbDyskTwardy.Name = "cbDyskTwardy";
            this.cbDyskTwardy.Size = new System.Drawing.Size(162, 24);
            this.cbDyskTwardy.TabIndex = 9;
            this.cbDyskTwardy.Text = "nie dotyczy";
            this.cbDyskTwardy.UseWaitCursor = true;
            // 
            // lblDyskTwardy
            // 
            this.lblDyskTwardy.AutoSize = true;
            this.lblDyskTwardy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDyskTwardy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDyskTwardy.Location = new System.Drawing.Point(23, 235);
            this.lblDyskTwardy.Name = "lblDyskTwardy";
            this.lblDyskTwardy.Size = new System.Drawing.Size(96, 16);
            this.lblDyskTwardy.TabIndex = 25;
            this.lblDyskTwardy.Text = "Dysk twardy:";
            // 
            // cbDyskSSD
            // 
            this.cbDyskSSD.BackColor = System.Drawing.Color.BurlyWood;
            this.cbDyskSSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDyskSSD.ForeColor = System.Drawing.Color.DarkRed;
            this.cbDyskSSD.FormattingEnabled = true;
            this.cbDyskSSD.Items.AddRange(new object[] {
            "60 GB",
            "120 GB",
            "240 GB",
            "480 GB",
            "nie dotyczy"});
            this.cbDyskSSD.Location = new System.Drawing.Point(169, 261);
            this.cbDyskSSD.Name = "cbDyskSSD";
            this.cbDyskSSD.Size = new System.Drawing.Size(162, 24);
            this.cbDyskSSD.TabIndex = 10;
            this.cbDyskSSD.Text = "nie dotyczy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Dysk SSD:";
            // 
            // tbKartaGraficzna
            // 
            this.tbKartaGraficzna.BackColor = System.Drawing.Color.BurlyWood;
            this.tbKartaGraficzna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKartaGraficzna.ForeColor = System.Drawing.Color.DarkRed;
            this.tbKartaGraficzna.Location = new System.Drawing.Point(169, 292);
            this.tbKartaGraficzna.MaxLength = 80;
            this.tbKartaGraficzna.Name = "tbKartaGraficzna";
            this.tbKartaGraficzna.Size = new System.Drawing.Size(225, 22);
            this.tbKartaGraficzna.TabIndex = 11;
            // 
            // lblKartaGraficzna
            // 
            this.lblKartaGraficzna.AutoSize = true;
            this.lblKartaGraficzna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKartaGraficzna.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKartaGraficzna.Location = new System.Drawing.Point(23, 295);
            this.lblKartaGraficzna.Name = "lblKartaGraficzna";
            this.lblKartaGraficzna.Size = new System.Drawing.Size(115, 16);
            this.lblKartaGraficzna.TabIndex = 29;
            this.lblKartaGraficzna.Text = "Karta graficzna:";
            // 
            // tbZasilacz
            // 
            this.tbZasilacz.BackColor = System.Drawing.Color.BurlyWood;
            this.tbZasilacz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbZasilacz.ForeColor = System.Drawing.Color.DarkRed;
            this.tbZasilacz.Location = new System.Drawing.Point(169, 320);
            this.tbZasilacz.MaxLength = 80;
            this.tbZasilacz.Name = "tbZasilacz";
            this.tbZasilacz.Size = new System.Drawing.Size(225, 22);
            this.tbZasilacz.TabIndex = 12;
            // 
            // lblZasilacz
            // 
            this.lblZasilacz.AutoSize = true;
            this.lblZasilacz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZasilacz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblZasilacz.Location = new System.Drawing.Point(23, 323);
            this.lblZasilacz.Name = "lblZasilacz";
            this.lblZasilacz.Size = new System.Drawing.Size(70, 16);
            this.lblZasilacz.TabIndex = 31;
            this.lblZasilacz.Text = "Zasilacz:";
            // 
            // tbEkran
            // 
            this.tbEkran.BackColor = System.Drawing.Color.BurlyWood;
            this.tbEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEkran.ForeColor = System.Drawing.Color.DarkRed;
            this.tbEkran.Location = new System.Drawing.Point(597, 7);
            this.tbEkran.MaxLength = 80;
            this.tbEkran.Name = "tbEkran";
            this.tbEkran.Size = new System.Drawing.Size(225, 22);
            this.tbEkran.TabIndex = 13;
            // 
            // lblEkran
            // 
            this.lblEkran.AutoSize = true;
            this.lblEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEkran.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEkran.Location = new System.Drawing.Point(451, 10);
            this.lblEkran.Name = "lblEkran";
            this.lblEkran.Size = new System.Drawing.Size(52, 16);
            this.lblEkran.TabIndex = 33;
            this.lblEkran.Text = "Ekran:";
            // 
            // cbSystemOperacyjny
            // 
            this.cbSystemOperacyjny.BackColor = System.Drawing.Color.BurlyWood;
            this.cbSystemOperacyjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSystemOperacyjny.ForeColor = System.Drawing.Color.DarkRed;
            this.cbSystemOperacyjny.FormattingEnabled = true;
            this.cbSystemOperacyjny.Items.AddRange(new object[] {
            "Android",
            "Brak",
            "iOS",
            "Linux",
            "Windows",
            "Windows Mobile"});
            this.cbSystemOperacyjny.Location = new System.Drawing.Point(597, 33);
            this.cbSystemOperacyjny.Name = "cbSystemOperacyjny";
            this.cbSystemOperacyjny.Size = new System.Drawing.Size(162, 24);
            this.cbSystemOperacyjny.TabIndex = 14;
            this.cbSystemOperacyjny.Text = "Windows";
            // 
            // lblSystemOperacyjny
            // 
            this.lblSystemOperacyjny.AutoSize = true;
            this.lblSystemOperacyjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSystemOperacyjny.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSystemOperacyjny.Location = new System.Drawing.Point(451, 37);
            this.lblSystemOperacyjny.Name = "lblSystemOperacyjny";
            this.lblSystemOperacyjny.Size = new System.Drawing.Size(144, 16);
            this.lblSystemOperacyjny.TabIndex = 35;
            this.lblSystemOperacyjny.Text = "System operacyjny:";
            // 
            // lblRysy
            // 
            this.lblRysy.AutoSize = true;
            this.lblRysy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRysy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRysy.Location = new System.Drawing.Point(451, 66);
            this.lblRysy.Name = "lblRysy";
            this.lblRysy.Size = new System.Drawing.Size(47, 16);
            this.lblRysy.TabIndex = 37;
            this.lblRysy.Text = "Rysy:";
            // 
            // lblPlamy
            // 
            this.lblPlamy.AutoSize = true;
            this.lblPlamy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlamy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlamy.Location = new System.Drawing.Point(451, 94);
            this.lblPlamy.Name = "lblPlamy";
            this.lblPlamy.Size = new System.Drawing.Size(55, 16);
            this.lblPlamy.TabIndex = 38;
            this.lblPlamy.Text = "Plamy:";
            // 
            // lblUszkodzenia
            // 
            this.lblUszkodzenia.AutoSize = true;
            this.lblUszkodzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUszkodzenia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUszkodzenia.Location = new System.Drawing.Point(451, 121);
            this.lblUszkodzenia.Name = "lblUszkodzenia";
            this.lblUszkodzenia.Size = new System.Drawing.Size(101, 16);
            this.lblUszkodzenia.TabIndex = 39;
            this.lblUszkodzenia.Text = "Uszkodzenia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(23, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Uwagi:";
            // 
            // cbRysy
            // 
            this.cbRysy.BackColor = System.Drawing.Color.BurlyWood;
            this.cbRysy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbRysy.ForeColor = System.Drawing.Color.DarkRed;
            this.cbRysy.FormattingEnabled = true;
            this.cbRysy.Items.AddRange(new object[] {
            "Nie",
            "Tak"});
            this.cbRysy.Location = new System.Drawing.Point(597, 62);
            this.cbRysy.Name = "cbRysy";
            this.cbRysy.Size = new System.Drawing.Size(162, 24);
            this.cbRysy.TabIndex = 15;
            this.cbRysy.Text = "Nie";
            // 
            // cbPlamy
            // 
            this.cbPlamy.BackColor = System.Drawing.Color.BurlyWood;
            this.cbPlamy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPlamy.ForeColor = System.Drawing.Color.DarkRed;
            this.cbPlamy.FormattingEnabled = true;
            this.cbPlamy.Items.AddRange(new object[] {
            "Nie",
            "Tak"});
            this.cbPlamy.Location = new System.Drawing.Point(597, 90);
            this.cbPlamy.Name = "cbPlamy";
            this.cbPlamy.Size = new System.Drawing.Size(162, 24);
            this.cbPlamy.TabIndex = 16;
            this.cbPlamy.Text = "Nie";
            // 
            // cbUszkodzenia
            // 
            this.cbUszkodzenia.BackColor = System.Drawing.Color.BurlyWood;
            this.cbUszkodzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbUszkodzenia.ForeColor = System.Drawing.Color.DarkRed;
            this.cbUszkodzenia.FormattingEnabled = true;
            this.cbUszkodzenia.Items.AddRange(new object[] {
            "Nie",
            "Tak"});
            this.cbUszkodzenia.Location = new System.Drawing.Point(597, 117);
            this.cbUszkodzenia.Name = "cbUszkodzenia";
            this.cbUszkodzenia.Size = new System.Drawing.Size(162, 24);
            this.cbUszkodzenia.TabIndex = 17;
            this.cbUszkodzenia.Text = "Nie";
            // 
            // tbUwagi
            // 
            this.tbUwagi.BackColor = System.Drawing.Color.BurlyWood;
            this.tbUwagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUwagi.ForeColor = System.Drawing.Color.DarkRed;
            this.tbUwagi.Location = new System.Drawing.Point(169, 458);
            this.tbUwagi.Name = "tbUwagi";
            this.tbUwagi.Size = new System.Drawing.Size(426, 102);
            this.tbUwagi.TabIndex = 19;
            this.tbUwagi.Text = "";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblData.Location = new System.Drawing.Point(451, 149);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(112, 16);
            this.lblData.TabIndex = 45;
            this.lblData.Text = "Data przyjęcia:";
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnWyczysc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWyczysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyczysc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWyczysc.Image = global::Poltrone_Electronics.Properties.Resources.Clear_icon;
            this.btnWyczysc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWyczysc.Location = new System.Drawing.Point(182, 566);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnWyczysc.Size = new System.Drawing.Size(106, 37);
            this.btnWyczysc.TabIndex = 48;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWyczysc.UseVisualStyleBackColor = false;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // btnDodajZlecenie
            // 
            this.btnDodajZlecenie.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDodajZlecenie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajZlecenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajZlecenie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajZlecenie.Image = global::Poltrone_Electronics.Properties.Resources.add_1_icon;
            this.btnDodajZlecenie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajZlecenie.Location = new System.Drawing.Point(12, 566);
            this.btnDodajZlecenie.Name = "btnDodajZlecenie";
            this.btnDodajZlecenie.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDodajZlecenie.Size = new System.Drawing.Size(164, 37);
            this.btnDodajZlecenie.TabIndex = 47;
            this.btnDodajZlecenie.Text = "Dodaj zlecenie";
            this.btnDodajZlecenie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajZlecenie.UseVisualStyleBackColor = false;
            this.btnDodajZlecenie.Click += new System.EventHandler(this.btnDodajZlecenie_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZamknij.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZamknij.Image = global::Poltrone_Electronics.Properties.Resources.Close_2_icon;
            this.btnZamknij.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamknij.Location = new System.Drawing.Point(294, 566);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnZamknij.Size = new System.Drawing.Size(107, 37);
            this.btnZamknij.TabIndex = 46;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZamknij.UseVisualStyleBackColor = false;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // dtData
            // 
            this.dtData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtData.CalendarMonthBackground = System.Drawing.Color.BurlyWood;
            this.dtData.CustomFormat = "yyyy-MM-dd";
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(597, 146);
            this.dtData.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtData.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(120, 22);
            this.dtData.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(451, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Klient:";
            // 
            // cbKlient
            // 
            this.cbKlient.BackColor = System.Drawing.Color.BurlyWood;
            this.cbKlient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKlient.ForeColor = System.Drawing.Color.DarkRed;
            this.cbKlient.FormattingEnabled = true;
            this.cbKlient.Location = new System.Drawing.Point(597, 202);
            this.cbKlient.Name = "cbKlient";
            this.cbKlient.Size = new System.Drawing.Size(310, 24);
            this.cbKlient.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(451, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Typ zlecenia:";
            // 
            // cbTypZlecenia
            // 
            this.cbTypZlecenia.BackColor = System.Drawing.Color.BurlyWood;
            this.cbTypZlecenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTypZlecenia.ForeColor = System.Drawing.Color.DarkRed;
            this.cbTypZlecenia.FormattingEnabled = true;
            this.cbTypZlecenia.Items.AddRange(new object[] {
            "Gwarancyjne",
            "Kosztorys",
            "Pogwarancyjne"});
            this.cbTypZlecenia.Location = new System.Drawing.Point(597, 231);
            this.cbTypZlecenia.Name = "cbTypZlecenia";
            this.cbTypZlecenia.Size = new System.Drawing.Size(162, 24);
            this.cbTypZlecenia.TabIndex = 24;
            this.cbTypZlecenia.Text = "Gwarancyjne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(451, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Cena usługa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(451, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Cena części:";
            // 
            // tbOpisUsterki
            // 
            this.tbOpisUsterki.BackColor = System.Drawing.Color.BurlyWood;
            this.tbOpisUsterki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOpisUsterki.ForeColor = System.Drawing.Color.DarkRed;
            this.tbOpisUsterki.Location = new System.Drawing.Point(169, 348);
            this.tbOpisUsterki.Name = "tbOpisUsterki";
            this.tbOpisUsterki.Size = new System.Drawing.Size(426, 102);
            this.tbOpisUsterki.TabIndex = 18;
            this.tbOpisUsterki.Text = "";
            // 
            // lblOpisUsterki
            // 
            this.lblOpisUsterki.AutoSize = true;
            this.lblOpisUsterki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisUsterki.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOpisUsterki.Location = new System.Drawing.Point(23, 349);
            this.lblOpisUsterki.Name = "lblOpisUsterki";
            this.lblOpisUsterki.Size = new System.Drawing.Size(94, 16);
            this.lblOpisUsterki.TabIndex = 59;
            this.lblOpisUsterki.Text = "Opis usterki:";
            // 
            // cbGwarancja
            // 
            this.cbGwarancja.BackColor = System.Drawing.Color.BurlyWood;
            this.cbGwarancja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbGwarancja.ForeColor = System.Drawing.Color.DarkRed;
            this.cbGwarancja.FormattingEnabled = true;
            this.cbGwarancja.Items.AddRange(new object[] {
            "1 miesiąc",
            "3 miesiące",
            "6 miesięcy",
            "1 rok",
            "2 lata",
            "3 lata"});
            this.cbGwarancja.Location = new System.Drawing.Point(597, 319);
            this.cbGwarancja.Name = "cbGwarancja";
            this.cbGwarancja.Size = new System.Drawing.Size(162, 24);
            this.cbGwarancja.TabIndex = 27;
            this.cbGwarancja.Text = "3 miesiące";
            // 
            // lblGwarancja
            // 
            this.lblGwarancja.AutoSize = true;
            this.lblGwarancja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGwarancja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGwarancja.Location = new System.Drawing.Point(451, 323);
            this.lblGwarancja.Name = "lblGwarancja";
            this.lblGwarancja.Size = new System.Drawing.Size(101, 16);
            this.lblGwarancja.TabIndex = 61;
            this.lblGwarancja.Text = "Typ zlecenia:";
            // 
            // chbFirma
            // 
            this.chbFirma.AutoSize = true;
            this.chbFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbFirma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chbFirma.Location = new System.Drawing.Point(680, 175);
            this.chbFirma.Name = "chbFirma";
            this.chbFirma.Size = new System.Drawing.Size(66, 20);
            this.chbFirma.TabIndex = 22;
            this.chbFirma.Text = "Firma";
            this.chbFirma.UseVisualStyleBackColor = true;
            this.chbFirma.CheckedChanged += new System.EventHandler(this.chbFirma_CheckedChanged);
            // 
            // chbOsoba
            // 
            this.chbOsoba.AutoSize = true;
            this.chbOsoba.Checked = true;
            this.chbOsoba.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbOsoba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbOsoba.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chbOsoba.Location = new System.Drawing.Point(597, 175);
            this.chbOsoba.Name = "chbOsoba";
            this.chbOsoba.Size = new System.Drawing.Size(73, 20);
            this.chbOsoba.TabIndex = 21;
            this.chbOsoba.Text = "Osoba";
            this.chbOsoba.UseVisualStyleBackColor = true;
            this.chbOsoba.CheckedChanged += new System.EventHandler(this.chbOsoba_CheckedChanged);
            // 
            // pbKlient
            // 
            this.pbKlient.Image = global::Poltrone_Electronics.Properties.Resources.add_1_icon;
            this.pbKlient.Location = new System.Drawing.Point(575, 206);
            this.pbKlient.Name = "pbKlient";
            this.pbKlient.Size = new System.Drawing.Size(16, 16);
            this.pbKlient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbKlient.TabIndex = 65;
            this.pbKlient.TabStop = false;
            this.pbKlient.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbCenaUsluga
            // 
            this.tbCenaUsluga.BackColor = System.Drawing.Color.BurlyWood;
            this.tbCenaUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCenaUsluga.ForeColor = System.Drawing.Color.DarkRed;
            this.tbCenaUsluga.Location = new System.Drawing.Point(597, 262);
            this.tbCenaUsluga.MaxLength = 80;
            this.tbCenaUsluga.Name = "tbCenaUsluga";
            this.tbCenaUsluga.Size = new System.Drawing.Size(79, 22);
            this.tbCenaUsluga.TabIndex = 25;
            // 
            // tbCenaCzesci
            // 
            this.tbCenaCzesci.BackColor = System.Drawing.Color.BurlyWood;
            this.tbCenaCzesci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCenaCzesci.ForeColor = System.Drawing.Color.DarkRed;
            this.tbCenaCzesci.Location = new System.Drawing.Point(597, 292);
            this.tbCenaCzesci.MaxLength = 80;
            this.tbCenaCzesci.Name = "tbCenaCzesci";
            this.tbCenaCzesci.Size = new System.Drawing.Size(79, 22);
            this.tbCenaCzesci.TabIndex = 26;
            // 
            // Zlecenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(919, 611);
            this.Controls.Add(this.tbCenaCzesci);
            this.Controls.Add(this.tbCenaUsluga);
            this.Controls.Add(this.pbKlient);
            this.Controls.Add(this.chbFirma);
            this.Controls.Add(this.chbOsoba);
            this.Controls.Add(this.cbGwarancja);
            this.Controls.Add(this.lblGwarancja);
            this.Controls.Add(this.tbOpisUsterki);
            this.Controls.Add(this.lblOpisUsterki);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTypZlecenia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbKlient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.btnWyczysc);
            this.Controls.Add(this.btnDodajZlecenie);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.tbUwagi);
            this.Controls.Add(this.cbUszkodzenia);
            this.Controls.Add(this.cbPlamy);
            this.Controls.Add(this.cbRysy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUszkodzenia);
            this.Controls.Add(this.lblPlamy);
            this.Controls.Add(this.lblRysy);
            this.Controls.Add(this.cbSystemOperacyjny);
            this.Controls.Add(this.lblSystemOperacyjny);
            this.Controls.Add(this.tbEkran);
            this.Controls.Add(this.lblEkran);
            this.Controls.Add(this.tbZasilacz);
            this.Controls.Add(this.lblZasilacz);
            this.Controls.Add(this.tbKartaGraficzna);
            this.Controls.Add(this.lblKartaGraficzna);
            this.Controls.Add(this.cbDyskSSD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDyskTwardy);
            this.Controls.Add(this.lblDyskTwardy);
            this.Controls.Add(this.tbPlytaGlowna);
            this.Controls.Add(this.lblPlytaGlowna);
            this.Controls.Add(this.cbPamiec);
            this.Controls.Add(this.lblPamiec);
            this.Controls.Add(this.tbProcesor);
            this.Controls.Add(this.lblProcesor);
            this.Controls.Add(this.tbImei);
            this.Controls.Add(this.lblImei);
            this.Controls.Add(this.tbNrSeryjny);
            this.Controls.Add(this.lblNrSeryjny);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.cbTypUrzadzenia);
            this.Controls.Add(this.lblTypUrzadzenia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zlecenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poltrone electronics - Zlecenie";
            this.Activated += new System.EventHandler(this.Zlecenie_Activated);
            this.Shown += new System.EventHandler(this.Zlecenie_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbKlient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypUrzadzenia;
        private System.Windows.Forms.ComboBox cbTypUrzadzenia;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblNrSeryjny;
        private System.Windows.Forms.TextBox tbNrSeryjny;
        private System.Windows.Forms.TextBox tbImei;
        private System.Windows.Forms.Label lblImei;
        private System.Windows.Forms.TextBox tbProcesor;
        private System.Windows.Forms.Label lblProcesor;
        private System.Windows.Forms.ComboBox cbPamiec;
        private System.Windows.Forms.Label lblPamiec;
        private System.Windows.Forms.TextBox tbPlytaGlowna;
        private System.Windows.Forms.Label lblPlytaGlowna;
        private System.Windows.Forms.ComboBox cbDyskTwardy;
        private System.Windows.Forms.Label lblDyskTwardy;
        private System.Windows.Forms.ComboBox cbDyskSSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKartaGraficzna;
        private System.Windows.Forms.Label lblKartaGraficzna;
        private System.Windows.Forms.TextBox tbZasilacz;
        private System.Windows.Forms.Label lblZasilacz;
        private System.Windows.Forms.TextBox tbEkran;
        private System.Windows.Forms.Label lblEkran;
        private System.Windows.Forms.ComboBox cbSystemOperacyjny;
        private System.Windows.Forms.Label lblSystemOperacyjny;
        private System.Windows.Forms.Label lblRysy;
        private System.Windows.Forms.Label lblPlamy;
        private System.Windows.Forms.Label lblUszkodzenia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRysy;
        private System.Windows.Forms.ComboBox cbPlamy;
        private System.Windows.Forms.ComboBox cbUszkodzenia;
        private System.Windows.Forms.RichTextBox tbUwagi;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.Button btnDodajZlecenie;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbKlient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTypZlecenia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tbOpisUsterki;
        private System.Windows.Forms.Label lblOpisUsterki;
        private System.Windows.Forms.ComboBox cbGwarancja;
        private System.Windows.Forms.Label lblGwarancja;
        private System.Windows.Forms.CheckBox chbFirma;
        private System.Windows.Forms.CheckBox chbOsoba;
        private System.Windows.Forms.PictureBox pbKlient;
        private System.Windows.Forms.TextBox tbCenaUsluga;
        private System.Windows.Forms.TextBox tbCenaCzesci;
    }
}