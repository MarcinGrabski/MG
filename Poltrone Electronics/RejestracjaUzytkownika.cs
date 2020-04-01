using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Poltrone_Electronics
{
    public partial class RejestracjaUzytkownika : Form
    {
        #region Zmienne
        SqlConnection polaczenie = new SqlConnection("Data Source=DESKTOP-GRQCQK4\\SQLEXPRESS; Initial Catalog=poltrone; Integrated Security=True;");
        SqlCommand komenda;

        string zapytanie = "";
        #endregion

        public RejestracjaUzytkownika()
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

        public void WyczyscPola()
        {
            login_tb.Clear();
            haslo_tb.Clear();
            haslo2_tb.Clear();
            login_tb.Select();
        }

        private void btnRejestruj_MouseHover(object sender, EventArgs e)
        {
            btnRejestruj.ForeColor = Color.SkyBlue;
        }

        private void btnWyczysc_MouseHover(object sender, EventArgs e)
        {
            btnWyczysc.ForeColor = Color.SkyBlue;
        }

        private void btnZamknij_MouseHover(object sender, EventArgs e)
        {
            btnZamknij.ForeColor = Color.SkyBlue;
        }

        private void btnZamknij_MouseLeave(object sender, EventArgs e)
        {
            btnZamknij.ForeColor = SystemColors.ButtonFace;
        }

        private void btnWyczysc_MouseLeave(object sender, EventArgs e)
        {
            btnWyczysc.ForeColor = SystemColors.ButtonFace;
        }

        private void btnRejestruj_MouseLeave(object sender, EventArgs e)
        {
            btnRejestruj.ForeColor = SystemColors.ButtonFace;
        }

        private void btnRejestruj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_tb.Text) || string.IsNullOrWhiteSpace(haslo_tb.Text) || string.IsNullOrWhiteSpace(haslo2_tb.Text))
            {
                MessageBox.Show("Login i hasło muszą być podane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (login_tb.TextLength < 5 || haslo_tb.TextLength < 5 || haslo2_tb.TextLength < 5)
            {
                MessageBox.Show("Login i hasła muszą mieć więcej niż 5 znaków", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!string.Equals(haslo_tb.Text, haslo2_tb.Text)) {
                MessageBox.Show("Hasła muszą być takie same", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Rejestracja(login_tb.Text, haslo_tb.Text, "tak", DateTime.Now.ToString("yyyy-MM-dd"));
            }
        }

        void Rejestracja(string login, string haslo, string aktywny, string dataRejestracji)
        {
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                // Sprawdzenie czy użytkownik istnieje w bazie danych
                zapytanie = string.Format("SELECT count(id_uzytkownika) FROM uzytkownicy where login = '{0}'", login);
                komenda = new SqlCommand(zapytanie, polaczenie);
                int wartosc = Convert.ToInt32(komenda.ExecuteScalar());

                if (wartosc == 1)
                {
                    MessageBox.Show(string.Format("Użytkownik z loginem '{0}' już istnieje.", login), "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    login_tb.Select();
                } else
                {
                    using(MD5 hash = MD5.Create())
                    {
                        haslo = GetMD5Hash(hash, haslo);
                    }
                    zapytanie = string.Format("INSERT INTO uzytkownicy(login, haslo, aktywny, dataRejestracji) VALUES('{0}', '{1}', '{2}', '{3}')", login, haslo, aktywny, dataRejestracji);
                    komenda = new SqlCommand(zapytanie, polaczenie);
                    komenda.ExecuteNonQuery();

                    MessageBox.Show("Użytkownik dodany", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WyczyscPola();
                    this.Close();
                }
            } catch (Exception ex)
            {
                string byk = string.Format("Problem podczas rejestracji użytkownika:\n{0}",ex.Message);
                MessageBox.Show(byk, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void RejestracjaUzytkownika_Load(object sender, EventArgs e)
        {
            login_tb.Select();
        }
    }
}