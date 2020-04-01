namespace Poltrone_Electronics
{
    partial class ListaKlientow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaKlientow));
            this.lblTypUrzadzenia = new System.Windows.Forms.Label();
            this.tbWyszukaj = new System.Windows.Forms.TextBox();
            this.dgKlienci = new System.Windows.Forms.DataGridView();
            this.btnDodajZlecenie = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKlienci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTypUrzadzenia
            // 
            this.lblTypUrzadzenia.AutoSize = true;
            this.lblTypUrzadzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTypUrzadzenia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTypUrzadzenia.Location = new System.Drawing.Point(12, 13);
            this.lblTypUrzadzenia.Name = "lblTypUrzadzenia";
            this.lblTypUrzadzenia.Size = new System.Drawing.Size(103, 24);
            this.lblTypUrzadzenia.TabIndex = 2;
            this.lblTypUrzadzenia.Text = "Wyszukaj:";
            // 
            // tbWyszukaj
            // 
            this.tbWyszukaj.BackColor = System.Drawing.Color.BurlyWood;
            this.tbWyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbWyszukaj.ForeColor = System.Drawing.Color.DarkRed;
            this.tbWyszukaj.Location = new System.Drawing.Point(121, 11);
            this.tbWyszukaj.MaxLength = 80;
            this.tbWyszukaj.Name = "tbWyszukaj";
            this.tbWyszukaj.Size = new System.Drawing.Size(294, 29);
            this.tbWyszukaj.TabIndex = 5;
            this.tbWyszukaj.TextChanged += new System.EventHandler(this.tbWyszukaj_TextChanged);
            // 
            // dgKlienci
            // 
            this.dgKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKlienci.Location = new System.Drawing.Point(0, 44);
            this.dgKlienci.Name = "dgKlienci";
            this.dgKlienci.Size = new System.Drawing.Size(1285, 499);
            this.dgKlienci.TabIndex = 6;
            this.dgKlienci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKlienci_CellClick);
            // 
            // btnDodajZlecenie
            // 
            this.btnDodajZlecenie.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDodajZlecenie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajZlecenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajZlecenie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajZlecenie.Image = global::Poltrone_Electronics.Properties.Resources.edit_icon;
            this.btnDodajZlecenie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajZlecenie.Location = new System.Drawing.Point(179, 560);
            this.btnDodajZlecenie.Name = "btnDodajZlecenie";
            this.btnDodajZlecenie.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDodajZlecenie.Size = new System.Drawing.Size(151, 37);
            this.btnDodajZlecenie.TabIndex = 49;
            this.btnDodajZlecenie.Text = "Edytuj klienta";
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
            this.btnZamknij.Location = new System.Drawing.Point(343, 560);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnZamknij.Size = new System.Drawing.Size(107, 37);
            this.btnZamknij.TabIndex = 48;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZamknij.UseVisualStyleBackColor = false;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodaj.Image = global::Poltrone_Electronics.Properties.Resources.add_1_icon;
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.Location = new System.Drawing.Point(16, 560);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDodaj.Size = new System.Drawing.Size(150, 37);
            this.btnDodaj.TabIndex = 50;
            this.btnDodaj.Text = "Dodaj klienta";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ListaKlientow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1284, 612);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnDodajZlecenie);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.dgKlienci);
            this.Controls.Add(this.tbWyszukaj);
            this.Controls.Add(this.lblTypUrzadzenia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaKlientow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poltrone Electronics - Lista klientów";
            this.Activated += new System.EventHandler(this.ListaKlientow_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgKlienci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypUrzadzenia;
        private System.Windows.Forms.TextBox tbWyszukaj;
        private System.Windows.Forms.DataGridView dgKlienci;
        private System.Windows.Forms.Button btnDodajZlecenie;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnDodaj;
    }
}