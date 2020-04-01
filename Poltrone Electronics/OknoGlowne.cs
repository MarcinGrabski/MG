using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Poltrone_Electronics
{
    public partial class OknoGlowne : Form
    {
        #region Zmienne
        SqlConnection polaczenie = new SqlConnection("Data Source=DESKTOP-GRQCQK4\\SQLEXPRESS; Initial Catalog=poltrone; Integrated Security=True;");
        SqlCommand komenda;
        SqlDataReader czytnik;

        string zapytanie = "";

        private Logowanie okno;
        int indexRow = 0, idurzadzenia = 0, idmodelu = 0;
        decimal cena_usluga = 0, cena_czesci = 0;
        string marka = "", model = "";
        string nr_seryjny = "", imei = "", procesor = "", pamiec = "", plyta_glowna = "", dysk_twardy = "", dyskSSD = "", karta_graficzna = "", zasilacz = "", ekran = "", system_operacyjny = "", rysy = "", plamy = "", uszkodzenia = "", uwagi = "", opis_usterki = "";

        private void cbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dgrid.Rows[indexRow];
            int nrZlecenia = Convert.ToInt32(row.Cells[0].Value);

            if (MessageBox.Show("Czy na pewno chcesz zmienić status zlecenia", "Zmiana statusu zlecenia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();

                    zapytanie = string.Format("UPDATE zlecenia SET status='{0}' WHERE id_zlecenia={1}", cbStatus.Text, nrZlecenia);
                    komenda = new SqlCommand(zapytanie, polaczenie);
                    komenda.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string byk = string.Format("Nie mogę zaktualizować statusu zlecenia:\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd aktualizacji statusu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    polaczenie.Close();
                }

                try
                {
                    DateTime dzis = DateTime.Today;

                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();

                    if (cbStatus.Text.Equals("Zakończono"))
                    {
                        zapytanie = string.Format("UPDATE zlecenia SET data_naprawy='{0}' WHERE id_zlecenia={1}", dzis.ToString("yyyy-MM-dd"), nrZlecenia);
                    }
                    else
                    {
                        zapytanie = string.Format("UPDATE zlecenia SET data_naprawy=null WHERE id_zlecenia={0}", nrZlecenia);
                    }
                    komenda = new SqlCommand(zapytanie, polaczenie);
                    komenda.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string byk = string.Format("Nie mogę zaktualizować daty zakończenia:\n{0}", ex.Message);
                    MessageBox.Show(byk, "Błąd aktualizacji daty zakończenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    polaczenie.Close();
                }                
                OdswiezDane();
            }            
        }

        private void btnEkspertyza_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgrid.Rows[indexRow];
            int nrZlecenia = Convert.ToInt32(row.Cells[0].Value);

            Ekspertyza eksert = new Ekspertyza(nrZlecenia);
            eksert.ShowDialog();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgrid.Rows[indexRow];
            int nrZlecenia = Convert.ToInt32(row.Cells[0].Value);
            string typZlecenia = "", status = "", opisUsterki = "", gwarancja = "", typUrzadzenia="", marka = "", model = "", nrSeryjny = "", imei = "", procesor = "", pamiec = "", plytaGlowna = "", dyskTwardy = "", dyskSSD = "", kartaGraficzna = "", zasilacz = "", ekran = "", systemOperacyjny = "", rysy = "", plamy = "", uszkodzenia = "", uwagi = "", ekspertyza = "", system = "", podzespoly = "", pasty = "", testUrzadzenia = "", czyszczenie = "", testDysku = "", zauwazoneUsterki = "";
            decimal cenaUsluga = 0, cenaCzesci = 0, cenaRazem = 0;
            string dataPrzyjecia = "", dataNaprawy = "";

            // pobranie danych urządzenia
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("select data_przyjecia, typ_zlecenia, status, cena_usluga, cena_czesci, cena_razem, data_naprawy, opis_usterki, gwarancja, typ_urzadzenia, marka, model, nr_seryjny, imei, procesor, pamiec, plyta_glowna, dysk_twardy, dysk_ssd, karta_graficzna, zasilacz, ekran, system_operacyjny, rysy, plamy, uszkodzenia, uwagi, ekspertyza, system, podzespoly, pasty, test_urzadzenia, czyszczenie, test_dysku, zauwazone_usterki FROM zlecenia, dane_urzadzenia, modele, czynnosci WHERE dane_urzadzenia.id_modelu = modele.id_modelu AND dane_urzadzenia.id_urzadzenia = zlecenia.id_urzadzenia AND czynnosci.id_zlecenia = zlecenia.id_zlecenia;");
                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                if (czytnik.HasRows)
                {
                    while (czytnik.Read())
                    {
                        dataPrzyjecia = Convert.ToString(czytnik.GetDateTime(0));
                        typZlecenia = czytnik.GetString(1);
                        status = czytnik.GetString(2);
                        cenaUsluga = czytnik.GetDecimal(3);
                        cenaCzesci = czytnik.GetDecimal(4);
                        cenaRazem = czytnik.GetDecimal(5);
                        dataNaprawy = Convert.ToString(czytnik.GetDateTime(6));
                        opisUsterki = czytnik.GetString(7);
                        gwarancja = czytnik.GetString(8);
                        typUrzadzenia = czytnik.GetString(9);
                        marka = czytnik.GetString(10);
                        model = czytnik.GetString(11);
                        nrSeryjny = czytnik.GetString(12);
                        imei = czytnik.GetString(13);
                        procesor = czytnik.GetString(14);
                        pamiec = czytnik.GetString(15);
                        plytaGlowna = czytnik.GetString(16);
                        dyskTwardy = czytnik.GetString(17);
                        dyskSSD = czytnik.GetString(18);
                        kartaGraficzna = czytnik.GetString(19);
                        zasilacz = czytnik.GetString(20);
                        ekran = czytnik.GetString(21);
                        systemOperacyjny = czytnik.GetString(22);
                        rysy = czytnik.GetString(23);
                        plamy = czytnik.GetString(24);
                        uszkodzenia = czytnik.GetString(25);
                        uwagi = czytnik.GetString(26);
                        ekspertyza = czytnik.GetString(27);
                        system = czytnik.GetString(28);
                        podzespoly = czytnik.GetString(29);
                        pasty = czytnik.GetString(30);
                        testUrzadzenia = czytnik.GetString(31);
                        czyszczenie = czytnik.GetString(32);
                        testDysku = czytnik.GetString(33);
                        zauwazoneUsterki = czytnik.GetString(34);
                    }
                }
                czytnik.Close();
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę pobrać danych.\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd pobierania danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
            
            var outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test.pdf");
            using (var fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (var doc = new Document(PageSize.A4, 10f, 10f, 10f, 10f))
                {
                    using (var writer = PdfWriter.GetInstance(doc, fs))
                    {
                        doc.Open();
                                                                       
                        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED);

                        iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.NORMAL);

                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_duze, System.Drawing.Imaging.ImageFormat.Jpeg);
                        logo.ScaleAbsolute(550f, 70f);
                        logo.Alignment = Element.ALIGN_CENTER;

                        var p = new Paragraph(new Chunk("RAPORT NAPRAWY", font));
                        p.Alignment = Element.ALIGN_CENTER;

                        FontFactory.RegisterDirectory(@"C:\Windows\Fonts");

                        var p1 = new Paragraph(string.Format("\n1. Typ urządzenia: {0}\n2. Dane techniczne: (Szczegółowy opis w przypadku laptopów oraz desktopów)\n", typUrzadzenia), FontFactory.GetFont("Arial",BaseFont.CP1250, true, 11));
                        p1.Alignment = Element.ALIGN_LEFT;
                        p1.IndentationLeft = 20f;

                        PdfPTable table1 = new PdfPTable(3);
                        PdfPCell cell11 = new PdfPCell(new Phrase(string.Format("Procesor - {0}", procesor), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 10)));
                        cell11.Border = 0;
                        table1.AddCell(cell11);

                        PdfPCell cell12 = new PdfPCell(new Phrase(string.Format("Pamięć - {0}", pamiec), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 10)));
                        cell12.Border = 0;
                        table1.AddCell(cell12);

                        PdfPCell cell13 = new PdfPCell(new Phrase(string.Format("Płyta główna - {0}", plytaGlowna), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 10)));
                        cell13.Border = 0;
                        table1.AddCell(cell13);

                        PdfPTable table2 = new PdfPTable(3);
                        PdfPCell cell21 = new PdfPCell(new Phrase(string.Format("Dysk - {0}", dyskTwardy), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 10)));
                        cell21.Border = 0;
                        table2.AddCell(cell21);

                        PdfPCell cell22 = new PdfPCell(new Phrase(string.Format("Dysk SSD - {0}", dyskSSD), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 10)));
                        cell22.Border = 0;
                        table2.AddCell(cell22);

                        PdfPCell cell23 = new PdfPCell(new Phrase(string.Format("Karta graficzna - {0}", kartaGraficzna), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 10)));
                        cell23.Border = 0;
                        table2.AddCell(cell23);

                        PdfPTable table3 = new PdfPTable(2);
                        PdfPCell cell31 = new PdfPCell(new Phrase(string.Format("Zasilacz - {0}", zasilacz), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 10)));
                        cell31.Border = 0;
                        table3.AddCell(cell31);

                        PdfPCell cell32 = new PdfPCell(new Phrase(string.Format("System operacyjny - {0}", systemOperacyjny), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 10)));
                        cell32.Border = 0;
                        table3.AddCell(cell32);
                        
                        var p2 = new Paragraph("3. Stan ogólny dostarczonego urządzenia:\n", FontFactory.GetFont("Arial", BaseFont.CP1250, true, 11));
                        p2.Alignment = Element.ALIGN_LEFT;
                        p2.IndentationLeft = 20f;

                        var p3 = new Paragraph(string.Format("Rysy na obudowie oraz matrycy: {0}\nPlamy na obudowie oraz matrycy: {1}\nUszkodzenia mechaniczne: {2}", rysy.ToUpper(), plamy.ToUpper(), uszkodzenia.ToUpper()), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 11));
                        p3.Alignment = Element.ALIGN_LEFT;
                        p3.IndentationLeft = 40f;

                        var p4 = new Paragraph(string.Format("4. Opis usterki przez klienta:\n    {0}", opisUsterki), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 11));
                        p4.Alignment = Element.ALIGN_LEFT;
                        p4.IndentationLeft = 20f;

                        var p5 = new Paragraph(string.Format("5. Ekspertyza:\n    {0}", ekspertyza), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 11));
                        p5.Alignment = Element.ALIGN_LEFT;
                        p5.IndentationLeft = 20f;

                        var p6 = new Paragraph(string.Format("6. Lista napraw:\n- Reinstalacja lub odzyskiwanie systemu operacyjnego do stanu początkowego: {0}\n- Wymiana podzespołów: {1}\n- Wymiana past termoprzewodzących: {2}\n- Test urządzenia: {3}\n- Dokładne czyszczenie urządzenia: {4}\n- Dokładny test dysku twardego: {5} - Jeżeli tak to kopia raportu dla klienta.\n- Zauważone usterki, które nie zostały usunięte na prośbę klienta sprzętu: {6}", system.ToUpper(),podzespoly,pasty.ToUpper(),testUrzadzenia.ToUpper(),czyszczenie.ToUpper(),testDysku.ToUpper(), zauwazoneUsterki), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 11));
                        p6.Alignment = Element.ALIGN_LEFT;
                        p6.IndentationLeft = 20f;

                        var p7 = new Paragraph(string.Format("\nCena za usługę: {0} zł    Cena za części: {1} zł    Razem: {2} zł\nData wykonania naprawy: {3}", Decimal.Round(cenaUsluga, 2), Decimal.Round(cenaCzesci, 2), Decimal.Round(cenaRazem, 2), Convert.ToDateTime(dataNaprawy).ToString("yyyy-MM-dd")), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 11));
                        p7.Alignment = Element.ALIGN_LEFT;
                        p7.IndentationLeft = 20f;

                        var p8 = new Paragraph(string.Format("\nZgodnie z raportem na wykonaną naprawę przysługuje gwarancja w okresie {0}. Gwarancja nie obejmuje nowych usterek spowodowanych złym użytkowaniem sprzętu, zalaniem urządzenia cieczami, usterek mechanicznych, rozbieraniu urządzenia przez niewkwalifikowane osoby, a także na inne usterki, które nie były naprawiane na życzenie klienta. Instalowanie oprogramowania niewiadomego pochodzenia, które może zawierać wirusy użytkownik robi na własną odpowiedzialność.", gwarancja), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 11));
                        p8.Alignment = Element.ALIGN_JUSTIFIED;
                        p8.IndentationLeft = 20f;
                        p8.IndentationRight = 20f;

                        iTextSharp.text.Image JPG = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, System.Drawing.Imaging.ImageFormat.Jpeg);
                        JPG.ScalePercent(6f);

                        PdfPTable table4 = new PdfPTable(2);
                        PdfPCell cell41 = new PdfPCell(JPG);
                        cell41.Border = 0;
                        cell41.HorizontalAlignment = Element.ALIGN_RIGHT;
                        cell41.VerticalAlignment = Element.ALIGN_BOTTOM;
                        cell41.PaddingRight = 10f;
                        table4.AddCell(cell41);

                        PdfPCell cell42 = new PdfPCell(new Phrase(string.Format("\nPodpis i pieczęć serwisu\n\n\n.........................................", systemOperacyjny), FontFactory.GetFont("Arial", BaseFont.CP1250, true, 12)));
                        cell42.Border = 0;
                        cell42.HorizontalAlignment = Element.ALIGN_LEFT;
                        table4.AddCell(cell42);

                        doc.Add(logo);
                        doc.Add(p);
                        doc.Add(p1);
                        doc.Add(table1);
                        doc.Add(table2);
                        doc.Add(table3);
                        doc.Add(p2);
                        doc.Add(p3);
                        doc.Add(p4);
                        doc.Add(p5);
                        doc.Add(p6);
                        doc.Add(p7);
                        doc.Add(p8);
                        doc.Add(table4);
                        doc.Close();

                        // otwieranie PDF
                        System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Test.pdf");
                    }
                }
            }            
        }

        private void OknoGlowne_Shown(object sender, EventArgs e)
        {
            OdswiezDane();
        }        

        private void btnZdjecia_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgrid.Rows[indexRow];
            int nrZlecenia = Convert.ToInt32(row.Cells[0].Value);
            
            #region id_urzadzenia
            // ustalenie id_urzadzenia
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT id_urzadzenia FROM zlecenia WHERE id_zlecenia={0}", nrZlecenia);
                komenda = new SqlCommand(zapytanie, polaczenie);
                idurzadzenia = Convert.ToInt32(komenda.ExecuteScalar());
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę wybrać nr urządzenia:\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd wyboru nr urządzenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
            #endregion

            Zdjecia foto = new Zdjecia(idurzadzenia);
            foto.ShowDialog();
        }
        #endregion


        public OknoGlowne(Logowanie glowne, string login)
        {
            okno = glowne;
            InitializeComponent();
            lblLogin.Text = login;
        }

        public OknoGlowne()
        {            
            InitializeComponent();
        }

        private void OknoGlowne_FormClosed(object sender, FormClosedEventArgs e)
        {
            okno.Show();                        
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ustawienie numeru wiersza w tabeli zlecenia
            indexRow = e.RowIndex;
            DataGridViewRow row = dgrid.Rows[indexRow];
            int nrZlecenia = Convert.ToInt32(row.Cells[0].Value);

            int idczynnosci = 0;
            // sprawdzenie czy istnieje dodana ekspertyza do zlecenia w celu ukrycia przycisku PDF, jeżeli ekspertyzy nie ma
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT id_czynnosci FROM czynnosci WHERE id_zlecenia={0}", nrZlecenia);
                komenda = new SqlCommand(zapytanie, polaczenie);
                idczynnosci = Convert.ToInt32(komenda.ExecuteScalar());

                if (idczynnosci == 0)
                    btnPDF.Enabled = false;
                else
                    btnPDF.Enabled = true;
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę sprawdzić czy istnieje ekspertyza:\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd wyboru czynności", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Zlecenie zlecenie = new Zlecenie();
            zlecenie.ShowDialog();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajKlienta dk = new DodajKlienta();
            dk.ShowDialog();
        }

        private void listaKlientówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaKlientow okno = new ListaKlientow();
            okno.ShowDialog();
        }

        private void tbWyszukaj_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT id_zlecenia,data_przyjecia,osoba,firma,typ_zlecenia,typ_urzadzenia,status,FORMAT(cena_razem,'C','pl-PL') AS cena_razem,data_naprawy,gwarancja FROM zlecenia,dane_urzadzenia,klienci WHERE zlecenia.id_klienta = klienci.id_klienta AND zlecenia.id_urzadzenia = dane_urzadzenia.id_urzadzenia AND (data_przyjecia LIKE '%{0}%' OR osoba LIKE '%{0}%' OR firma LIKE '%{0}%' OR typ_zlecenia LIKE '%{0}%' OR typ_urzadzenia LIKE '%{0}%' OR status LIKE '%{0}%' OR data_przyjecia LIKE '%{0}%' OR data_naprawy LIKE '%{0}%' OR cena_razem LIKE '%{0}%' OR gwarancja LIKE '%{0}%')", tbWyszukaj.Text);
                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                if (czytnik.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(czytnik);
                    dgrid.DataSource = dt;
                }
                czytnik.Close();

                // zmiana nazw nagłówków kolumn
                dgrid.Columns[0].HeaderText = "Nr zlecenia";
                dgrid.Columns[1].HeaderText = "Data przyjęcia";
                dgrid.Columns[2].HeaderText = "Osoba";
                dgrid.Columns[3].HeaderText = "Firma";
                dgrid.Columns[4].HeaderText = "Typ zlecenia";
                dgrid.Columns[5].HeaderText = "Typ urządzenia";
                dgrid.Columns[6].HeaderText = "Status";
                dgrid.Columns[7].HeaderText = "Cena razem";
                dgrid.Columns[8].HeaderText = "Data naprawy";
                dgrid.Columns[9].HeaderText = "Gwaracja";

                // zmiana szerokości wybranych kolumn
                dgrid.Columns[3].Width = 200;

                // pogrubienie nagłówków i wyśrodkowanie treści
                DataGridViewCellStyle styl = new DataGridViewCellStyle();
                styl.Font = new System.Drawing.Font(this.Font, FontStyle.Bold);
                styl.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i <= 8; i++)
                {
                    dgrid.Columns[i].HeaderCell.Style = styl;
                }
                KolorWierszy();

            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę wyszukać zleceń:\n {0}", ex.Message);
                MessageBox.Show(byk, "Błąd ładowania zleceń", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void cbFiltruj_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                if (cbFiltruj.Text.Equals("Wszystko"))
                {
                    zapytanie = string.Format("SELECT id_zlecenia,data_przyjecia,osoba,firma,typ_zlecenia,typ_urzadzenia,status,FORMAT(cena_razem,'C','pl-PL') AS cena_razem,data_naprawy,gwarancja FROM zlecenia,dane_urzadzenia,klienci WHERE zlecenia.id_klienta = klienci.id_klienta AND zlecenia.id_urzadzenia = dane_urzadzenia.id_urzadzenia");
                } else
                {
                    zapytanie = string.Format("SELECT id_zlecenia,data_przyjecia,osoba,firma,typ_zlecenia,typ_urzadzenia,status,FORMAT(cena_razem,'C','pl-PL') AS cena_razem,data_naprawy,gwarancja FROM zlecenia,dane_urzadzenia,klienci WHERE zlecenia.id_klienta = klienci.id_klienta AND zlecenia.id_urzadzenia = dane_urzadzenia.id_urzadzenia AND status = '{0}'",cbFiltruj.Text);
                }
                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                if (czytnik.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(czytnik);
                    dgrid.DataSource = dt;
                } else
                {
                    czytnik.Close();
                    MessageBox.Show("Brak rekordów", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                czytnik.Close();

                // zmiana nazw nagłówków kolumn
                dgrid.Columns[0].HeaderText = "Nr zlecenia";
                dgrid.Columns[1].HeaderText = "Data przyjęcia";
                dgrid.Columns[2].HeaderText = "Osoba";
                dgrid.Columns[3].HeaderText = "Firma";
                dgrid.Columns[4].HeaderText = "Typ zlecenia";
                dgrid.Columns[5].HeaderText = "Typ urządzenia";
                dgrid.Columns[6].HeaderText = "Status";
                dgrid.Columns[7].HeaderText = "Cena razem";
                dgrid.Columns[8].HeaderText = "Data naprawy";
                dgrid.Columns[9].HeaderText = "Gwarancja";

                dgrid.Columns[3].Width = 200;

                // pogrubienie nagłówków i wyśrodkowanie treści
                DataGridViewCellStyle styl = new DataGridViewCellStyle();
                styl.Font = new System.Drawing.Font(this.Font, FontStyle.Bold);
                styl.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i <= 9; i++)
                {
                    dgrid.Columns[i].HeaderCell.Style = styl;
                }
                KolorWierszy();

            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę załadować zleceń:\n {0}", ex.Message);
                MessageBox.Show(byk, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgrid.Rows[indexRow];
            int nrZlecenia = Convert.ToInt32(row.Cells[0].Value);
            string data_zlecenia = row.Cells[1].Value.ToString();
            string osoba = row.Cells[2].Value.ToString();
            string firma = row.Cells[3].Value.ToString();
            string typ_zlecenia = row.Cells[4].Value.ToString();
            string typ_urzadzenia = row.Cells[5].Value.ToString();
            string status = row.Cells[6].Value.ToString();
            string cena_razem = row.Cells[7].Value.ToString();            
            string gwarancja = row.Cells[9].Value.ToString();

            #region id_urzadzenia
            // ustalenie id_urzadzenia
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT id_urzadzenia FROM zlecenia WHERE id_zlecenia={0}", nrZlecenia);
                komenda = new SqlCommand(zapytanie, polaczenie);
                idurzadzenia = Convert.ToInt32(komenda.ExecuteScalar());
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę wybrać nr urządzenia:\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd wyboru nr urządzenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
            #endregion

            #region idmodelu
            // ustalenie id_urzadzenia
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT id_modelu FROM dane_urzadzenia WHERE id_urzadzenia={0}", idurzadzenia);
                komenda = new SqlCommand(zapytanie, polaczenie);
                idmodelu = Convert.ToInt32(komenda.ExecuteScalar());
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę wybrać nr urządzenia:\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd wyboru nr urządzenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
            #endregion

            #region model
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();


                zapytanie = string.Format("SELECT marka,model FROM modele WHERE id_modelu={0}", idmodelu);

                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();                

                if (czytnik.HasRows)
                {
                    while (czytnik.Read())
                    {
                        marka = czytnik.GetString(0);
                        model = czytnik.GetString(1);
                    }
                }
                czytnik.Close();                
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę wybrać marki i modelu\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd wybierania modelu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
            #endregion

            #region urzadzenie
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();


                zapytanie = string.Format("SELECT nr_seryjny, imei, procesor, pamiec, plyta_glowna, dysk_twardy, dysk_ssd, karta_graficzna, zasilacz, ekran, system_operacyjny, rysy, plamy, uszkodzenia, uwagi FROM dane_urzadzenia WHERE id_urzadzenia={0}", idurzadzenia);

                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                if (czytnik.HasRows)
                {
                    while (czytnik.Read())
                    {
                        nr_seryjny = czytnik.GetString(0);
                        imei = czytnik.GetString(1);
                        procesor = czytnik.GetString(2);
                        pamiec = czytnik.GetString(3);
                        plyta_glowna = czytnik.GetString(4);
                        dysk_twardy = czytnik.GetString(5);
                        dyskSSD = czytnik.GetString(6);
                        karta_graficzna = czytnik.GetString(7);
                        zasilacz = czytnik.GetString(8);
                        ekran = czytnik.GetString(9);
                        system_operacyjny = czytnik.GetString(10);
                        rysy = czytnik.GetString(11);
                        plamy = czytnik.GetString(12);
                        uszkodzenia = czytnik.GetString(13);
                        uwagi = czytnik.GetString(14);
                    }
                }
                czytnik.Close();
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę pobrać danych urządzenia\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd wybierania danych urządzenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
            #endregion

            #region zlecenie
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();


                zapytanie = string.Format("SELECT cena_usluga, cena_czesci, opis_usterki FROM zlecenia WHERE id_zlecenia={0}", nrZlecenia);

                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                if (czytnik.HasRows)
                {
                    while (czytnik.Read())
                    {
                        cena_usluga = czytnik.GetDecimal(0);
                        cena_czesci = czytnik.GetDecimal(1);
                        opis_usterki = czytnik.GetString(2);
                        
                    }
                }
                czytnik.Close();
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę pobrać danych zlecenia\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd wybierania danych zlecenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
            #endregion
            Zlecenie okno = new Zlecenie(typ_urzadzenia, marka, model, nr_seryjny, imei, procesor, pamiec, plyta_glowna, dysk_twardy, dyskSSD, karta_graficzna, zasilacz, ekran, system_operacyjny, rysy, plamy, uszkodzenia, uwagi, opis_usterki, data_zlecenia, osoba, firma, typ_zlecenia, cena_usluga, cena_czesci, gwarancja, idurzadzenia, nrZlecenia);            
            okno.ShowDialog();
        }

        private void OdswiezDane()
        {
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("SELECT id_zlecenia,data_przyjecia,osoba,firma,typ_zlecenia,typ_urzadzenia,status,FORMAT(cena_razem,'C','pl-PL') AS cena_razem,data_naprawy,gwarancja FROM zlecenia,dane_urzadzenia,klienci WHERE zlecenia.id_klienta = klienci.id_klienta AND zlecenia.id_urzadzenia = dane_urzadzenia.id_urzadzenia");
                komenda = new SqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                if (czytnik.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(czytnik);
                    dgrid.DataSource = dt;
                }
                czytnik.Close();

                // zmiana nazw nagłówków kolumn
                dgrid.Columns[0].HeaderText = "Nr zlecenia";
                dgrid.Columns[1].HeaderText = "Data przyjęcia";
                dgrid.Columns[2].HeaderText = "Osoba";
                dgrid.Columns[3].HeaderText = "Firma";
                dgrid.Columns[4].HeaderText = "Typ zlecenia";
                dgrid.Columns[5].HeaderText = "Typ urządzenia";
                dgrid.Columns[6].HeaderText = "Status";
                dgrid.Columns[7].HeaderText = "Cena razem";
                dgrid.Columns[8].HeaderText = "Data naprawy";
                dgrid.Columns[9].HeaderText = "Gwarancja";

                dgrid.Columns[3].Width = 200;
                dgrid.Columns[6].Width = 150;

                // pogrubienie nagłówków i wyśrodkowanie treści
                DataGridViewCellStyle styl = new DataGridViewCellStyle();
                styl.Font = new System.Drawing.Font(this.Font, FontStyle.Bold);
                styl.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i <= 9; i++)
                {
                    dgrid.Columns[i].HeaderCell.Style = styl;
                }
                KolorWierszy();
                
            }
            catch (Exception ex)
            {
                string byk = string.Format("Nie mogę załadować zleceń:\n {0}", ex.Message);
                MessageBox.Show(byk, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void KolorWierszy()
        {
            for (int i = 0; i < dgrid.Rows.Count - 1; i++)
            {
                string stat = dgrid.Rows[i].Cells[6].Value.ToString();

                switch (stat)
                {
                    case "W naprawie":
                        dgrid.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                        break;
                    case "Decyzja klienta":
                        dgrid.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        break;
                    case "Naprawa usterki":
                        dgrid.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                        break;
                    case "Oczekiwanie na części":
                        dgrid.Rows[i].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                        break;
                    case "Odbiór sprzętu":
                        dgrid.Rows[i].DefaultCellStyle.BackColor = Color.HotPink;
                        break;
                    case "Odesłanie":
                        dgrid.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                        break;
                    case "Wycena naprawy":
                        dgrid.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                        break;
                    case "Zakończono":
                        dgrid.Rows[i].DefaultCellStyle.BackColor = Color.MediumOrchid;
                        break;
                    default:
                        dgrid.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            }
        }
    }
}