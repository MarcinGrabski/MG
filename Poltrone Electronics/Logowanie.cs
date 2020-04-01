using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Poltrone_Electronics
{
    public partial class Logowanie : Form
    {
        #region Zmienne
        SqlConnection polaczenie = new SqlConnection("Data Source=DESKTOP-GRQCQK4\\SQLEXPRESS; Initial Catalog=poltrone; Integrated Security=True;");
        SqlCommand komenda;        

        string zapytanie = "";
        #endregion

        public Logowanie()
        {
            InitializeComponent();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            WyczyscPola();
        }

        private void btnZaloguj_MouseHover(object sender, EventArgs e)
        {
            btnZaloguj.ForeColor = Color.SkyBlue;
        }

        private void btnZaloguj_MouseLeave(object sender, EventArgs e)
        {
            btnZaloguj.ForeColor = SystemColors.ButtonFace;
        }

        private void btnWyczysc_MouseHover(object sender, EventArgs e)
        {
            btnWyczysc.ForeColor = Color.SkyBlue;
        }

        private void btnWyczysc_MouseLeave(object sender, EventArgs e)
        {
            btnWyczysc.ForeColor = SystemColors.ButtonFace;
        }

        private void btnZamknij_MouseHover(object sender, EventArgs e)
        {
            btnZamknij.ForeColor = Color.SkyBlue;
        }

        private void btnZamknij_MouseLeave(object sender, EventArgs e)
        {
            btnZamknij.ForeColor = SystemColors.ButtonFace;
        }

        private void dodajUzytkownika_lbl_MouseClick(object sender, MouseEventArgs e)
        {
            RejestracjaUzytkownika rejestracja = new RejestracjaUzytkownika();
            rejestracja.ShowDialog();
        }

        public void WyczyscPola()
        {
            login_tb.Clear();
            haslo_tb.Clear();
            login_tb.Select();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                string haslo = "";
                using (MD5 hash = MD5.Create())
                {
                    haslo = GetMD5Hash(hash, haslo_tb.Text);
                }

                zapytanie = string.Format("SELECT count(id_uzytkownika) FROM uzytkownicy WHERE login='{0}' AND haslo='{1}'", login_tb.Text, haslo);
                komenda = new SqlCommand(zapytanie, polaczenie);
                int wartosc = Convert.ToInt32(komenda.ExecuteScalar());

                if (wartosc == 0)
                {
                    MessageBox.Show("Brak takiego użytkownika w bazie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    OknoGlowne glowne = new OknoGlowne(this,login_tb.Text);
                    glowne.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                string byk = string.Format("Problem podczas logowania:\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                polaczenie.Close();
            }            
        }

        string GetMD5Hash(MD5 md5hash, string input)
        {
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private void Logowanie_Activated(object sender, EventArgs e)
        {
            WyczyscPola();
        }
    }
}