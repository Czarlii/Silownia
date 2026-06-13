namespace SilowniaApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            zapiszToolStripMenuItem = new ToolStripMenuItem();
            wczytajToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            wyjscieToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listBoxCzlonkowie = new ListBox();
            btnUsunCzlonka = new Button();
            btnEdytujCzlonka = new Button();
            btnAnulujEdycje = new Button();
            lblImie = new Label();
            txtImie = new TextBox();
            lblNazwisko = new Label();
            txtNazwisko = new TextBox();
            lblTelefon = new Label();
            txtTelefon = new TextBox();
            lblDataUrodzenia = new Label();
            dtpDataUrodzenia = new DateTimePicker();
            lblWaga = new Label();
            txtWaga = new TextBox();
            btnDodajCzlonka = new Button();
            tabPage2 = new TabPage();
            listBoxCwiczenia = new ListBox();
            btnUsunCwiczenie = new Button();
            lblTypCw = new Label();
            cmbTypCwiczenia = new ComboBox();
            lblNazwaCw = new Label();
            txtNazwaCw = new TextBox();
            lblOpisCw = new Label();
            txtOpisCw = new TextBox();
            lblCzasCw = new Label();
            txtCzasCw = new TextBox();
            panelSilowe = new Panel();
            lblSerie = new Label();
            txtSerie = new TextBox();
            lblPowtorzenia = new Label();
            txtPowtorzenia = new TextBox();
            lblCiezar = new Label();
            txtCiezar = new TextBox();
            panelKardio = new Panel();
            lblDystans = new Label();
            txtDystans = new TextBox();
            lblIntensywnosc = new Label();
            cmbIntensywnosc = new ComboBox();
            panelRozciagajace = new Panel();
            lblGrupa = new Label();
            txtGrupaMiesniowa = new TextBox();
            btnDodajCwiczenie = new Button();
            tabPage3 = new TabPage();
            lblCzlonekPlan = new Label();
            cmbCzlonkowieOdPlany = new ComboBox();
            btnStworzPlan = new Button();
            btnUsunPlan = new Button();
            lblDostepne = new Label();
            listBoxDostepneCwiczenia = new ListBox();
            btnDodajDoPlan = new Button();
            lblPlanCw = new Label();
            listBoxPlanCwiczenia = new ListBox();
            btnUsunZPlanu = new Button();
            lblKaloriePlan = new Label();
            tabPage4 = new TabPage();
            listBoxStatystyki = new ListBox();
            btnWszyscyKalorie = new Button();
            btnTop3 = new Button();
            btnGrupujPoTypie = new Button();
            btnSrednia = new Button();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panelSilowe.SuspendLayout();
            panelKardio.SuspendLayout();
            panelRozciagajace.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(920, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zapiszToolStripMenuItem, wczytajToolStripMenuItem, toolStripSeparator1, wyjscieToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszToolStripMenuItem
            // 
            zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            zapiszToolStripMenuItem.Size = new Size(115, 22);
            zapiszToolStripMenuItem.Text = "Zapisz";
            zapiszToolStripMenuItem.Click += zapiszToolStripMenuItem_Click;
            // 
            // wczytajToolStripMenuItem
            // 
            wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            wczytajToolStripMenuItem.Size = new Size(115, 22);
            wczytajToolStripMenuItem.Text = "Wczytaj";
            wczytajToolStripMenuItem.Click += wczytajToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(112, 6);
            // 
            // wyjscieToolStripMenuItem
            // 
            wyjscieToolStripMenuItem.Name = "wyjscieToolStripMenuItem";
            wyjscieToolStripMenuItem.Size = new Size(115, 22);
            wyjscieToolStripMenuItem.Text = "Wyjscie";
            wyjscieToolStripMenuItem.Click += wyjscieToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(920, 556);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBoxCzlonkowie);
            tabPage1.Controls.Add(btnUsunCzlonka);
            tabPage1.Controls.Add(btnEdytujCzlonka);
            tabPage1.Controls.Add(btnAnulujEdycje);
            tabPage1.Controls.Add(lblImie);
            tabPage1.Controls.Add(txtImie);
            tabPage1.Controls.Add(lblNazwisko);
            tabPage1.Controls.Add(txtNazwisko);
            tabPage1.Controls.Add(lblTelefon);
            tabPage1.Controls.Add(txtTelefon);
            tabPage1.Controls.Add(lblDataUrodzenia);
            tabPage1.Controls.Add(dtpDataUrodzenia);
            tabPage1.Controls.Add(lblWaga);
            tabPage1.Controls.Add(txtWaga);
            tabPage1.Controls.Add(btnDodajCzlonka);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(912, 528);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Czlonkowie";
            // 
            // listBoxCzlonkowie
            // 
            listBoxCzlonkowie.ItemHeight = 15;
            listBoxCzlonkowie.Location = new Point(8, 8);
            listBoxCzlonkowie.Name = "listBoxCzlonkowie";
            listBoxCzlonkowie.Size = new Size(512, 454);
            listBoxCzlonkowie.TabIndex = 0;
            listBoxCzlonkowie.SelectedIndexChanged += listBoxCzlonkowie_SelectedIndexChanged;
            // 
            // btnUsunCzlonka
            // 
            btnUsunCzlonka.Location = new Point(8, 478);
            btnUsunCzlonka.Name = "btnUsunCzlonka";
            btnUsunCzlonka.Size = new Size(145, 30);
            btnUsunCzlonka.TabIndex = 1;
            btnUsunCzlonka.Text = "Usun czlonka";
            btnUsunCzlonka.Click += btnUsunCzlonka_Click;
            // 
            // btnEdytujCzlonka
            // 
            btnEdytujCzlonka.Location = new Point(163, 478);
            btnEdytujCzlonka.Name = "btnEdytujCzlonka";
            btnEdytujCzlonka.Size = new Size(145, 30);
            btnEdytujCzlonka.TabIndex = 2;
            btnEdytujCzlonka.Text = "Edytuj czlonka";
            btnEdytujCzlonka.Click += btnEdytujCzlonka_Click;
            // 
            // btnAnulujEdycje
            // 
            btnAnulujEdycje.BackColor = Color.MistyRose;
            btnAnulujEdycje.Location = new Point(575, 225);
            btnAnulujEdycje.Name = "btnAnulujEdycje";
            btnAnulujEdycje.Size = new Size(315, 30);
            btnAnulujEdycje.TabIndex = 8;
            btnAnulujEdycje.Text = "Anuluj edycje";
            btnAnulujEdycje.UseVisualStyleBackColor = false;
            btnAnulujEdycje.Visible = false;
            btnAnulujEdycje.Click += btnAnulujEdycje_Click;
            // 
            // lblImie
            // 
            lblImie.AutoSize = true;
            lblImie.Location = new Point(575, 15);
            lblImie.Name = "lblImie";
            lblImie.Size = new Size(33, 15);
            lblImie.TabIndex = 9;
            lblImie.Text = "Imie:";
            // 
            // txtImie
            // 
            txtImie.Location = new Point(690, 12);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(200, 23);
            txtImie.TabIndex = 2;
            // 
            // lblNazwisko
            // 
            lblNazwisko.AutoSize = true;
            lblNazwisko.Location = new Point(575, 47);
            lblNazwisko.Name = "lblNazwisko";
            lblNazwisko.Size = new Size(60, 15);
            lblNazwisko.TabIndex = 10;
            lblNazwisko.Text = "Nazwisko:";
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(690, 44);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(200, 23);
            txtNazwisko.TabIndex = 3;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(575, 79);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(49, 15);
            lblTelefon.TabIndex = 11;
            lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(690, 76);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 23);
            txtTelefon.TabIndex = 4;
            // 
            // lblDataUrodzenia
            // 
            lblDataUrodzenia.AutoSize = true;
            lblDataUrodzenia.Location = new Point(575, 111);
            lblDataUrodzenia.Name = "lblDataUrodzenia";
            lblDataUrodzenia.Size = new Size(89, 15);
            lblDataUrodzenia.TabIndex = 12;
            lblDataUrodzenia.Text = "Data urodzenia:";
            // 
            // dtpDataUrodzenia
            // 
            dtpDataUrodzenia.Format = DateTimePickerFormat.Short;
            dtpDataUrodzenia.Location = new Point(690, 108);
            dtpDataUrodzenia.Name = "dtpDataUrodzenia";
            dtpDataUrodzenia.Size = new Size(200, 23);
            dtpDataUrodzenia.TabIndex = 5;
            // 
            // lblWaga
            // 
            lblWaga.AutoSize = true;
            lblWaga.Location = new Point(575, 143);
            lblWaga.Name = "lblWaga";
            lblWaga.Size = new Size(64, 15);
            lblWaga.TabIndex = 13;
            lblWaga.Text = "Waga (kg):";
            // 
            // txtWaga
            // 
            txtWaga.Location = new Point(690, 140);
            txtWaga.Name = "txtWaga";
            txtWaga.Size = new Size(200, 23);
            txtWaga.TabIndex = 6;
            // 
            // btnDodajCzlonka
            // 
            btnDodajCzlonka.Location = new Point(575, 182);
            btnDodajCzlonka.Name = "btnDodajCzlonka";
            btnDodajCzlonka.Size = new Size(315, 35);
            btnDodajCzlonka.TabIndex = 7;
            btnDodajCzlonka.Text = "Dodaj czlonka";
            btnDodajCzlonka.Click += btnDodajCzlonka_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBoxCwiczenia);
            tabPage2.Controls.Add(btnUsunCwiczenie);
            tabPage2.Controls.Add(lblTypCw);
            tabPage2.Controls.Add(cmbTypCwiczenia);
            tabPage2.Controls.Add(lblNazwaCw);
            tabPage2.Controls.Add(txtNazwaCw);
            tabPage2.Controls.Add(lblOpisCw);
            tabPage2.Controls.Add(txtOpisCw);
            tabPage2.Controls.Add(lblCzasCw);
            tabPage2.Controls.Add(txtCzasCw);
            tabPage2.Controls.Add(panelSilowe);
            tabPage2.Controls.Add(panelKardio);
            tabPage2.Controls.Add(panelRozciagajace);
            tabPage2.Controls.Add(btnDodajCwiczenie);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(912, 528);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cwiczenia";
            // 
            // listBoxCwiczenia
            // 
            listBoxCwiczenia.ItemHeight = 15;
            listBoxCwiczenia.Location = new Point(8, 8);
            listBoxCwiczenia.Name = "listBoxCwiczenia";
            listBoxCwiczenia.Size = new Size(520, 454);
            listBoxCwiczenia.TabIndex = 0;
            listBoxCwiczenia.SelectedIndexChanged += listBoxCwiczenia_SelectedIndexChanged;
            // 
            // btnUsunCwiczenie
            // 
            btnUsunCwiczenie.Location = new Point(8, 473);
            btnUsunCwiczenie.Name = "btnUsunCwiczenie";
            btnUsunCwiczenie.Size = new Size(280, 30);
            btnUsunCwiczenie.TabIndex = 1;
            btnUsunCwiczenie.Text = "Usun wybrane cwiczenie";
            btnUsunCwiczenie.Click += btnUsunCwiczenie_Click;
            // 
            // lblTypCw
            // 
            lblTypCw.AutoSize = true;
            lblTypCw.Location = new Point(593, 19);
            lblTypCw.Name = "lblTypCw";
            lblTypCw.Size = new Size(83, 15);
            lblTypCw.TabIndex = 2;
            lblTypCw.Text = "Typ cwiczenia:";
            // 
            // cmbTypCwiczenia
            // 
            cmbTypCwiczenia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypCwiczenia.Items.AddRange(new object[] { "Silowe", "Kardio", "Rozciagajace" });
            cmbTypCwiczenia.Location = new Point(713, 16);
            cmbTypCwiczenia.Name = "cmbTypCwiczenia";
            cmbTypCwiczenia.Size = new Size(170, 23);
            cmbTypCwiczenia.TabIndex = 2;
            cmbTypCwiczenia.SelectedIndexChanged += cmbTypCwiczenia_SelectedIndexChanged;
            // 
            // lblNazwaCw
            // 
            lblNazwaCw.AutoSize = true;
            lblNazwaCw.Location = new Point(593, 51);
            lblNazwaCw.Name = "lblNazwaCw";
            lblNazwaCw.Size = new Size(45, 15);
            lblNazwaCw.TabIndex = 3;
            lblNazwaCw.Text = "Nazwa:";
            // 
            // txtNazwaCw
            // 
            txtNazwaCw.Location = new Point(713, 48);
            txtNazwaCw.Name = "txtNazwaCw";
            txtNazwaCw.Size = new Size(170, 23);
            txtNazwaCw.TabIndex = 3;
            // 
            // lblOpisCw
            // 
            lblOpisCw.AutoSize = true;
            lblOpisCw.Location = new Point(593, 83);
            lblOpisCw.Name = "lblOpisCw";
            lblOpisCw.Size = new Size(34, 15);
            lblOpisCw.TabIndex = 4;
            lblOpisCw.Text = "Opis:";
            // 
            // txtOpisCw
            // 
            txtOpisCw.Location = new Point(713, 80);
            txtOpisCw.Multiline = true;
            txtOpisCw.Name = "txtOpisCw";
            txtOpisCw.Size = new Size(170, 50);
            txtOpisCw.TabIndex = 4;
            // 
            // lblCzasCw
            // 
            lblCzasCw.AutoSize = true;
            lblCzasCw.Location = new Point(593, 141);
            lblCzasCw.Name = "lblCzasCw";
            lblCzasCw.Size = new Size(66, 15);
            lblCzasCw.TabIndex = 5;
            lblCzasCw.Text = "Czas (min):";
            // 
            // txtCzasCw
            // 
            txtCzasCw.Location = new Point(713, 138);
            txtCzasCw.Name = "txtCzasCw";
            txtCzasCw.Size = new Size(170, 23);
            txtCzasCw.TabIndex = 5;
            // 
            // panelSilowe
            // 
            panelSilowe.Controls.Add(lblSerie);
            panelSilowe.Controls.Add(txtSerie);
            panelSilowe.Controls.Add(lblPowtorzenia);
            panelSilowe.Controls.Add(txtPowtorzenia);
            panelSilowe.Controls.Add(lblCiezar);
            panelSilowe.Controls.Add(txtCiezar);
            panelSilowe.Location = new Point(593, 173);
            panelSilowe.Name = "panelSilowe";
            panelSilowe.Size = new Size(300, 100);
            panelSilowe.TabIndex = 6;
            panelSilowe.Visible = false;
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Location = new Point(0, 8);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(35, 15);
            lblSerie.TabIndex = 0;
            lblSerie.Text = "Serie:";
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(120, 5);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(80, 23);
            txtSerie.TabIndex = 0;
            // 
            // lblPowtorzenia
            // 
            lblPowtorzenia.AutoSize = true;
            lblPowtorzenia.Location = new Point(0, 38);
            lblPowtorzenia.Name = "lblPowtorzenia";
            lblPowtorzenia.Size = new Size(75, 15);
            lblPowtorzenia.TabIndex = 1;
            lblPowtorzenia.Text = "Powtorzenia:";
            // 
            // txtPowtorzenia
            // 
            txtPowtorzenia.Location = new Point(120, 35);
            txtPowtorzenia.Name = "txtPowtorzenia";
            txtPowtorzenia.Size = new Size(80, 23);
            txtPowtorzenia.TabIndex = 1;
            // 
            // lblCiezar
            // 
            lblCiezar.AutoSize = true;
            lblCiezar.Location = new Point(0, 68);
            lblCiezar.Name = "lblCiezar";
            lblCiezar.Size = new Size(66, 15);
            lblCiezar.TabIndex = 2;
            lblCiezar.Text = "Ciezar (kg):";
            // 
            // txtCiezar
            // 
            txtCiezar.Location = new Point(120, 65);
            txtCiezar.Name = "txtCiezar";
            txtCiezar.Size = new Size(80, 23);
            txtCiezar.TabIndex = 2;
            // 
            // panelKardio
            // 
            panelKardio.Controls.Add(lblDystans);
            panelKardio.Controls.Add(txtDystans);
            panelKardio.Controls.Add(lblIntensywnosc);
            panelKardio.Controls.Add(cmbIntensywnosc);
            panelKardio.Location = new Point(593, 173);
            panelKardio.Name = "panelKardio";
            panelKardio.Size = new Size(300, 70);
            panelKardio.TabIndex = 7;
            panelKardio.Visible = false;
            // 
            // lblDystans
            // 
            lblDystans.AutoSize = true;
            lblDystans.Location = new Point(0, 8);
            lblDystans.Name = "lblDystans";
            lblDystans.Size = new Size(79, 15);
            lblDystans.TabIndex = 0;
            lblDystans.Text = "Dystans (km):";
            // 
            // txtDystans
            // 
            txtDystans.Location = new Point(120, 5);
            txtDystans.Name = "txtDystans";
            txtDystans.Size = new Size(80, 23);
            txtDystans.TabIndex = 0;
            // 
            // lblIntensywnosc
            // 
            lblIntensywnosc.AutoSize = true;
            lblIntensywnosc.Location = new Point(0, 38);
            lblIntensywnosc.Name = "lblIntensywnosc";
            lblIntensywnosc.Size = new Size(82, 15);
            lblIntensywnosc.TabIndex = 1;
            lblIntensywnosc.Text = "Intensywnosc:";
            // 
            // cmbIntensywnosc
            // 
            cmbIntensywnosc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIntensywnosc.Items.AddRange(new object[] { "Niska", "Srednia", "Wysoka" });
            cmbIntensywnosc.Location = new Point(120, 35);
            cmbIntensywnosc.Name = "cmbIntensywnosc";
            cmbIntensywnosc.Size = new Size(100, 23);
            cmbIntensywnosc.TabIndex = 1;
            // 
            // panelRozciagajace
            // 
            panelRozciagajace.Controls.Add(lblGrupa);
            panelRozciagajace.Controls.Add(txtGrupaMiesniowa);
            panelRozciagajace.Location = new Point(593, 173);
            panelRozciagajace.Name = "panelRozciagajace";
            panelRozciagajace.Size = new Size(310, 35);
            panelRozciagajace.TabIndex = 8;
            panelRozciagajace.Visible = false;
            // 
            // lblGrupa
            // 
            lblGrupa.AutoSize = true;
            lblGrupa.Location = new Point(0, 8);
            lblGrupa.Name = "lblGrupa";
            lblGrupa.Size = new Size(102, 15);
            lblGrupa.TabIndex = 0;
            lblGrupa.Text = "Grupa miesniowa:";
            // 
            // txtGrupaMiesniowa
            // 
            txtGrupaMiesniowa.Location = new Point(120, 5);
            txtGrupaMiesniowa.Name = "txtGrupaMiesniowa";
            txtGrupaMiesniowa.Size = new Size(160, 23);
            txtGrupaMiesniowa.TabIndex = 0;
            // 
            // btnDodajCwiczenie
            // 
            btnDodajCwiczenie.Location = new Point(593, 286);
            btnDodajCwiczenie.Name = "btnDodajCwiczenie";
            btnDodajCwiczenie.Size = new Size(300, 35);
            btnDodajCwiczenie.TabIndex = 10;
            btnDodajCwiczenie.Text = "Dodaj cwiczenie";
            btnDodajCwiczenie.Click += btnDodajCwiczenie_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblCzlonekPlan);
            tabPage3.Controls.Add(cmbCzlonkowieOdPlany);
            tabPage3.Controls.Add(btnStworzPlan);
            tabPage3.Controls.Add(btnUsunPlan);
            tabPage3.Controls.Add(lblDostepne);
            tabPage3.Controls.Add(listBoxDostepneCwiczenia);
            tabPage3.Controls.Add(btnDodajDoPlan);
            tabPage3.Controls.Add(lblPlanCw);
            tabPage3.Controls.Add(listBoxPlanCwiczenia);
            tabPage3.Controls.Add(btnUsunZPlanu);
            tabPage3.Controls.Add(lblKaloriePlan);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(912, 528);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Plany";
            // 
            // lblCzlonekPlan
            // 
            lblCzlonekPlan.AutoSize = true;
            lblCzlonekPlan.Location = new Point(8, 14);
            lblCzlonekPlan.Name = "lblCzlonekPlan";
            lblCzlonekPlan.Size = new Size(52, 15);
            lblCzlonekPlan.TabIndex = 0;
            lblCzlonekPlan.Text = "Czlonek:";
            // 
            // cmbCzlonkowieOdPlany
            // 
            cmbCzlonkowieOdPlany.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCzlonkowieOdPlany.Location = new Point(75, 11);
            cmbCzlonkowieOdPlany.Name = "cmbCzlonkowieOdPlany";
            cmbCzlonkowieOdPlany.Size = new Size(320, 23);
            cmbCzlonkowieOdPlany.TabIndex = 0;
            cmbCzlonkowieOdPlany.SelectedIndexChanged += cmbCzlonkowieOdPlany_SelectedIndexChanged;
            // 
            // btnStworzPlan
            // 
            btnStworzPlan.Location = new Point(405, 9);
            btnStworzPlan.Name = "btnStworzPlan";
            btnStworzPlan.Size = new Size(150, 28);
            btnStworzPlan.TabIndex = 1;
            btnStworzPlan.Text = "Stworz plan";
            btnStworzPlan.Click += btnStworzPlan_Click;
            // 
            // btnUsunPlan
            // 
            btnUsunPlan.BackColor = Color.MistyRose;
            btnUsunPlan.Location = new Point(565, 9);
            btnUsunPlan.Name = "btnUsunPlan";
            btnUsunPlan.Size = new Size(150, 28);
            btnUsunPlan.TabIndex = 2;
            btnUsunPlan.Text = "Usun caly plan";
            btnUsunPlan.UseVisualStyleBackColor = false;
            btnUsunPlan.Click += btnUsunPlan_Click;
            // 
            // lblDostepne
            // 
            lblDostepne.AutoSize = true;
            lblDostepne.Location = new Point(8, 47);
            lblDostepne.Name = "lblDostepne";
            lblDostepne.Size = new Size(114, 15);
            lblDostepne.TabIndex = 3;
            lblDostepne.Text = "Dostepne cwiczenia:";
            // 
            // listBoxDostepneCwiczenia
            // 
            listBoxDostepneCwiczenia.ItemHeight = 15;
            listBoxDostepneCwiczenia.Location = new Point(8, 67);
            listBoxDostepneCwiczenia.Name = "listBoxDostepneCwiczenia";
            listBoxDostepneCwiczenia.Size = new Size(390, 379);
            listBoxDostepneCwiczenia.TabIndex = 2;
            // 
            // btnDodajDoPlan
            // 
            btnDodajDoPlan.Location = new Point(8, 455);
            btnDodajDoPlan.Name = "btnDodajDoPlan";
            btnDodajDoPlan.Size = new Size(390, 30);
            btnDodajDoPlan.TabIndex = 3;
            btnDodajDoPlan.Text = ">> Dodaj do planu";
            btnDodajDoPlan.Click += btnDodajDoPlan_Click;
            // 
            // lblPlanCw
            // 
            lblPlanCw.AutoSize = true;
            lblPlanCw.Location = new Point(410, 47);
            lblPlanCw.Name = "lblPlanCw";
            lblPlanCw.Size = new Size(96, 15);
            lblPlanCw.TabIndex = 4;
            lblPlanCw.Text = "Plan treningowy:";
            // 
            // listBoxPlanCwiczenia
            // 
            listBoxPlanCwiczenia.ItemHeight = 15;
            listBoxPlanCwiczenia.Location = new Point(410, 67);
            listBoxPlanCwiczenia.Name = "listBoxPlanCwiczenia";
            listBoxPlanCwiczenia.Size = new Size(390, 379);
            listBoxPlanCwiczenia.TabIndex = 4;
            // 
            // btnUsunZPlanu
            // 
            btnUsunZPlanu.Location = new Point(410, 455);
            btnUsunZPlanu.Name = "btnUsunZPlanu";
            btnUsunZPlanu.Size = new Size(390, 30);
            btnUsunZPlanu.TabIndex = 5;
            btnUsunZPlanu.Text = "<< Usun z planu";
            btnUsunZPlanu.Click += btnUsunZPlanu_Click;
            // 
            // lblKaloriePlan
            // 
            lblKaloriePlan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKaloriePlan.Location = new Point(410, 493);
            lblKaloriePlan.Name = "lblKaloriePlan";
            lblKaloriePlan.Size = new Size(390, 23);
            lblKaloriePlan.TabIndex = 6;
            lblKaloriePlan.Text = "Brak planu - utwórz plan ponizej";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listBoxStatystyki);
            tabPage4.Controls.Add(btnWszyscyKalorie);
            tabPage4.Controls.Add(btnTop3);
            tabPage4.Controls.Add(btnGrupujPoTypie);
            tabPage4.Controls.Add(btnSrednia);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(912, 528);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Statystyki";
            // 
            // listBoxStatystyki
            // 
            listBoxStatystyki.ItemHeight = 15;
            listBoxStatystyki.Location = new Point(8, 8);
            listBoxStatystyki.Name = "listBoxStatystyki";
            listBoxStatystyki.Size = new Size(580, 484);
            listBoxStatystyki.TabIndex = 0;
            // 
            // btnWszyscyKalorie
            // 
            btnWszyscyKalorie.Location = new Point(600, 8);
            btnWszyscyKalorie.Name = "btnWszyscyKalorie";
            btnWszyscyKalorie.Size = new Size(240, 45);
            btnWszyscyKalorie.TabIndex = 1;
            btnWszyscyKalorie.Text = "Kalorie wszystkich czlonkow";
            btnWszyscyKalorie.Click += btnWszyscyKalorie_Click;
            // 
            // btnTop3
            // 
            btnTop3.Location = new Point(600, 63);
            btnTop3.Name = "btnTop3";
            btnTop3.Size = new Size(240, 45);
            btnTop3.TabIndex = 2;
            btnTop3.Text = "Top 3 czlonkow";
            btnTop3.Click += btnTop3_Click;
            // 
            // btnGrupujPoTypie
            // 
            btnGrupujPoTypie.Location = new Point(600, 118);
            btnGrupujPoTypie.Name = "btnGrupujPoTypie";
            btnGrupujPoTypie.Size = new Size(240, 45);
            btnGrupujPoTypie.TabIndex = 3;
            btnGrupujPoTypie.Text = "Grupuj cwiczenia po typie";
            btnGrupujPoTypie.Click += btnGrupujPoTypie_Click;
            // 
            // btnSrednia
            // 
            btnSrednia.Location = new Point(600, 173);
            btnSrednia.Name = "btnSrednia";
            btnSrednia.Size = new Size(240, 45);
            btnSrednia.TabIndex = 4;
            btnSrednia.Text = "Srednia kalorii na plan";
            btnSrednia.Click += btnSrednia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 600);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 550);
            Name = "Form1";
            Text = "Silownia - System Zarzadzania";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panelSilowe.ResumeLayout(false);
            panelSilowe.PerformLayout();
            panelKardio.ResumeLayout(false);
            panelKardio.PerformLayout();
            panelRozciagajace.ResumeLayout(false);
            panelRozciagajace.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // ===== POLA KONTROLEK =====

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem wyjscieToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;

        // Tab 1 - Czlonkowie
        private System.Windows.Forms.ListBox listBoxCzlonkowie;
        private System.Windows.Forms.Button btnDodajCzlonka;
        private System.Windows.Forms.Button btnUsunCzlonka;
        private System.Windows.Forms.Button btnEdytujCzlonka;
        private System.Windows.Forms.Button btnAnulujEdycje;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblDataUrodzenia;
        private System.Windows.Forms.DateTimePicker dtpDataUrodzenia;
        private System.Windows.Forms.Label lblWaga;
        private System.Windows.Forms.TextBox txtWaga;

        // Tab 2 - Cwiczenia
        private System.Windows.Forms.ListBox listBoxCwiczenia;
        private System.Windows.Forms.Button btnDodajCwiczenie;
        private System.Windows.Forms.Button btnUsunCwiczenie;
        private System.Windows.Forms.Label lblTypCw;
        private System.Windows.Forms.ComboBox cmbTypCwiczenia;
        private System.Windows.Forms.Label lblNazwaCw;
        private System.Windows.Forms.TextBox txtNazwaCw;
        private System.Windows.Forms.Label lblOpisCw;
        private System.Windows.Forms.TextBox txtOpisCw;
        private System.Windows.Forms.Label lblCzasCw;
        private System.Windows.Forms.TextBox txtCzasCw;
        private System.Windows.Forms.Panel panelSilowe;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblPowtorzenia;
        private System.Windows.Forms.TextBox txtPowtorzenia;
        private System.Windows.Forms.Label lblCiezar;
        private System.Windows.Forms.TextBox txtCiezar;
        private System.Windows.Forms.Panel panelKardio;
        private System.Windows.Forms.Label lblDystans;
        private System.Windows.Forms.TextBox txtDystans;
        private System.Windows.Forms.Label lblIntensywnosc;
        private System.Windows.Forms.ComboBox cmbIntensywnosc;
        private System.Windows.Forms.Panel panelRozciagajace;
        private System.Windows.Forms.Label lblGrupa;
        private System.Windows.Forms.TextBox txtGrupaMiesniowa;

        // Tab 3 - Plany
        private System.Windows.Forms.Label lblCzlonekPlan;
        private System.Windows.Forms.ComboBox cmbCzlonkowieOdPlany;
        private System.Windows.Forms.Button btnStworzPlan;
        private System.Windows.Forms.Button btnUsunPlan;
        private System.Windows.Forms.Label lblDostepne;
        private System.Windows.Forms.ListBox listBoxDostepneCwiczenia;
        private System.Windows.Forms.Button btnDodajDoPlan;
        private System.Windows.Forms.Label lblPlanCw;
        private System.Windows.Forms.ListBox listBoxPlanCwiczenia;
        private System.Windows.Forms.Button btnUsunZPlanu;
        private System.Windows.Forms.Label lblKaloriePlan;

        // Tab 4 - Statystyki
        private System.Windows.Forms.ListBox listBoxStatystyki;
        private System.Windows.Forms.Button btnWszyscyKalorie;
        private System.Windows.Forms.Button btnTop3;
        private System.Windows.Forms.Button btnGrupujPoTypie;
        private System.Windows.Forms.Button btnSrednia;
    }
}
