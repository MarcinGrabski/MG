namespace Poltrone_Electronics
{
    partial class Zdjecia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zdjecia));
            this.listaZdjec = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.zdjecie = new System.Windows.Forms.PictureBox();
            this.lblOsoba = new System.Windows.Forms.Label();
            this.tbNazwaZdjecia = new System.Windows.Forms.TextBox();
            this.btnZamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zdjecie)).BeginInit();
            this.SuspendLayout();
            // 
            // listaZdjec
            // 
            this.listaZdjec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listaZdjec.GridLines = true;
            this.listaZdjec.Location = new System.Drawing.Point(503, 163);
            this.listaZdjec.MultiSelect = false;
            this.listaZdjec.Name = "listaZdjec";
            this.listaZdjec.Size = new System.Drawing.Size(263, 312);
            this.listaZdjec.TabIndex = 10;
            this.listaZdjec.UseCompatibleStateImageBehavior = false;
            this.listaZdjec.View = System.Windows.Forms.View.Details;
            this.listaZdjec.SelectedIndexChanged += new System.EventHandler(this.listaZdjec_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa pliku";
            this.columnHeader1.Width = 239;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpen.Image = global::Poltrone_Electronics.Properties.Resources.Folder_Open_icon;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(503, 23);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnOpen.Size = new System.Drawing.Size(162, 37);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Otwórz zdjęcie";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Image = global::Poltrone_Electronics.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(503, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(162, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Zapisz zdjęcie";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // zdjecie
            // 
            this.zdjecie.Location = new System.Drawing.Point(12, 23);
            this.zdjecie.Name = "zdjecie";
            this.zdjecie.Size = new System.Drawing.Size(467, 541);
            this.zdjecie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zdjecie.TabIndex = 0;
            this.zdjecie.TabStop = false;
            // 
            // lblOsoba
            // 
            this.lblOsoba.AutoSize = true;
            this.lblOsoba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOsoba.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOsoba.Location = new System.Drawing.Point(500, 129);
            this.lblOsoba.Name = "lblOsoba";
            this.lblOsoba.Size = new System.Drawing.Size(112, 16);
            this.lblOsoba.TabIndex = 12;
            this.lblOsoba.Text = "Nazwa zdjęcia:";
            // 
            // tbNazwaZdjecia
            // 
            this.tbNazwaZdjecia.BackColor = System.Drawing.Color.BurlyWood;
            this.tbNazwaZdjecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNazwaZdjecia.ForeColor = System.Drawing.Color.DarkRed;
            this.tbNazwaZdjecia.Location = new System.Drawing.Point(618, 126);
            this.tbNazwaZdjecia.MaxLength = 80;
            this.tbNazwaZdjecia.Name = "tbNazwaZdjecia";
            this.tbNazwaZdjecia.Size = new System.Drawing.Size(225, 22);
            this.tbNazwaZdjecia.TabIndex = 13;
            // 
            // btnZamknij
            // 
            this.btnZamknij.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZamknij.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZamknij.Image = global::Poltrone_Electronics.Properties.Resources.Close_2_icon;
            this.btnZamknij.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamknij.Location = new System.Drawing.Point(503, 498);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnZamknij.Size = new System.Drawing.Size(107, 37);
            this.btnZamknij.TabIndex = 49;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZamknij.UseVisualStyleBackColor = false;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // Zdjecia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(929, 596);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.tbNazwaZdjecia);
            this.Controls.Add(this.lblOsoba);
            this.Controls.Add(this.listaZdjec);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.zdjecie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zdjecia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poltrone Electronics - Zdjęcia";
            this.Load += new System.EventHandler(this.Zdjecia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zdjecie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox zdjecie;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListView listaZdjec;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblOsoba;
        private System.Windows.Forms.TextBox tbNazwaZdjecia;
        private System.Windows.Forms.Button btnZamknij;
    }
}