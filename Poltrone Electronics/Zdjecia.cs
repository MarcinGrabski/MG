using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Poltrone_Electronics
{
    public partial class Zdjecia : Form
    {
        #region zmienne
        SqlConnection polaczenie = new SqlConnection("Data Source=DESKTOP-GRQCQK4\\SQLEXPRESS; Initial Catalog=poltrone; Integrated Security=True;");
        SqlCommand komenda;
        SqlDataReader czytnik;
        string zapytanie = "";

        int urzadzenie = 0;
        string nazwaPliku = "";
        #endregion

        public Zdjecia()
        {
            InitializeComponent();
        }

        public Zdjecia(int idurzadzenia)
        {
            InitializeComponent();
            urzadzenie = idurzadzenia;
        }

        private void Zdjecia_Load(object sender, EventArgs e)
        {
            OdswiezListe();
        }

        private void OdswiezListe()
        {
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT nazwa FROM zdjecia WHERE id_urzadzenia={0};", urzadzenie);

                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                listaZdjec.Items.Clear();

                if (czytnik.HasRows)
                {
                    while (czytnik.Read())
                    {
                        listaZdjec.Items.Add(czytnik.GetString(0));
                    }

                }
                czytnik.Close();                
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę pobrać listy zdjęć.\n {0}", ex.Message);
                MessageBox.Show(byk, "Błąd pobierania zdjęć", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki jpg (*.jpg) | *.jpg;*.JPG;*.jpeg;*.JPEG | Pliki png (*.png) | *.png;*.PNG | Wszystkie pliki (*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                nazwaPliku = dialog.FileName.ToString();
                zdjecie.ImageLocation = nazwaPliku;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Streem = new FileStream(nazwaPliku, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);

            try
            {
                if (tbNazwaZdjecia.Text.Length > 0)
                {
                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();

                    zapytanie = string.Format("INSERT INTO zdjecia (id_urzadzenia, nazwa, zdjecie) VALUES({0}, '{1}', @images);", urzadzenie, tbNazwaZdjecia.Text);

                    komenda = new SqlCommand(zapytanie, polaczenie);
                    komenda.Parameters.Add(new SqlParameter("@images", images));
                    komenda.ExecuteNonQuery();
                    MessageBox.Show("Dodano zdjęcie do bazy", "Dodawanie zdjęcia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OdswiezListe();
                    tbNazwaZdjecia.Clear();
                } else
                {
                    MessageBox.Show("Musisz podać nazwę zdjęcia", "Brak nazwy zdjęcia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {                
                    string byk = string.Format("Nie mogę dodać zdjęcia do bazy danych.\n {0}", ex.Message);
                    MessageBox.Show(byk, "Błąd dodawania zdjęcia", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void listaZdjec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaZdjec.FocusedItem != null)
            {
                tbNazwaZdjecia.Text = listaZdjec.FocusedItem.SubItems[0].Text;
            }

            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT zdjecie FROM zdjecia WHERE nazwa='{0}' AND id_urzadzenia={1};", tbNazwaZdjecia.Text, urzadzenie);

                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                if (czytnik.HasRows)
                {
                    while (czytnik.Read())
                    {
                        byte[] images = ((byte[])czytnik[0]);

                        if (images == null)
                        {
                            zdjecie.Image = null;
                        }
                        else
                        {
                            MemoryStream mstream = new MemoryStream(images);
                            zdjecie.Image = Image.FromStream(mstream);
                        }
                    }
                }
                czytnik.Close();
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę wyświetlić zdjęcia.\n {0}", ex.Message);
                MessageBox.Show(byk, "Błąd wyśietlania zdjęcia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}