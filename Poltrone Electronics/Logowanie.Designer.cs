namespace Poltrone_Electronics
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.haslo_tb = new System.Windows.Forms.TextBox();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.lblLogowanie = new System.Windows.Forms.Label();
            this.dodajUzytkownika_lbl = new System.Windows.Forms.Label();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.haslo_tb);
            this.groupBox1.Controls.Add(this.login_tb);
            this.groupBox1.Controls.Add(this.lblHaslo);
            this.groupBox1.Controls.Add(this.lblLogowanie);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(187, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logowanie do systemu:";
            // 
            // haslo_tb
            // 
            this.haslo_tb.BackColor = System.Drawing.Color.BurlyWood;
            this.haslo_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo_tb.ForeColor = System.Drawing.Color.DarkRed;
            this.haslo_tb.Location = new System.Drawing.Point(80, 73);
            this.haslo_tb.Name = "haslo_tb";
            this.haslo_tb.PasswordChar = '*';
            this.haslo_tb.Size = new System.Drawing.Size(145, 22);
            this.haslo_tb.TabIndex = 3;
            // 
            // login_tb
            // 
            this.login_tb.BackColor = System.Drawing.Color.BurlyWood;
            this.login_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_tb.ForeColor = System.Drawing.Color.DarkRed;
            this.login_tb.Location = new System.Drawing.Point(80, 33);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(145, 22);
            this.login_tb.TabIndex = 2;
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHaslo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHaslo.Location = new System.Drawing.Point(24, 76);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(56, 16);
            this.lblHaslo.TabIndex = 1;
            this.lblHaslo.Text = "Hasło:";
            // 
            // lblLogowanie
            // 
            this.lblLogowanie.AutoSize = true;
            this.lblLogowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogowanie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogowanie.Location = new System.Drawing.Point(24, 36);
            this.lblLogowanie.Name = "lblLogowanie";
            this.lblLogowanie.Size = new System.Drawing.Size(50, 16);
            this.lblLogowanie.TabIndex = 0;
            this.lblLogowanie.Text = "Login:";
            // 
            // dodajUzytkownika_lbl
            // 
            this.dodajUzytkownika_lbl.AutoSize = true;
            this.dodajUzytkownika_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajUzytkownika_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajUzytkownika_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dodajUzytkownika_lbl.Location = new System.Drawing.Point(9, 194);
            this.dodajUzytkownika_lbl.Name = "dodajUzytkownika_lbl";
            this.dodajUzytkownika_lbl.Size = new System.Drawing.Size(137, 16);
            this.dodajUzytkownika_lbl.TabIndex = 5;
            this.dodajUzytkownika_lbl.Text = "Dodaj użytkownika";
            this.dodajUzytkownika_lbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dodajUzytkownika_lbl_MouseClick);
            // 
            // btnZamknij
            // 
            this.btnZamknij.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZamknij.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZamknij.Image = global::Poltrone_Electronics.Properties.Resources.Close_2_icon;
            this.btnZamknij.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamknij.Location = new System.Drawing.Point(408, 173);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnZamknij.Size = new System.Drawing.Size(107, 37);
            this.btnZamknij.TabIndex = 4;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZamknij.UseVisualStyleBackColor = false;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            this.btnZamknij.MouseLeave += new System.EventHandler(this.btnZamknij_MouseLeave);
            this.btnZamknij.MouseHover += new System.EventHandler(this.btnZamknij_MouseHover);
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnWyczysc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWyczysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyczysc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWyczysc.Image = global::Poltrone_Electronics.Properties.Resources.Clear_icon;
            this.btnWyczysc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWyczysc.Location = new System.Drawing.Point(296, 173);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnWyczysc.Size = new System.Drawing.Size(106, 37);
            this.btnWyczysc.TabIndex = 3;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWyczysc.UseVisualStyleBackColor = false;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            this.btnWyczysc.MouseLeave += new System.EventHandler(this.btnWyczysc_MouseLeave);
            this.btnWyczysc.MouseHover += new System.EventHandler(this.btnWyczysc_MouseHover);
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnZaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaloguj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZaloguj.Image = global::Poltrone_Electronics.Properties.Resources.Ok_icon;
            this.btnZaloguj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZaloguj.Location = new System.Drawing.Point(187, 173);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnZaloguj.Size = new System.Drawing.Size(103, 37);
            this.btnZaloguj.TabIndex = 2;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZaloguj.UseVisualStyleBackColor = false;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            this.btnZaloguj.MouseLeave += new System.EventHandler(this.btnZaloguj_MouseLeave);
            this.btnZaloguj.MouseHover += new System.EventHandler(this.btnZaloguj_MouseHover);
            // 
            // logo
            // 
            this.logo.Image = global::Poltrone_Electronics.Properties.Resources.POLTRONE_LOGO_kwadrat;
            this.logo.Location = new System.Drawing.Point(12, 21);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(169, 162);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(528, 238);
            this.ControlBox = false;
            this.Controls.Add(this.dodajUzytkownika_lbl);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnWyczysc);
            this.Controls.Add(this.btnZaloguj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poltrone Electronics - Logowanie";
            this.Activated += new System.EventHandler(this.Logowanie_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox haslo_tb;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Label lblLogowanie;
        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Label dodajUzytkownika_lbl;
    }
}

