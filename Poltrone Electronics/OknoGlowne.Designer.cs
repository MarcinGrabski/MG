namespace Poltrone_Electronics
{
    partial class OknoGlowne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoGlowne));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.klienciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaKlientówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zlecenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajZlecenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujZlecenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zdjęciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.lblFiltruj = new System.Windows.Forms.Label();
            this.cbFiltruj = new System.Windows.Forms.ComboBox();
            this.tbWyszukaj = new System.Windows.Forms.TextBox();
            this.lblTypUrzadzenia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnEkspertyza = new System.Windows.Forms.Button();
            this.btnZdjecia = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.lblZalogowany = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klienciToolStripMenuItem,
            this.zlecenieToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // klienciToolStripMenuItem
            // 
            this.klienciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKlientaToolStripMenuItem,
            this.listaKlientówToolStripMenuItem});
            this.klienciToolStripMenuItem.Name = "klienciToolStripMenuItem";
            this.klienciToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.klienciToolStripMenuItem.Text = "&Klienci";
            // 
            // dodajKlientaToolStripMenuItem
            // 
            this.dodajKlientaToolStripMenuItem.Name = "dodajKlientaToolStripMenuItem";
            this.dodajKlientaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.dodajKlientaToolStripMenuItem.Text = "&Dodaj klienta";
            this.dodajKlientaToolStripMenuItem.Click += new System.EventHandler(this.dodajKlientaToolStripMenuItem_Click);
            // 
            // listaKlientówToolStripMenuItem
            // 
            this.listaKlientówToolStripMenuItem.Name = "listaKlientówToolStripMenuItem";
            this.listaKlientówToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.listaKlientówToolStripMenuItem.Text = "&Lista klientów";
            this.listaKlientówToolStripMenuItem.Click += new System.EventHandler(this.listaKlientówToolStripMenuItem_Click);
            // 
            // zlecenieToolStripMenuItem
            // 
            this.zlecenieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajZlecenieToolStripMenuItem,
            this.edytujZlecenieToolStripMenuItem,
            this.zdjęciaToolStripMenuItem});
            this.zlecenieToolStripMenuItem.Name = "zlecenieToolStripMenuItem";
            this.zlecenieToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.zlecenieToolStripMenuItem.Text = "&Zlecenia";
            // 
            // dodajZlecenieToolStripMenuItem
            // 
            this.dodajZlecenieToolStripMenuItem.Name = "dodajZlecenieToolStripMenuItem";
            this.dodajZlecenieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dodajZlecenieToolStripMenuItem.Text = "&Dodaj zlecenie";
            this.dodajZlecenieToolStripMenuItem.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // edytujZlecenieToolStripMenuItem
            // 
            this.edytujZlecenieToolStripMenuItem.Name = "edytujZlecenieToolStripMenuItem";
            this.edytujZlecenieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.edytujZlecenieToolStripMenuItem.Text = "&Edytuj zlecenie";
            this.edytujZlecenieToolStripMenuItem.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // zdjęciaToolStripMenuItem
            // 
            this.zdjęciaToolStripMenuItem.Name = "zdjęciaToolStripMenuItem";
            this.zdjęciaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zdjęciaToolStripMenuItem.Text = "&Zdjęcia";
            this.zdjęciaToolStripMenuItem.Click += new System.EventHandler(this.btnZdjecia_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.zamknijToolStripMenuItem.Text = "&Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // dgrid
            // 
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid.Location = new System.Drawing.Point(0, 24);
            this.dgrid.Name = "dgrid";
            this.dgrid.ReadOnly = true;
            this.dgrid.Size = new System.Drawing.Size(1184, 365);
            this.dgrid.TabIndex = 1;
            this.dgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_CellClick);
            // 
            // lblFiltruj
            // 
            this.lblFiltruj.AutoSize = true;
            this.lblFiltruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFiltruj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFiltruj.Location = new System.Drawing.Point(18, 407);
            this.lblFiltruj.Name = "lblFiltruj";
            this.lblFiltruj.Size = new System.Drawing.Size(84, 20);
            this.lblFiltruj.TabIndex = 8;
            this.lblFiltruj.Text = "Filtruj po:";
            // 
            // cbFiltruj
            // 
            this.cbFiltruj.BackColor = System.Drawing.Color.BurlyWood;
            this.cbFiltruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFiltruj.FormattingEnabled = true;
            this.cbFiltruj.Items.AddRange(new object[] {
            "Decyzja klienta",
            "Naprawa usterki",
            "Oczekiwanie na części",
            "Odbiór sprzętu",
            "Odesłanie",
            "W naprawie",
            "Wszystko",
            "Wycena naprawy",
            "Zakończono"});
            this.cbFiltruj.Location = new System.Drawing.Point(108, 404);
            this.cbFiltruj.Name = "cbFiltruj";
            this.cbFiltruj.Size = new System.Drawing.Size(162, 28);
            this.cbFiltruj.Sorted = true;
            this.cbFiltruj.TabIndex = 9;
            this.cbFiltruj.Text = "Wszystko";
            this.cbFiltruj.SelectedIndexChanged += new System.EventHandler(this.cbFiltruj_SelectedIndexChanged);
            // 
            // tbWyszukaj
            // 
            this.tbWyszukaj.BackColor = System.Drawing.Color.BurlyWood;
            this.tbWyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbWyszukaj.ForeColor = System.Drawing.Color.DarkRed;
            this.tbWyszukaj.Location = new System.Drawing.Point(382, 404);
            this.tbWyszukaj.MaxLength = 80;
            this.tbWyszukaj.Name = "tbWyszukaj";
            this.tbWyszukaj.Size = new System.Drawing.Size(294, 26);
            this.tbWyszukaj.TabIndex = 11;
            this.tbWyszukaj.TextChanged += new System.EventHandler(this.tbWyszukaj_TextChanged);
            // 
            // lblTypUrzadzenia
            // 
            this.lblTypUrzadzenia.AutoSize = true;
            this.lblTypUrzadzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTypUrzadzenia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTypUrzadzenia.Location = new System.Drawing.Point(286, 407);
            this.lblTypUrzadzenia.Name = "lblTypUrzadzenia";
            this.lblTypUrzadzenia.Size = new System.Drawing.Size(89, 20);
            this.lblTypUrzadzenia.TabIndex = 10;
            this.lblTypUrzadzenia.Text = "Wyszukaj:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(682, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Zmień status:";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.BurlyWood;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Decyzja klienta",
            "Naprawa usterki",
            "Oczekiwanie na części",
            "Odbiór sprzętu",
            "Odesłanie",
            "W naprawie",
            "Wycena naprawy",
            "Zakończono"});
            this.cbStatus.Location = new System.Drawing.Point(806, 404);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 28);
            this.cbStatus.Sorted = true;
            this.cbStatus.TabIndex = 14;
            this.cbStatus.Text = "Wybierz status";
            this.cbStatus.SelectedValueChanged += new System.EventHandler(this.cbStatus_SelectedValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SaddleBrown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::Poltrone_Electronics.Properties.Resources.Clients_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(804, 441);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(147, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Lista klientów";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.listaKlientówToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::Poltrone_Electronics.Properties.Resources.User_Clients_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(962, 441);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(147, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Dodaj klienta";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.dodajKlientaToolStripMenuItem_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPDF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPDF.Image = global::Poltrone_Electronics.Properties.Resources.Adobe_PDF_Document_icon;
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.Location = new System.Drawing.Point(710, 441);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPDF.Size = new System.Drawing.Size(82, 37);
            this.btnPDF.TabIndex = 17;
            this.btnPDF.Text = "PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnEkspertyza
            // 
            this.btnEkspertyza.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEkspertyza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkspertyza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEkspertyza.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEkspertyza.Image = global::Poltrone_Electronics.Properties.Resources.ekspertyza;
            this.btnEkspertyza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkspertyza.Location = new System.Drawing.Point(570, 441);
            this.btnEkspertyza.Name = "btnEkspertyza";
            this.btnEkspertyza.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEkspertyza.Size = new System.Drawing.Size(130, 37);
            this.btnEkspertyza.TabIndex = 16;
            this.btnEkspertyza.Text = "Ekspertyza";
            this.btnEkspertyza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkspertyza.UseVisualStyleBackColor = false;
            this.btnEkspertyza.Click += new System.EventHandler(this.btnEkspertyza_Click);
            // 
            // btnZdjecia
            // 
            this.btnZdjecia.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnZdjecia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZdjecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZdjecia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZdjecia.Image = global::Poltrone_Electronics.Properties.Resources.Pictures_icon;
            this.btnZdjecia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZdjecia.Location = new System.Drawing.Point(462, 441);
            this.btnZdjecia.Name = "btnZdjecia";
            this.btnZdjecia.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnZdjecia.Size = new System.Drawing.Size(98, 37);
            this.btnZdjecia.TabIndex = 12;
            this.btnZdjecia.Text = "Zdjęcia";
            this.btnZdjecia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZdjecia.UseVisualStyleBackColor = false;
            this.btnZdjecia.Click += new System.EventHandler(this.btnZdjecia_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEdytuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdytuj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdytuj.Image = global::Poltrone_Electronics.Properties.Resources.edit_icon;
            this.btnEdytuj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdytuj.Location = new System.Drawing.Point(174, 441);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEdytuj.Size = new System.Drawing.Size(161, 37);
            this.btnEdytuj.TabIndex = 7;
            this.btnEdytuj.Text = "Edytuj zlecenie";
            this.btnEdytuj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdytuj.UseVisualStyleBackColor = false;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodaj.Image = global::Poltrone_Electronics.Properties.Resources.add_1_icon;
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.Location = new System.Drawing.Point(6, 441);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDodaj.Size = new System.Drawing.Size(158, 37);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj zlecenie";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZamknij.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZamknij.Image = global::Poltrone_Electronics.Properties.Resources.Close_2_icon;
            this.btnZamknij.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamknij.Location = new System.Drawing.Point(345, 441);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnZamknij.Size = new System.Drawing.Size(107, 37);
            this.btnZamknij.TabIndex = 5;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZamknij.UseVisualStyleBackColor = false;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // lblZalogowany
            // 
            this.lblZalogowany.AutoSize = true;
            this.lblZalogowany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblZalogowany.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblZalogowany.Location = new System.Drawing.Point(1044, 392);
            this.lblZalogowany.Name = "lblZalogowany";
            this.lblZalogowany.Size = new System.Drawing.Size(118, 15);
            this.lblZalogowany.TabIndex = 20;
            this.lblZalogowany.Text = "Zalogowany jako:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogin.Location = new System.Drawing.Point(1074, 410);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 15);
            this.lblLogin.TabIndex = 21;
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1184, 490);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblZalogowany);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnEkspertyza);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZdjecia);
            this.Controls.Add(this.tbWyszukaj);
            this.Controls.Add(this.lblTypUrzadzenia);
            this.Controls.Add(this.cbFiltruj);
            this.Controls.Add(this.lblFiltruj);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.dgrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OknoGlowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poltrone Electronics - wersja 1.0 PL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OknoGlowne_FormClosed);
            this.Shown += new System.EventHandler(this.OknoGlowne_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Label lblFiltruj;
        private System.Windows.Forms.ComboBox cbFiltruj;
        private System.Windows.Forms.ToolStripMenuItem klienciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaKlientówToolStripMenuItem;
        private System.Windows.Forms.TextBox tbWyszukaj;
        private System.Windows.Forms.Label lblTypUrzadzenia;
        private System.Windows.Forms.Button btnZdjecia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ToolStripMenuItem zlecenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajZlecenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujZlecenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zdjęciaToolStripMenuItem;
        private System.Windows.Forms.Button btnEkspertyza;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblZalogowany;
        private System.Windows.Forms.Label lblLogin;
    }
}