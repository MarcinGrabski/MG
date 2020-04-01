using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Poltrone_Electronics
{
    public partial class ListaKlientow : Form
    {
        #region Zmienne        

        SqlConnection polaczenie = new SqlConnection("Data Source=DESKTOP-GRQCQK4\\SQLEXPRESS; Initial Catalog=poltrone; Integrated Security=True;");
        SqlCommand komenda;
        SqlDataReader czytnik;

        string zapytanie = "";

        int rowIndex = 0;

        #endregion

        public ListaKlientow()
        {
            InitializeComponent();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaKlientow_Activated(object sender, EventArgs e)
        {
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT osoba, firma, adres, nip, regon, tel_stacjonarny, tel_komorkowy, fax, email FROM klienci");
                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                if (czytnik.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(czytnik);
                    dgKlienci.DataSource = dt;
                }
                czytnik.Close();

                // zmiana nazw nagłówków kolumn
                dgKlienci.Columns[0].HeaderText = "Osoba";
                dgKlienci.Columns[1].HeaderText = "Firma";
                dgKlienci.Columns[2].HeaderText = "Adres";
                dgKlienci.Columns[3].HeaderText = "NIP";
                dgKlienci.Columns[4].HeaderText = "REGON";
                dgKlienci.Columns[5].HeaderText = "Tel. stacjonarny";
                dgKlienci.Columns[6].HeaderText = "Tel. komórkowy";
                dgKlienci.Columns[7].HeaderText = "Fax";
                dgKlienci.Columns[8].HeaderText = "Email";

                // zmiana szerokości wybranych kolumn
                dgKlienci.Columns[0].Width = 150;
                dgKlienci.Columns[1].Width = 200;
                dgKlienci.Columns[2].Width = 200;
                dgKlienci.Columns[3].Width = 80;
                dgKlienci.Columns[4].Width = 80;
                dgKlienci.Columns[5].Width = 80;
                dgKlienci.Columns[6].Width = 90;
                dgKlienci.Columns[7].Width = 80;
                dgKlienci.Columns[8].Width = 200;

                // pogrubienie nagłówków i wyśrodkowanie treści
                DataGridViewCellStyle styl = new DataGridViewCellStyle();
                styl.Font = new Font(this.Font, FontStyle.Bold);
                styl.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i <= 8; i++)
                {
                    dgKlienci.Columns[i].HeaderCell.Style = styl;
                }


            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę załadować listy klientów:\n {0}", ex.Message);
                MessageBox.Show(byk, "Błąd ładowania klientów", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void tbWyszukaj_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT osoba, firma, adres, nip, regon, tel_stacjonarny, tel_komorkowy, fax, email FROM klienci WHERE osoba LIKE '%{0}%' OR firma LIKE '%{0}%' OR adres LIKE '%{0}%' OR nip LIKE '%{0}%' OR regon LIKE '%{0}%' OR tel_stacjonarny LIKE '%{0}%' OR tel_komorkowy LIKE '%{0}%' OR fax LIKE '%{0}%' OR email LIKE '%{0}%'", tbWyszukaj.Text);
                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                if (czytnik.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(czytnik);
                    dgKlienci.DataSource = dt;
                }
                czytnik.Close();

                // zmiana nazw nagłówków kolumn
                dgKlienci.Columns[0].HeaderText = "Osoba";
                dgKlienci.Columns[1].HeaderText = "Firma";
                dgKlienci.Columns[2].HeaderText = "Adres";
                dgKlienci.Columns[3].HeaderText = "NIP";
                dgKlienci.Columns[4].HeaderText = "REGON";
                dgKlienci.Columns[5].HeaderText = "Tel. stacjonarny";
                dgKlienci.Columns[6].HeaderText = "Tel. komórkowy";
                dgKlienci.Columns[7].HeaderText = "Fax";
                dgKlienci.Columns[8].HeaderText = "Email";

                // zmiana szerokości wybranych kolumn
                dgKlienci.Columns[0].Width = 150;
                dgKlienci.Columns[1].Width = 200;
                dgKlienci.Columns[2].Width = 200;
                dgKlienci.Columns[3].Width = 80;
                dgKlienci.Columns[4].Width = 80;
                dgKlienci.Columns[5].Width = 80;
                dgKlienci.Columns[6].Width = 90;
                dgKlienci.Columns[7].Width = 80;
                dgKlienci.Columns[8].Width = 200;

                // pogrubienie nagłówków i wyśrodkowanie treści
                DataGridViewCellStyle styl = new DataGridViewCellStyle();
                styl.Font = new Font(this.Font, FontStyle.Bold);
                styl.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i <= 8; i++)
                {
                    dgKlienci.Columns[i].HeaderCell.Style = styl;
                }


            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę wyszukać klientów:\n {0}", ex.Message);
                MessageBox.Show(byk, "Błąd ładowania klientów", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajKlienta okno = new DodajKlienta();
            okno.ShowDialog();
        }

        private void dgKlienci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void btnDodajZlecenie_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgKlienci.Rows[rowIndex];
            string osoba = row.Cells[0].Value.ToString();
            string firma = row.Cells[1].Value.ToString();
            string adres = row.Cells[2].Value.ToString();
            string nip = row.Cells[3].Value.ToString();
            string regon = row.Cells[4].Value.ToString();
            string tel_stacjonarny = row.Cells[5].Value.ToString();
            string tel_komorkowy = row.Cells[6].Value.ToString();
            string fax = row.Cells[7].Value.ToString();
            string email = row.Cells[8].Value.ToString();
            DodajKlienta okno = new DodajKlienta(osoba, firma, adres, nip, regon, tel_stacjonarny, tel_komorkowy, fax, email);
            okno.ShowDialog();
        }
    }
}