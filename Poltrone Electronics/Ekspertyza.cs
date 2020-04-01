using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Poltrone_Electronics
{
    public partial class Ekspertyza : Form
    {
        #region Zmienne
        SqlConnection polaczenie = new SqlConnection("Data Source=DESKTOP-GRQCQK4\\SQLEXPRESS; Initial Catalog=poltrone; Integrated Security=True;");
        SqlCommand komenda;
        SqlDataReader czytnik;

        string zapytanie = "";
        int zlecenie = 0, czyEkspertyza = 0;
        #endregion

        public Ekspertyza()
        {
            InitializeComponent();
        }

        public Ekspertyza(int nrZlecenia)
        {
            InitializeComponent();
            zlecenie = nrZlecenia;
        }

        private void Ekspertyza_Load(object sender, EventArgs e)
        {
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT count(*) FROM czynnosci WHERE id_zlecenia={0}",zlecenie);
                komenda = new SqlCommand(zapytanie, polaczenie);
                czyEkspertyza = Convert.ToInt32(komenda.ExecuteScalar());

                if (czyEkspertyza == 0)
                {
                    btnDodajEkspertyze.Text = "Dodaj ekspertyzę";
                } else
                {
                    btnDodajEkspertyze.Text = "Uaktualnij dane";
                }
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę sprawdzić czy jest ekspertyza.\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd sprawdzania ekspertyzy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }

            // pobranie danych ekspertyzy
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT ekspertyza, system, podzespoly, pasty, test_urzadzenia, czyszczenie, test_dysku, zauwazone_usterki FROM czynnosci WHERE id_zlecenia = {0}", zlecenie);
                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                if (czytnik.HasRows)
                {
                    while (czytnik.Read())
                    {
                        tbEkspertyza.Text = czytnik.GetString(0);
                        cbSystem.Text = czytnik.GetString(1);
                        tbPodzespoly.Text = czytnik.GetString(2);
                        cbPasty.Text = czytnik.GetString(3);
                        cbTestUrzadzenia.Text = czytnik.GetString(4);
                        cbCzyszczenie.Text = czytnik.GetString(5);
                        cbTestDysku.Text = czytnik.GetString(6);
                        tbZauwazoneUsterki.Text = czytnik.GetString(7);
                    }
                }
                czytnik.Close();

            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę pobrać danych ekspertyzy.\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd pobierania ekspertyzy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            tbEkspertyza.Clear();
            cbSystem.Text = "Nie";
            tbPodzespoly.Text = "Nie";
            cbPasty.Text = "Nie";
            cbTestUrzadzenia.Text = "Nie";
            cbCzyszczenie.Text = "Nie";
            cbTestDysku.Text = "Nie";
            tbZauwazoneUsterki.Clear();
            tbEkspertyza.Focus();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajEkspertyze_Click(object sender, EventArgs e)
        {
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                if (czyEkspertyza == 0)
                {
                    zapytanie = string.Format("INSERT INTO czynnosci(id_zlecenia, ekspertyza, system, podzespoly, pasty, test_urzadzenia, czyszczenie, test_dysku, zauwazone_usterki) VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');", zlecenie, tbEkspertyza.Text, cbSystem.Text, tbPodzespoly.Text, cbPasty.Text, cbTestUrzadzenia.Text, cbCzyszczenie.Text, cbTestDysku.Text, tbZauwazoneUsterki.Text);
                }
                else
                {
                    zapytanie = string.Format("UPDATE czynnosci SET id_zlecenia={0}, ekspertyza='{1}', system='{2}', podzespoly='{3}', pasty='{4}', test_urzadzenia='{5}', czyszczenie='{6}', test_dysku='{7}', zauwazone_usterki='{8}';", zlecenie, tbEkspertyza.Text, cbSystem.Text, tbPodzespoly.Text, cbPasty.Text, cbTestUrzadzenia.Text, cbCzyszczenie.Text, cbTestDysku.Text, tbZauwazoneUsterki.Text);
                }
                komenda = new SqlCommand(zapytanie, polaczenie);
                komenda.ExecuteNonQuery();
                if (czyEkspertyza == 0)
                {
                    MessageBox.Show("Poprawnie dodano ekspertyzę", "Dodawanie ekspertyzy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Poprawnie uaktualniono ekspertyzę", "Uaktualnianie ekspertyzy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                if (czyEkspertyza == 0)
                {
                    string byk = string.Format("Nie mogę dodać ekspertyzy.\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd dodawania ekspertyzy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string byk = string.Format("Nie mogę uaktualnić ekspertyzy.\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd uaktualniania ekspertyzy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                polaczenie.Close();
            }
        }
    }
}