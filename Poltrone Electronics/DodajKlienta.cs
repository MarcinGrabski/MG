using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Poltrone_Electronics
{
    public partial class DodajKlienta : Form
    {
        #region Zmienne
        SqlConnection polaczenie = new SqlConnection("Data Source=DESKTOP-GRQCQK4\\SQLEXPRESS; Initial Catalog=poltrone; Integrated Security=True;");
        SqlCommand komenda;

        string zapytanie = "";
        int idklienta = 0;
        #endregion

        public DodajKlienta()
        {
            InitializeComponent();
        }

        public DodajKlienta(string zaznaczenie)
        {            
            InitializeComponent();
            if (zaznaczenie.Equals("osoba"))
            {
                chbOsoba.Checked = true;
            }

            if (zaznaczenie.Equals("firma"))
            {
                chbFirma.Checked = true;
            }
        }

        public DodajKlienta(string osoba, string firma, string adres, string nip, string regon, string tel_stacjonarny, string tel_komorkowy, string fax, string email)
        {
            InitializeComponent();
            btnDodaj.Text = "Uaktualnij";
            btnDodaj.Location = new Point(66, 361);
            btnDodaj.Size = new Size(121, 37);
            btnDodaj.Image = global::Poltrone_Electronics.Properties.Resources.update_icon;

            if (osoba.Length > 0)
            {
                tbOsoba.Text = osoba;
                chbOsoba.Checked = true;
                tbAdres.Text = adres;
                tbTelStacjonarny.Text = tel_stacjonarny;
                tbTelKomorkowy.Text = tel_komorkowy;
                tbEmail.Text = email;
                zapytanie = string.Format("SELECT id_klienta FROM klienci WHERE osoba='{0}' AND adres='{1}' AND tel_stacjonarny='{2}' AND tel_komorkowy='{3}' AND email='{4}'", osoba, adres, tel_stacjonarny, tel_komorkowy, email);
            }

            if (firma.Length > 0)
            {
                tbFirma.Text = firma;
                chbFirma.Checked = true;
                tbAdres.Text = adres;
                tbNip.Text = nip;
                tbRegon.Text = regon;
                tbTelStacjonarny.Text = tel_stacjonarny;
                tbTelKomorkowy.Text = tel_komorkowy;
                tbFax.Text = fax;
                tbEmail.Text = email;
                zapytanie = string.Format("SELECT id_klienta FROM klienci WHERE firma='{0}' AND adres='{1}' AND nip='{2}' AND regon='{3}' AND tel_stacjonarny='{4}' AND tel_komorkowy='{5}' AND fax='{6}' AND email='{7}'", firma, adres, nip, regon, tel_stacjonarny, tel_komorkowy, fax, email);
            }

            // ustalenie id klienta
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();                                
                
                komenda = new SqlCommand(zapytanie, polaczenie);
                idklienta = Convert.ToInt32(komenda.ExecuteScalar());                
            } catch (Exception ex)
            {
                string byk = string.Format("Nie mogę wybrać idklienta.\n {0}", ex.Message);
                MessageBox.Show(byk, "Błąd wybierania numeru klienta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            tbOsoba.Select();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((chbOsoba.Checked && tbOsoba.Text.Length > 5) || (chbFirma.Checked && tbFirma.Text.Length > 5))
            {
                try
                {
                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();

                    if (chbOsoba.Checked)
                    {
                        if (btnDodaj.Text.Equals("Dodaj klienta"))
                        {
                            zapytanie = string.Format("INSERT INTO klienci(osoba,adres,tel_stacjonarny,tel_komorkowy,email) VALUES('{0}', '{1}', '{2}', '{3}', '{4}');", tbOsoba.Text, tbAdres.Text, tbTelStacjonarny.Text, tbTelKomorkowy.Text, tbEmail.Text);
                        }
                        else
                        {
                            zapytanie = string.Format("UPDATE klienci SET osoba='{0}', adres='{1}', tel_stacjonarny='{2}', tel_komorkowy='{3}', email='{4}' WHERE id_klienta={5}", tbOsoba.Text, tbAdres.Text, tbTelStacjonarny.Text, tbTelKomorkowy.Text, tbEmail.Text, idklienta);
                        }
                    }

                    if (chbFirma.Checked)
                    {
                        if (btnDodaj.Text.Equals("Dodaj klienta"))
                        {
                            zapytanie = string.Format("INSERT INTO klienci(firma,adres,nip,regon,tel_stacjonarny,tel_komorkowy,fax,email) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');", tbFirma.Text, tbAdres.Text, tbNip.Text, tbRegon.Text, tbTelStacjonarny.Text, tbTelKomorkowy.Text, tbFax.Text, tbEmail.Text);
                        }
                        else
                        {
                            zapytanie = string.Format("UPDATE klienci SET firma='{0}', adres='{1}', nip='{2}', regon='{3}', tel_stacjonarny='{4}', tel_komorkowy='{5}', fax='{6}', email='{7}' WHERE id_klienta={8}", tbFirma.Text, tbAdres.Text, tbNip.Text, tbRegon.Text, tbTelStacjonarny.Text, tbTelKomorkowy.Text, tbFax.Text, tbEmail.Text, idklienta);
                        }
                    }

                    komenda = new SqlCommand(zapytanie, polaczenie);
                    komenda.ExecuteNonQuery();
                    if (btnDodaj.Text.Equals("Dodaj klienta"))
                    {
                        MessageBox.Show("Klient został dodany do bazy", "Dodanie klienta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Dane klient zostały zaktualizowane", "Uaktualnianie danych klienta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    if (btnDodaj.Text.Equals("Dodaj klienta"))
                    {
                        string byk = string.Format("Nie mogę dodać klienta.\n {0}", ex.Message);
                        MessageBox.Show(byk, "Błąd dodawania klienta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string byk = string.Format("Nie mogę uaktualnić danych klienta.\n {0}", ex.Message);
                        MessageBox.Show(byk, "Błąd uaktualniania danych klienta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    polaczenie.Close();
                }
            } else
            {
                MessageBox.Show("Uzupełnij pola", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool RegonValidate(string RegonValidate)
        {
            byte[] weights;
            ulong regon = ulong.MinValue;
            byte[] digits;

            if (ulong.TryParse(RegonValidate, out regon).Equals(false)) return false;

            switch (RegonValidate.Length)
            {
                case 7:
                    weights = new byte[] { 2, 3, 4, 5, 6, 7 };
                    break;

                case 9:
                    weights = new byte[] { 8, 9, 2, 3, 4, 5, 6, 7 };
                    break;

                case 14:
                    weights = new byte[] { 2, 4, 8, 5, 0, 9, 7, 3, 6, 1, 2, 4, 8 };
                    break;

                default:
                    return false;
            }

            string sRegon = regon.ToString();
            digits = new byte[sRegon.Length];

            for (int i = 0; i < sRegon.Length; i++)
            {
                if (byte.TryParse(sRegon[i].ToString(), out digits[i]).Equals(false)) return false;
            }

            int checksum = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                checksum += weights[i] * digits[i];
            }

            return (checksum % 11 % 10).Equals(digits[digits.Length - 1]);

        }

        static public bool NIPValidate(string NIPValidate)
        {
            const byte lenght = 10;

            ulong nip = ulong.MinValue;
            byte[] digits;
            byte[] weights = new byte[] { 6, 5, 7, 2, 3, 4, 5, 6, 7 };

            if (NIPValidate.Length.Equals(lenght).Equals(false)) return false;

            if (ulong.TryParse(NIPValidate, out nip).Equals(false)) return false;
            else
            {
                string sNIP = NIPValidate.ToString();
                digits = new byte[lenght];

                for (int i = 0; i < lenght; i++)
                {
                    if (byte.TryParse(sNIP[i].ToString(), out digits[i]).Equals(false)) return false;
                }

                int checksum = 0;

                for (int i = 0; i < lenght - 1; i++)
                {
                    checksum += digits[i] * weights[i];
                }

                return (checksum % 11 % 10).Equals(digits[digits.Length - 1]);
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void chbOsoba_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOsoba.Checked)
            {
                chbFirma.Checked = false;
                tbOsoba.Enabled = true;
                tbFirma.Enabled = false;                
                tbNip.Enabled = false;
                tbRegon.Enabled = false;
                tbOsoba.BackColor = Color.BurlyWood;
                tbFirma.BackColor = Color.DimGray;
                tbNip.BackColor = Color.DimGray;
                tbRegon.BackColor = Color.DimGray;
                tbOsoba.Select();

                // wyświetlenie liczników
                licznikOsoba.Visible = true;
                licznikAdres.Visible = true;
                licznikEmail.Visible = true;

                // ukrycie ikonek walidacji dla firmy
                pbFirma.Visible = false;
                pbNip.Visible = false;
                pbRegon.Visible = false;
            } else
            {
                licznikOsoba.Visible = false;
                chbFirma.Checked = true;
            }
        }

        private void chbFirma_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFirma.Checked)
            {
                chbOsoba.Checked = false;
                tbOsoba.Enabled = false;
                tbFirma.Enabled = true;
                tbNip.Enabled = true;
                tbRegon.Enabled = true;
                tbOsoba.BackColor = Color.DimGray;
                tbFirma.BackColor = Color.BurlyWood;
                tbNip.BackColor = Color.BurlyWood;
                tbRegon.BackColor = Color.BurlyWood;
                tbFirma.Select();
            }
            else
            {
                chbOsoba.Checked = true;
            }
        }

        private void tbOsoba_TextChanged(object sender, EventArgs e)
        {
            int liczOsoba = 0;

            if (chbOsoba.Checked)
            {
                licznikOsoba.Visible = true;
                liczOsoba = 80 - tbOsoba.Text.Length;
                licznikOsoba.Text = string.Format("{0}", liczOsoba);

                if (tbOsoba.Text.Length > 5)
                    pbOsoba.Visible = true;
                else
                    pbOsoba.Visible = false;
            }
            else
            {              
                pbOsoba.Visible = false;
            }
        }

        private void tbNip_TextChanged(object sender, EventArgs e)
        {
            if (chbFirma.Checked)
            {
                if (NIPValidate(tbNip.Text.Replace("-","")))
                {
                    pbNip.Visible = true;
                }
                else
                {
                    pbNip.Visible = false;
                }
            }
        }

        private void tbRegon_TextChanged(object sender, EventArgs e)
        {
            if (chbFirma.Checked)
            {
                if (RegonValidate(tbRegon.Text))
                {
                    pbRegon.Visible = true;
                }
                else
                {
                    pbRegon.Visible = false;
                }
            }
        }

        private void tbTelStacjonarny_TextChanged(object sender, EventArgs e)
        {
            if (tbTelStacjonarny.Text.Length == 14)
            {
                pbTelStacjonarny.Visible = true;
            } else
            {
                pbTelStacjonarny.Visible = false;
            }
        }

        private void tbTelKomorkowy_TextChanged(object sender, EventArgs e)
        {
            if (tbTelKomorkowy.Text.Length == 15)
            {
                pbTelKomorkowy.Visible = true;
            } else
            {
                pbTelKomorkowy.Visible = false;
            }
        }

        private void tbFax_TextChanged(object sender, EventArgs e)
        {
            if (tbFax.Text.Length == 14)
            {
                pbFax.Visible = true;
            } else
            {
                pbFax.Visible = false;
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(tbEmail.Text))
            {
                pbEmail.Visible = true;
            } else
            {
                pbEmail.Visible = false;
            }

            int liczEmail = 80 - tbEmail.Text.Length;
            licznikEmail.Text = string.Format("{0}", liczEmail);
        }

        private void tbAdres_TextChanged(object sender, EventArgs e)
        {
            int liczAdres = 200 - tbAdres.Text.Length;
            licznikAdres.Text = string.Format("{0}", liczAdres);

            if (tbAdres.Text.Length > 10)
                pbAdres.Visible = true;
            else
                pbAdres.Visible = false;
        }
    }
}