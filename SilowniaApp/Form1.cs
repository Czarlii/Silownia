using SilowniaLib;

namespace SilowniaApp
{
    public partial class Form1 : Form
    {
        private MenedzerSilowni menedzer = new MenedzerSilowni();
        private static readonly string SciezkaDanych = "silownia_dane.json";
        private int? edytowanyId = null;

        public Form1()
        {
            InitializeComponent();
            PodepnijEventy();

            //Wczytanie pliku
            if (File.Exists(SciezkaDanych))
                menedzer.Wczytaj(SciezkaDanych);

            OdswiezWszystko();
        }

        private void PodepnijEventy()
        {
            menedzer.OnCzlonekDodany += czlonek =>
            {
                MessageBox.Show($"Dodano nowego czlonka: {czlonek.ImieNazwisko}", "Nowy czlonek",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            menedzer.OnCzlonekUsuniety += czlonek =>
            {
                MessageBox.Show($"Usunieto czlonka: {czlonek.ImieNazwisko}", "Usunieto czlonka",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }

        //MENU

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                menedzer.Zapisz(SciezkaDanych);
                MessageBox.Show("Dane zostaly zapisane!", "Zapis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Blad zapisu: {ex.Message}", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                menedzer.Wczytaj(SciezkaDanych);
                OdswiezWszystko();
                MessageBox.Show("Dane zostaly wczytane!", "Wczytanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Blad wczytania: {ex.Message}", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wyjscieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Automatyczny zapis
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            menedzer.Zapisz(SciezkaDanych);
        }

        
        private void OdswiezWszystko()
        {
            OdswiezListeCzlonkow();
            OdswiezListeCwiczen();
            OdswiezKomboPlany();
        }

        private void OdswiezListeCzlonkow()
        {
            listBoxCzlonkowie.Items.Clear();
            foreach (Czlonek c in menedzer.PobierzCzlonkow())
                listBoxCzlonkowie.Items.Add(c);
        }

        private void OdswiezListeCwiczen()
        {
            listBoxCwiczenia.Items.Clear();
            foreach (Cwiczenie c in menedzer.PobierzCwiczenia())
                listBoxCwiczenia.Items.Add(c);

            OdswiezDostepneCwiczenia();
        }

        private void OdswiezKomboPlany()
        {
            string? wybrany = cmbCzlonkowieOdPlany.SelectedItem?.ToString();
            cmbCzlonkowieOdPlany.Items.Clear();
            foreach (Czlonek c in menedzer.PobierzCzlonkow())
                cmbCzlonkowieOdPlany.Items.Add(c.ImieNazwisko + " | " + c.Id);

            if (wybrany != null && cmbCzlonkowieOdPlany.Items.Contains(wybrany))
                cmbCzlonkowieOdPlany.SelectedItem = wybrany;
        }

        private void OdswiezDostepneCwiczenia()
        {
            listBoxDostepneCwiczenia.Items.Clear();
            foreach (Cwiczenie c in menedzer.PobierzCwiczenia())
                listBoxDostepneCwiczenia.Items.Add(c);
        }

        private void OdswiezPlanCzlonka()
        {
            listBoxPlanCwiczenia.Items.Clear();
            if (cmbCzlonkowieOdPlany.SelectedIndex < 0) return;

            int id = PobierzIdZKombo(cmbCzlonkowieOdPlany.SelectedItem?.ToString());
            PlanTreningu? plan = menedzer.PobierzPlanCzlonka(id);
            if (plan != null)
            {
                foreach (Cwiczenie c in plan.Cwiczenia)
                    listBoxPlanCwiczenia.Items.Add(c);
                lblKaloriePlan.Text = $"Laczne kalorie: {plan.ObliczLaczneKalorie():F1} kcal";
            }
            else
            {
                lblKaloriePlan.Text = "Brak planu - utwórz plan ponizej";
            }
        }

        private int PobierzIdZKombo(string? tekst)
        {
            if (tekst == null) return -1;
            string[] czesci = tekst.Split(" | ");
            if (czesci.Length > 1 && int.TryParse(czesci[1], out int id))
                return id;
            return -1;
        }

        // ===== TAB 1: CZLONKOWIE =====

        private void btnDodajCzlonka_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImie.Text) ||
                string.IsNullOrWhiteSpace(txtNazwisko.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Wypelnij imie, nazwisko i telefon!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtWaga.Text, out double waga))
            {
                MessageBox.Show("Podaj prawidlowa wage!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefon.Text.Trim(), @"^\d{9}$"))
            {
                MessageBox.Show("Numer telefonu musi miec dokladnie 9 cyfr!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (edytowanyId != null)
            {
                // TRYB EDYCJI
                try
                {
                    Czlonek zaktualizowany = new Czlonek
                    {
                        Id = edytowanyId.Value,
                        Imie = txtImie.Text.Trim(),
                        Nazwisko = txtNazwisko.Text.Trim(),
                        NumerTelefonu = txtTelefon.Text.Trim(),
                        DataUrodzenia = dtpDataUrodzenia.Value,
                        WagaKg = waga
                    };

                    menedzer.AktualizujCzlonka(zaktualizowany);
                    OdswiezListeCzlonkow();
                    OdswiezKomboPlany();
                    AnulujEdycje();
                    MessageBox.Show("Dane czlonka zostaly zaktualizowane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (CzlonekJuzIstniejeWyjatek ex)
                {
                    MessageBox.Show(ex.Message, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // TRYB DODAWANIA
                try
                {
                    Czlonek czlonek = new Czlonek
                    {
                        Imie = txtImie.Text.Trim(),
                        Nazwisko = txtNazwisko.Text.Trim(),
                        NumerTelefonu = txtTelefon.Text.Trim(),
                        DataUrodzenia = dtpDataUrodzenia.Value,
                        DataDolaczenia = DateTime.Now,
                        WagaKg = waga
                    };

                    menedzer.DodajCzlonka(czlonek);
                    OdswiezListeCzlonkow();
                    OdswiezKomboPlany();

                    txtImie.Clear();
                    txtNazwisko.Clear();
                    txtTelefon.Clear();
                    txtWaga.Clear();
                }
                catch (CzlonekJuzIstniejeWyjatek ex)
                {
                    MessageBox.Show(ex.Message, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdytujCzlonka_Click(object sender, EventArgs e)
        {
            if (listBoxCzlonkowie.SelectedItem is not Czlonek wybrany) return;

            txtImie.Text = wybrany.Imie;
            txtNazwisko.Text = wybrany.Nazwisko;
            txtTelefon.Text = wybrany.NumerTelefonu;
            txtWaga.Text = wybrany.WagaKg.ToString();
            dtpDataUrodzenia.Value = wybrany.DataUrodzenia;

            edytowanyId = wybrany.Id;
            btnDodajCzlonka.Text = "Zapisz zmiany";
            btnAnulujEdycje.Visible = true;
        }

        private void btnAnulujEdycje_Click(object sender, EventArgs e)
        {
            AnulujEdycje();
        }

        private void AnulujEdycje()
        {
            edytowanyId = null;
            btnDodajCzlonka.Text = "Dodaj czlonka";
            btnAnulujEdycje.Visible = false;
            txtImie.Clear();
            txtNazwisko.Clear();
            txtTelefon.Clear();
            txtWaga.Clear();
        }

        private void btnUsunCzlonka_Click(object sender, EventArgs e)
        {
            if (listBoxCzlonkowie.SelectedItem is not Czlonek wybrany) return;

            try
            {
                menedzer.UsunCzlonka(wybrany.Id);
                OdswiezListeCzlonkow();
                OdswiezKomboPlany();
                AnulujEdycje();
            }
            catch (CzlonekNieZnalezionyWyjatek ex)
            {
                MessageBox.Show(ex.Message, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== TAB 2: CWICZENIA =====

        private void cmbTypCwiczenia_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSilowe.Visible = cmbTypCwiczenia.SelectedIndex == 0;
            panelKardio.Visible = cmbTypCwiczenia.SelectedIndex == 1;
            panelRozciagajace.Visible = cmbTypCwiczenia.SelectedIndex == 2;
        }

        private void btnDodajCwiczenie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazwaCw.Text))
            {
                MessageBox.Show("Podaj nazwe cwiczenia!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCzasCw.Text, out int czas))
            {
                MessageBox.Show("Podaj prawidlowy czas!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cwiczenie? noweCwiczenie = null;

                if (cmbTypCwiczenia.SelectedIndex == 0) // Silowe
                {
                    if (!int.TryParse(txtSerie.Text, out int serie) ||
                        !int.TryParse(txtPowtorzenia.Text, out int powtorzenia) ||
                        !double.TryParse(txtCiezar.Text, out double ciezar))
                    {
                        MessageBox.Show("Podaj prawidlowe dane dla cwiczenia silowego!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    noweCwiczenie = new CwiczenieSilowe
                    {
                        Nazwa = txtNazwaCw.Text.Trim(),
                        Opis = txtOpisCw.Text.Trim(),
                        CzasTrwaniaMinuty = czas,
                        LiczbaSerii = serie,
                        LiczbaPowtorzen = powtorzenia,
                        CiezarKg = ciezar
                    };
                }
                else if (cmbTypCwiczenia.SelectedIndex == 1) // Kardio
                {
                    if (!double.TryParse(txtDystans.Text, out double dystans))
                    {
                        MessageBox.Show("Podaj prawidlowy dystans!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    noweCwiczenie = new CwiczenieKardio
                    {
                        Nazwa = txtNazwaCw.Text.Trim(),
                        Opis = txtOpisCw.Text.Trim(),
                        CzasTrwaniaMinuty = czas,
                        Dystans = dystans,
                        Intensywnosc = (Intensywnosc)cmbIntensywnosc.SelectedIndex
                    };
                }
                else if (cmbTypCwiczenia.SelectedIndex == 2) // Rozciagajace
                {
                    noweCwiczenie = new CwiczenieRozciagajace
                    {
                        Nazwa = txtNazwaCw.Text.Trim(),
                        Opis = txtOpisCw.Text.Trim(),
                        CzasTrwaniaMinuty = czas,
                        GrupaMiesniowa = txtGrupaMiesniowa.Text.Trim()
                    };
                }
                else
                {
                    MessageBox.Show("Wybierz typ cwiczenia!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                menedzer.DodajCwiczenie(noweCwiczenie);
                OdswiezListeCwiczen();

                txtNazwaCw.Clear();
                txtOpisCw.Clear();
                txtCzasCw.Clear();
                txtSerie.Clear();
                txtPowtorzenia.Clear();
                txtCiezar.Clear();
                txtDystans.Clear();
                txtGrupaMiesniowa.Clear();
            }
            catch (CwiczenieJuzIstniejeWyjatek ex)
            {
                MessageBox.Show(ex.Message, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsunCwiczenie_Click(object sender, EventArgs e)
        {
            if (listBoxCwiczenia.SelectedItem is not Cwiczenie wybrany) return;
            menedzer.UsunCwiczenie(wybrany.Nazwa);
            OdswiezListeCwiczen();
        }

        // ===== TAB 3: PLANY =====

        private void cmbCzlonkowieOdPlany_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdswiezPlanCzlonka();
        }

        private void btnStworzPlan_Click(object sender, EventArgs e)
        {
            if (cmbCzlonkowieOdPlany.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz czlonka!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = PobierzIdZKombo(cmbCzlonkowieOdPlany.SelectedItem?.ToString());
            Czlonek? czlonek = menedzer.ZnajdzCzlonka(id);
            if (czlonek == null) return;

            if (menedzer.PobierzPlanCzlonka(id) != null)
            {
                MessageBox.Show("Ten czlonek juz ma plan treningowy!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                menedzer.StworzPlan(id, $"Plan - {czlonek.ImieNazwisko}");
                OdswiezPlanCzlonka();
                MessageBox.Show("Plan treningowy zostal utworzony!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodajDoPlan_Click(object sender, EventArgs e)
        {
            if (cmbCzlonkowieOdPlany.SelectedIndex < 0 || listBoxDostepneCwiczenia.SelectedItem is not Cwiczenie wybraneCw)
                return;

            int id = PobierzIdZKombo(cmbCzlonkowieOdPlany.SelectedItem?.ToString());
            PlanTreningu? plan = menedzer.PobierzPlanCzlonka(id);

            if (plan == null)
            {
                MessageBox.Show("Najpierw utwórz plan treningowy!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (plan.Cwiczenia.Any(c => c.Nazwa == wybraneCw.Nazwa))
            {
                MessageBox.Show("To cwiczenie jest juz w planie!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            plan.DodajCwiczenie(wybraneCw);
            OdswiezPlanCzlonka();
        }

        private void btnUsunZPlanu_Click(object sender, EventArgs e)
        {
            if (cmbCzlonkowieOdPlany.SelectedIndex < 0 || listBoxPlanCwiczenia.SelectedItem is not Cwiczenie wybraneCw)
                return;

            int id = PobierzIdZKombo(cmbCzlonkowieOdPlany.SelectedItem?.ToString());
            PlanTreningu? plan = menedzer.PobierzPlanCzlonka(id);
            plan?.UsunCwiczenie(wybraneCw.Nazwa);
            OdswiezPlanCzlonka();
        }

        private void btnUsunPlan_Click(object sender, EventArgs e)
        {
            if (cmbCzlonkowieOdPlany.SelectedIndex < 0) return;

            int id = PobierzIdZKombo(cmbCzlonkowieOdPlany.SelectedItem?.ToString());

            if (menedzer.PobierzPlanCzlonka(id) == null)
            {
                MessageBox.Show("Ten czlonek nie ma planu treningowego!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult potwierdzenie = MessageBox.Show(
                "Czy na pewno chcesz usunac caly plan treningowy?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (potwierdzenie == DialogResult.Yes)
            {
                try
                {
                    menedzer.UsunPlan(id);
                    OdswiezPlanCzlonka();
                    MessageBox.Show("Plan treningowy zostal usuniety!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (PlanNieZnalezionyWyjatek ex)
                {
                    MessageBox.Show(ex.Message, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ===== TAB 4: STATYSTYKI =====

        private void btnWszyscyKalorie_Click(object sender, EventArgs e)
        {
            listBoxStatystyki.Items.Clear();
            listBoxStatystyki.Items.Add("=== Kalorie wszystkich czlonkow ===");
            List<string> wyniki = menedzer.WszyscyCzlonkowieZKaloriami();
            foreach (string w in wyniki)
                listBoxStatystyki.Items.Add(w);
        }

        private void btnTop3_Click(object sender, EventArgs e)
        {
            listBoxStatystyki.Items.Clear();
            listBoxStatystyki.Items.Add("=== Top 3 czlonkow (najwiecej kalorii) ===");
            List<string> wyniki = menedzer.NajlepsiCzlonkowie(3);
            foreach (string w in wyniki)
                listBoxStatystyki.Items.Add(w);
        }

        private void btnGrupujPoTypie_Click(object sender, EventArgs e)
        {
            listBoxStatystyki.Items.Clear();
            listBoxStatystyki.Items.Add("=== Cwiczenia pogrupowane po typie ===");
            List<string> wyniki = menedzer.GrupujCwiczenieaPoTypie();
            foreach (string w in wyniki)
                listBoxStatystyki.Items.Add(w);
        }

        private void btnSrednia_Click(object sender, EventArgs e)
        {
            listBoxStatystyki.Items.Clear();
            double srednia = menedzer.SredniaKaloriiNaTrening();
            listBoxStatystyki.Items.Add($"Srednia kalorii na plan treningowy: {srednia:F1} kcal");
        }

        private void listBoxCzlonkowie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBoxCwiczenia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
