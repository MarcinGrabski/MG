using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Poltrone_Electronics
{
    public partial class Zlecenie : Form
    {
        #region Zmienne
        SqlConnection polaczenie = new SqlConnection("Data Source=DESKTOP-GRQCQK4\\SQLEXPRESS; Initial Catalog=poltrone; Integrated Security=True;");
        SqlCommand komenda;
        SqlDataReader czytnik;

        string zapytanie = "";
        int zlecenie = 0, urzadzenie = 0, nrZlecenia = 0;
        #endregion

        public Zlecenie()
        {
            InitializeComponent();
        }

        public Zlecenie(string typ_urzadzenia, string marka, string model, string nr_seryjny, string imei, string procesor, string pamiec, string plyta_glowna, string dysk_twardy, string dyskSSD, string karta_graficzna, string zasilacz, string ekran, string system_operacyjny, string rysy, string plamy, string uszkodzenia, string uwagi, string opis_usterki, string data_zlecenia, string osoba, string firma, string typ_zlecenia, decimal cena_usluga, decimal cena_czesci, string gwarancja, int idurzadzenia, int nrZlec)
        {
            InitializeComponent();
            cbTypUrzadzenia.Text = typ_urzadzenia;
            cbMarka.Text = marka;
            cbModel.Text = model;
            tbNrSeryjny.Text = nr_seryjny;
            tbImei.Text = imei;
            tbProcesor.Text = procesor;
            cbPamiec.Text = pamiec;
            tbPlytaGlowna.Text = plyta_glowna;
            cbDyskTwardy.Text = dysk_twardy;
            cbDyskSSD.Text = dyskSSD;
            tbKartaGraficzna.Text = karta_graficzna;
            tbZasilacz.Text = zasilacz;
            tbEkran.Text = ekran;
            cbSystemOperacyjny.Text = system_operacyjny;
            cbRysy.Text = rysy;
            cbPlamy.Text = plamy;
            cbUszkodzenia.Text = uszkodzenia;
            tbOpisUsterki.Text = opis_usterki;
            tbUwagi.Text = uwagi;
            dtData.Text = data_zlecenia;
            urzadzenie = idurzadzenia;
            nrZlecenia = nrZlec;
            if (osoba.Length > 0)
            {
                chbOsoba.Checked = true;
                chbFirma.Checked = false;
                cbKlient.Text = osoba;
            }

            if (firma.Length > 0)
            {
                chbOsoba.Checked = false;
                chbFirma.Checked = true;
                cbKlient.Text = firma;
            }
            cbTypZlecenia.Text = typ_zlecenia;
            tbCenaCzesci.Text = Decimal.Round(cena_czesci, 2).ToString();
            tbCenaUsluga.Text = Decimal.Round(cena_usluga, 2).ToString();
            cbGwarancja.Text = gwarancja;

            // kontrola zlecenia
            zlecenie = 1;

            btnDodajZlecenie.Text = "Uaktualnij";
            btnDodajZlecenie.Location = new Point(54, 566);
            btnDodajZlecenie.Size = new Size(121, 37);
            btnDodajZlecenie.Image = global::Poltrone_Electronics.Properties.Resources.update_icon;
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            WyczyscPola();
        }

        void WyczyscPola()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Clear();
                }

                if (c is RichTextBox)
                {
                    ((RichTextBox)c).Clear();
                }
            }            
        }

        private void Zlecenie_Activated(object sender, EventArgs e)
        {
            if (chbFirma.Checked)
            {
                try
                {
                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();


                    zapytanie = "SELECT firma FROM klienci WHERE osoba is null ORDER BY firma";

                    komenda = new SqlCommand(zapytanie, polaczenie);
                    czytnik = komenda.ExecuteReader();

                    // wyczyszczenie pola z klientami
                    cbKlient.Items.Clear();

                    if (czytnik.HasRows)
                    {
                        while (czytnik.Read())
                        {
                            cbKlient.Items.Add(czytnik.GetString(0));
                        }
                    }
                    czytnik.Close();
                    cbKlient.Text = cbKlient.Items[0].ToString();
                }
                catch (Exception ex)
                {
                    string byk = string.Format("Nie mogę wybrać firmy\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd wybierania firmy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    polaczenie.Close();
                }
            }
            else if (chbOsoba.Checked)
            {
                try
                {
                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();


                    zapytanie = string.Format("SELECT osoba FROM klienci WHERE firma is null ORDER BY osoba");

                    komenda = new SqlCommand(zapytanie, polaczenie);
                    czytnik = komenda.ExecuteReader();

                    // wyczyszczenie pola z klientami
                    cbKlient.Items.Clear();

                    if (czytnik.HasRows)
                    {
                        while (czytnik.Read())
                        {
                            cbKlient.Items.Add(czytnik.GetString(0));
                        }
                    }
                    czytnik.Close();
                    cbKlient.Text = cbKlient.Items[0].ToString();
                }
                catch (Exception ex)
                {
                    string byk = string.Format("Nie mogę wybrać klienta\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd wybierania klienta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    polaczenie.Close();
                }
            }
        }

        private void cbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT model FROM modele WHERE marka='{0}'", cbMarka.Text);
                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                // wyczyszczenie pola z modelami
                cbModel.Items.Clear();

                if (czytnik.HasRows)
                {
                    while (czytnik.Read())
                    {
                        cbModel.Items.Add(czytnik.GetString(0));
                    }
                }
                czytnik.Close();
                cbModel.Text = cbModel.Items[0].ToString();

            } catch (Exception ex)
            {
                string byk = string.Format("Nie mogę wybrać modelu przedmiotu", ex.Message);
                MessageBox.Show(byk, "Błąd wybierania modelu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                polaczenie.Close();
            }
        }

        private void chbOsoba_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOsoba.Checked)
            {
                chbFirma.Checked = false;

                // pobranie danych klienta
                try
                {
                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();


                    zapytanie = string.Format("SELECT osoba FROM klienci WHERE firma is null ORDER BY osoba");

                    komenda = new SqlCommand(zapytanie, polaczenie);
                    czytnik = komenda.ExecuteReader();

                    // wyczyszczenie pola z klientami
                    cbKlient.Items.Clear();

                    if (czytnik.HasRows)
                    {
                        while (czytnik.Read())
                        {
                            cbKlient.Items.Add(czytnik.GetString(0));
                        }
                    }
                    czytnik.Close();
                    cbKlient.Text = cbKlient.Items[0].ToString();
                }
                catch (Exception ex)
                {
                    string byk = string.Format("Nie mogę wybrać klienta\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd wybierania klienta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    polaczenie.Close();
                }
            } else
            {
                chbFirma.Checked = true;
            }
        }

        private void chbFirma_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFirma.Checked)
            {
                chbOsoba.Checked = false;

                // pobranie danych klienta
                try
                {
                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();


                    zapytanie = "SELECT firma FROM klienci WHERE osoba is null ORDER BY firma";

                    komenda = new SqlCommand(zapytanie, polaczenie);
                    czytnik = komenda.ExecuteReader();

                    // wyczyszczenie pola z klientami
                    cbKlient.Items.Clear();

                    if (czytnik.HasRows)
                    {
                        while (czytnik.Read())
                        {
                            cbKlient.Items.Add(czytnik.GetString(0));
                        }
                    }
                    czytnik.Close();
                    cbKlient.Text = cbKlient.Items[0].ToString();
                }
                catch (Exception ex)
                {
                    string byk = string.Format("Nie mogę wybrać firmy\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd wybierania firmy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    polaczenie.Close();
                }
            } else
            {
                chbOsoba.Checked = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string zaznaczenie = "";
            if (chbOsoba.Checked)
                zaznaczenie = "osoba";
            if (chbFirma.Checked)
                zaznaczenie = "firma";

            DodajKlienta okno = new DodajKlienta(zaznaczenie);
            okno.ShowDialog();
        }

        private void Zlecenie_Shown(object sender, EventArgs e)
        {
            if (zlecenie == 0)
            {
                // pobranie danych marek
                try
                {
                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();


                    zapytanie = string.Format("SELECT distinct(marka) as marka FROM modele ORDER BY marka");

                    komenda = new SqlCommand(zapytanie, polaczenie);
                    czytnik = komenda.ExecuteReader();

                    // wyczyszczenie pola z markami
                    cbMarka.Items.Clear();

                    if (czytnik.HasRows)
                    {
                        while (czytnik.Read())
                        {
                            cbMarka.Items.Add(czytnik.GetString(0));
                        }
                    }
                    czytnik.Close();
                    cbMarka.Text = cbMarka.Items[0].ToString();
                }
                catch (Exception ex)
                {
                    string byk = string.Format("Nie mogę wybrać marki przedmiotu", ex.Message);
                    MessageBox.Show(byk, "Błąd wybierania marki", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    polaczenie.Close();
                }
            }
        }

        private void btnDodajZlecenie_Click(object sender, EventArgs e)
        {
            // ustalenie id modelu
            // przypisanie wyniku do zmiennej idmodelu
            int idmodelu = 0, idklienta = 0;
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();                

                zapytanie = string.Format("SELECT id_modelu FROM modele WHERE marka='{0}' AND model='{1}'", cbMarka.Text, cbModel.Text);
                komenda = new SqlCommand(zapytanie, polaczenie);
                idmodelu = Convert.ToInt32(komenda.ExecuteScalar());
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę wybrać modelu urządzenia:\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd wyboru urządzenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }

            // ustalenie klienta
            // przypisanie wyniku do zmiennej idklienta
            if (chbOsoba.Checked)
            {
                try
                {
                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();

                    zapytanie = string.Format("SELECT id_klienta FROM klienci WHERE osoba='{0}'", cbKlient.Text);
                    komenda = new SqlCommand(zapytanie, polaczenie);
                    idklienta = Convert.ToInt32(komenda.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    string byk = string.Format("Nie mogę wybrać klienta:\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd wyboru klienta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    polaczenie.Close();
                }
            }

            if (chbFirma.Checked)
            {
                try
                {
                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();

                    zapytanie = string.Format("SELECT id_klienta FROM klienci WHERE firma='{0}'", cbKlient.Text);
                    komenda = new SqlCommand(zapytanie, polaczenie);
                    idklienta = Convert.ToInt32(komenda.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    string byk = string.Format("Nie mogę wybrać firmy:\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd wyboru firmy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    polaczenie.Close();
                }
            }

            // dodanie danych urządzenia

            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();
                if (zlecenie == 0)
                {
                    zapytanie = string.Format("INSERT INTO dane_urzadzenia(typ_urzadzenia, id_modelu, nr_seryjny, imei, procesor, pamiec, plyta_glowna, dysk_twardy, dysk_ssd, karta_graficzna, zasilacz, ekran, system_operacyjny, rysy,plamy, uszkodzenia, uwagi) VALUES('{0}', {1}, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}');", cbTypUrzadzenia.Text, idmodelu, tbNrSeryjny.Text, tbImei.Text, tbProcesor.Text, cbPamiec.Text, tbPlytaGlowna.Text, cbDyskTwardy.Text, cbDyskSSD.Text, tbKartaGraficzna.Text, tbZasilacz.Text, tbEkran.Text, cbSystemOperacyjny.Text, cbRysy.Text, cbPlamy.Text, cbUszkodzenia.Text, tbUwagi.Text);
                } else
                {
                    zapytanie = string.Format("UPDATE dane_urzadzenia SET typ_urzadzenia='{0}', id_modelu={1}, nr_seryjny='{2}', imei='{3}', procesor='{4}', pamiec='{5}', plyta_glowna='{6}', dysk_twardy='{7}', dysk_ssd='{8}', karta_graficzna='{9}', zasilacz='{10}', ekran='{11}', system_operacyjny='{12}', rysy='{13}', plamy='{14}', uszkodzenia='{15}', uwagi='{16}' WHERE id_urzadzenia={17};", cbTypUrzadzenia.Text, idmodelu, tbNrSeryjny.Text, tbImei.Text, tbProcesor.Text, cbPamiec.Text, tbPlytaGlowna.Text, cbDyskTwardy.Text, cbDyskSSD.Text, tbKartaGraficzna.Text, tbZasilacz.Text, tbEkran.Text, cbSystemOperacyjny.Text, cbRysy.Text, cbPlamy.Text, cbUszkodzenia.Text, tbUwagi.Text, urzadzenie);
                }
                komenda = new SqlCommand(zapytanie, polaczenie);
                komenda.ExecuteNonQuery();
            } catch (Exception ex)
            {
                if (zlecenie == 0)
                {
                    string byk = string.Format("Nie mogę dodać danych urządzenia.\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd dodawania urządzenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    string byk = string.Format("Nie mogę uaktualnić danych urządzenia.\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd uaktualniania danych urządzenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } finally
            {
                polaczenie.Close();
            }

            // ustalenie id_urzadzenia z tabeli dane_urzadzenia w celu dodania zlecenia
            int idurzadzenia = 0;
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT id_urzadzenia FROM dane_urzadzenia WHERE nr_seryjny='{0}' OR imei='{1}';", tbNrSeryjny.Text, tbImei.Text);
                komenda = new SqlCommand(zapytanie, polaczenie);
                if (zlecenie == 0)
                    idurzadzenia = Convert.ToInt32(komenda.ExecuteScalar());
                else
                    idurzadzenia = urzadzenie;
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę pobrać id urządzenia.\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd pobierania id urządzenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }

            // dodawanie nowego zlecenia
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                // obliczenie ceny ogólnej
                decimal cenaBrutto = Decimal.Round(Convert.ToDecimal(tbCenaUsluga.Text) * Convert.ToDecimal(1.23),2);
                decimal cenaOgolem = Decimal.Round(Convert.ToDecimal(cenaBrutto) + Convert.ToDecimal(tbCenaCzesci.Text),2);
                string cenaRazem = Convert.ToString(cenaOgolem);
                if (zlecenie == 0)
                {
                    zapytanie = string.Format("INSERT INTO zlecenia(data_przyjecia, id_klienta, typ_zlecenia, id_urzadzenia, status, cena_usluga, cena_czesci, cena_razem, opis_usterki, gwarancja) VALUES('{0}', {1}, '{2}', {3}, '{4}', {5}, {6}, {7}, '{8}', '{9}');", dtData.Text, idklienta, cbTypZlecenia.Text, idurzadzenia, "W naprawie", tbCenaUsluga.Text.Replace(",", "."), tbCenaCzesci.Text.Replace(",", "."), cenaRazem.Replace(",", "."), tbOpisUsterki.Text, cbGwarancja.Text);
                } else
                {
                    zapytanie = string.Format("UPDATE zlecenia SET data_przyjecia='{0}', id_klienta={1}, typ_zlecenia='{2}', id_urzadzenia={3}, status='{4}', cena_usluga={5}, cena_czesci={6}, cena_razem={7}, opis_usterki='{8}', gwarancja='{9}' WHERE id_zlecenia = {10};", dtData.Text, idklienta, cbTypZlecenia.Text, idurzadzenia, "W naprawie", tbCenaUsluga.Text.Replace(",", "."), tbCenaCzesci.Text.Replace(",", "."), cenaRazem.Replace(",", "."), tbOpisUsterki.Text, cbGwarancja.Text, nrZlecenia);
                }
                komenda = new SqlCommand(zapytanie, polaczenie);
                komenda.ExecuteNonQuery();
                if (zlecenie == 0)
                    MessageBox.Show("Poprawnie dodano nowe zlecenie do bazy danych.", "Dodawanie zlecenia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Poprawnie zautualizowano zlecenie do bazy danych.", "Uaktualnianie zlecenia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } catch (Exception ex)
            {
                if (zlecenie == 0)
                {
                    string byk = string.Format("Nie mogę dodać zlecenia.\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd dodawania zlecenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    string byk = string.Format("Nie mogę uaktualnić zlecenia.\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd uaktualniania zlecenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                polaczenie.Close();
            }
        }        
    }
}