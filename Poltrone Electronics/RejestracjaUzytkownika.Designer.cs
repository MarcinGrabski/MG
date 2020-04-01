namespace Poltrone_Electronics
{
    partial class RejestracjaUzytkownika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RejestracjaUzytkownika));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.haslo_tb = new System.Windows.Forms.TextBox();
            this.haslo2_tb = new System.Windows.Forms.TextBox();
            this.btnRejestruj = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(79, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(73, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Powtórz hasło:";
            // 
            // logo
            // 
            this.logo.Image = global::Poltrone_Electronics.Properties.Resources.POLTRONE_LOGO_kwadrat;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(169, 162);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // login_tb
            // 
            this.login_tb.BackColor = System.Drawing.Color.BurlyWood;
            this.login_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_tb.ForeColor = System.Drawing.Color.DarkRed;
            this.login_tb.Location = new System.Drawing.Point(149, 30);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(145, 22);
            this.login_tb.TabIndex = 4;
            // 
            // haslo_tb
            // 
            this.haslo_tb.BackColor = System.Drawing.Color.BurlyWood;
            this.haslo_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo_tb.ForeColor = System.Drawing.Color.DarkRed;
            this.haslo_tb.Location = new System.Drawing.Point(149, 63);
            this.haslo_tb.Name = "haslo_tb";
            this.haslo_tb.PasswordChar = '*';
            this.haslo_tb.Size = new System.Drawing.Size(145, 22);
            this.haslo_tb.TabIndex = 5;
            // 
            // haslo2_tb
            // 
            this.haslo2_tb.BackColor = System.Drawing.Color.BurlyWood;
            this.haslo2_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haslo2_tb.ForeColor = System.Drawing.Color.DarkRed;
            this.haslo2_tb.Location = new System.Drawing.Point(149, 95);
            this.haslo2_tb.Name = "haslo2_tb";
            this.haslo2_tb.PasswordChar = '*';
            this.haslo2_tb.Size = new System.Drawing.Size(145, 22);
            this.haslo2_tb.TabIndex = 6;
            // 
            // btnRejestruj
            // 
            this.btnRejestruj.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRejestruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRejestruj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRejestruj.Image = global::Poltrone_Electronics.Properties.Resources.Ok_icon;
            this.btnRejestruj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRejestruj.Location = new System.Drawing.Point(191, 164);
            this.btnRejestruj.Name = "btnRejestruj";
            this.btnRejestruj.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRejestruj.Size = new System.Drawing.Size(115, 37);
            this.btnRejestruj.TabIndex = 7;
            this.btnRejestruj.Text = "Rejestruj";
            this.btnRejestruj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRejestruj.UseVisualStyleBackColor = false;
            this.btnRejestruj.Click += new System.EventHandler(this.btnRejestruj_Click);
            this.btnRejestruj.MouseLeave += new System.EventHandler(this.btnRejestruj_MouseLeave);
            this.btnRejestruj.MouseHover += new System.EventHandler(this.btnRejestruj_MouseHover);
            // 
            // btnZamknij
            // 
            this.btnZamknij.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZamknij.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZamknij.Image = global::Poltrone_Electronics.Properties.Resources.Close_2_icon;
            this.btnZamknij.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamknij.Location = new System.Drawing.Point(424, 164);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnZamknij.Size = new System.Drawing.Size(107, 37);
            this.btnZamknij.TabIndex = 9;
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
            this.btnWyczysc.Location = new System.Drawing.Point(312, 164);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnWyczysc.Size = new System.Drawing.Size(106, 37);
            this.btnWyczysc.TabIndex = 8;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWyczysc.UseVisualStyleBackColor = false;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            this.btnWyczysc.MouseLeave += new System.EventHandler(this.btnWyczysc_MouseLeave);
            this.btnWyczysc.MouseHover += new System.EventHandler(this.btnWyczysc_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.haslo_tb);
            this.groupBox1.Controls.Add(this.login_tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.haslo2_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(201, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 138);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rejestracja użytkownika";
            // 
            // RejestracjaUzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(560, 213);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnWyczysc);
            this.Controls.Add(this.btnRejestruj);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RejestracjaUzytkownika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poltrone Electronics - Rejestracja uzytkownika";
            this.Load += new System.EventHandler(this.RejestracjaUzytkownika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox haslo_tb;
        private System.Windows.Forms.TextBox haslo2_tb;
        private System.Windows.Forms.Button btnRejestruj;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}