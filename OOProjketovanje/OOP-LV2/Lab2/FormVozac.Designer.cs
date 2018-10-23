namespace Lab2
{
    partial class FormVozac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVozac));
            this.lblIme = new System.Windows.Forms.Label();
            this.gbxOsnovniPodaci = new System.Windows.Forms.GroupBox();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.pbxSlikaVozaca = new System.Windows.Forms.PictureBox();
            this.lblPol = new System.Windows.Forms.Label();
            this.cbxPol = new System.Windows.Forms.ComboBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.txtMestoIzdavanja = new System.Windows.Forms.TextBox();
            this.txtBrojVozackeDozvole = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblMestoIzdavanja = new System.Windows.Forms.Label();
            this.lblBrVozackeDozvole = new System.Windows.Forms.Label();
            this.lblVazenjeDozvoleDo = new System.Windows.Forms.Label();
            this.lblVazenjeDozvoleOd = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.dgvKategorija = new System.Windows.Forms.DataGridView();
            this.gbxKategorija = new System.Windows.Forms.GroupBox();
            this.btnObrisiKategoriju = new System.Windows.Forms.Button();
            this.btnDodajNovuKategoriju = new System.Windows.Forms.Button();
            this.gbxZabranaUpravljanja = new System.Windows.Forms.GroupBox();
            this.btnObrisiZabranu = new System.Windows.Forms.Button();
            this.btnDodajNovuZabranu = new System.Windows.Forms.Button();
            this.dgvZabranjenoUpravljanje = new System.Windows.Forms.DataGridView();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.gbxOsnovniPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlikaVozaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorija)).BeginInit();
            this.gbxKategorija.SuspendLayout();
            this.gbxZabranaUpravljanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabranjenoUpravljanje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(103, 18);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(33, 16);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // gbxOsnovniPodaci
            // 
            this.gbxOsnovniPodaci.Controls.Add(this.dtpDo);
            this.gbxOsnovniPodaci.Controls.Add(this.dtpOd);
            this.gbxOsnovniPodaci.Controls.Add(this.dtpDatumRodjenja);
            this.gbxOsnovniPodaci.Controls.Add(this.pbxSlikaVozaca);
            this.gbxOsnovniPodaci.Controls.Add(this.lblPol);
            this.gbxOsnovniPodaci.Controls.Add(this.cbxPol);
            this.gbxOsnovniPodaci.Controls.Add(this.btnDodajSliku);
            this.gbxOsnovniPodaci.Controls.Add(this.txtMestoIzdavanja);
            this.gbxOsnovniPodaci.Controls.Add(this.txtBrojVozackeDozvole);
            this.gbxOsnovniPodaci.Controls.Add(this.txtPrezime);
            this.gbxOsnovniPodaci.Controls.Add(this.txtIme);
            this.gbxOsnovniPodaci.Controls.Add(this.lblMestoIzdavanja);
            this.gbxOsnovniPodaci.Controls.Add(this.lblBrVozackeDozvole);
            this.gbxOsnovniPodaci.Controls.Add(this.lblVazenjeDozvoleDo);
            this.gbxOsnovniPodaci.Controls.Add(this.lblVazenjeDozvoleOd);
            this.gbxOsnovniPodaci.Controls.Add(this.lblDatumRodjenja);
            this.gbxOsnovniPodaci.Controls.Add(this.lblPrezime);
            this.gbxOsnovniPodaci.Controls.Add(this.lblIme);
            this.gbxOsnovniPodaci.Location = new System.Drawing.Point(13, 2);
            this.gbxOsnovniPodaci.Margin = new System.Windows.Forms.Padding(4);
            this.gbxOsnovniPodaci.Name = "gbxOsnovniPodaci";
            this.gbxOsnovniPodaci.Padding = new System.Windows.Forms.Padding(4);
            this.gbxOsnovniPodaci.Size = new System.Drawing.Size(592, 292);
            this.gbxOsnovniPodaci.TabIndex = 1;
            this.gbxOsnovniPodaci.TabStop = false;
            this.gbxOsnovniPodaci.Text = "Osnovni podaci";
            // 
            // dtpDo
            // 
            this.dtpDo.CustomFormat = "dd.MM.yy";
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDo.Location = new System.Drawing.Point(143, 140);
            this.dtpDo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(151, 22);
            this.dtpDo.TabIndex = 20;
            // 
            // dtpOd
            // 
            this.dtpOd.CustomFormat = "dd.MM.yy";
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOd.Location = new System.Drawing.Point(143, 111);
            this.dtpOd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(151, 22);
            this.dtpOd.TabIndex = 19;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.CustomFormat = "dd.MM.yy";
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(143, 80);
            this.dtpDatumRodjenja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(151, 22);
            this.dtpDatumRodjenja.TabIndex = 18;
            // 
            // pbxSlikaVozaca
            // 
            this.pbxSlikaVozaca.Location = new System.Drawing.Point(301, 12);
            this.pbxSlikaVozaca.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSlikaVozaca.Name = "pbxSlikaVozaca";
            this.pbxSlikaVozaca.Size = new System.Drawing.Size(208, 178);
            this.pbxSlikaVozaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSlikaVozaca.TabIndex = 17;
            this.pbxSlikaVozaca.TabStop = false;
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(96, 250);
            this.lblPol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(31, 16);
            this.lblPol.TabIndex = 16;
            this.lblPol.Text = "Pol:";
            // 
            // cbxPol
            // 
            this.cbxPol.FormattingEnabled = true;
            this.cbxPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cbxPol.Location = new System.Drawing.Point(143, 242);
            this.cbxPol.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPol.Name = "cbxPol";
            this.cbxPol.Size = new System.Drawing.Size(133, 24);
            this.cbxPol.TabIndex = 15;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(397, 198);
            this.btnDodajSliku.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(112, 41);
            this.btnDodajSliku.TabIndex = 14;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // txtMestoIzdavanja
            // 
            this.txtMestoIzdavanja.Location = new System.Drawing.Point(143, 205);
            this.txtMestoIzdavanja.Margin = new System.Windows.Forms.Padding(4);
            this.txtMestoIzdavanja.Name = "txtMestoIzdavanja";
            this.txtMestoIzdavanja.Size = new System.Drawing.Size(219, 22);
            this.txtMestoIzdavanja.TabIndex = 13;
            this.txtMestoIzdavanja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMestoIzdavanja_KeyPress);
            // 
            // txtBrojVozackeDozvole
            // 
            this.txtBrojVozackeDozvole.Location = new System.Drawing.Point(142, 172);
            this.txtBrojVozackeDozvole.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojVozackeDozvole.Name = "txtBrojVozackeDozvole";
            this.txtBrojVozackeDozvole.Size = new System.Drawing.Size(152, 22);
            this.txtBrojVozackeDozvole.TabIndex = 12;
            this.txtBrojVozackeDozvole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrojVozackeDozvole_KeyPress);
            this.txtBrojVozackeDozvole.Leave += new System.EventHandler(this.txtBrojVozackeDozvole_Leave);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(142, 44);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(152, 22);
            this.txtPrezime.TabIndex = 8;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrezime_KeyPress);
            this.txtPrezime.Leave += new System.EventHandler(this.txtPrezime_Leave);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(143, 12);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(151, 22);
            this.txtIme.TabIndex = 7;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            this.txtIme.Leave += new System.EventHandler(this.txtIme_Leave);
            // 
            // lblMestoIzdavanja
            // 
            this.lblMestoIzdavanja.AutoSize = true;
            this.lblMestoIzdavanja.Location = new System.Drawing.Point(27, 208);
            this.lblMestoIzdavanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMestoIzdavanja.Name = "lblMestoIzdavanja";
            this.lblMestoIzdavanja.Size = new System.Drawing.Size(109, 16);
            this.lblMestoIzdavanja.TabIndex = 6;
            this.lblMestoIzdavanja.Text = "Mesto izdavanja:";
            // 
            // lblBrVozackeDozvole
            // 
            this.lblBrVozackeDozvole.AutoSize = true;
            this.lblBrVozackeDozvole.Location = new System.Drawing.Point(7, 176);
            this.lblBrVozackeDozvole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrVozackeDozvole.Name = "lblBrVozackeDozvole";
            this.lblBrVozackeDozvole.Size = new System.Drawing.Size(129, 16);
            this.lblBrVozackeDozvole.TabIndex = 5;
            this.lblBrVozackeDozvole.Text = "Br.vozacke dozvole:";
            // 
            // lblVazenjeDozvoleDo
            // 
            this.lblVazenjeDozvoleDo.AutoSize = true;
            this.lblVazenjeDozvoleDo.Location = new System.Drawing.Point(109, 146);
            this.lblVazenjeDozvoleDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVazenjeDozvoleDo.Name = "lblVazenjeDozvoleDo";
            this.lblVazenjeDozvoleDo.Size = new System.Drawing.Size(27, 16);
            this.lblVazenjeDozvoleDo.TabIndex = 4;
            this.lblVazenjeDozvoleDo.Text = "do:";
            // 
            // lblVazenjeDozvoleOd
            // 
            this.lblVazenjeDozvoleOd.AutoSize = true;
            this.lblVazenjeDozvoleOd.Location = new System.Drawing.Point(6, 117);
            this.lblVazenjeDozvoleOd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVazenjeDozvoleOd.Name = "lblVazenjeDozvoleOd";
            this.lblVazenjeDozvoleOd.Size = new System.Drawing.Size(130, 16);
            this.lblVazenjeDozvoleOd.TabIndex = 3;
            this.lblVazenjeDozvoleOd.Text = "Vazenje dozvole od:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(34, 85);
            this.lblDatumRodjenja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(102, 16);
            this.lblDatumRodjenja.TabIndex = 2;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(76, 50);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(60, 16);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // dgvKategorija
            // 
            this.dgvKategorija.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvKategorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorija.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvKategorija.Location = new System.Drawing.Point(0, 23);
            this.dgvKategorija.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKategorija.Name = "dgvKategorija";
            this.dgvKategorija.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKategorija.Size = new System.Drawing.Size(554, 89);
            this.dgvKategorija.TabIndex = 2;
            // 
            // gbxKategorija
            // 
            this.gbxKategorija.Controls.Add(this.btnObrisiKategoriju);
            this.gbxKategorija.Controls.Add(this.btnDodajNovuKategoriju);
            this.gbxKategorija.Controls.Add(this.dgvKategorija);
            this.gbxKategorija.Location = new System.Drawing.Point(13, 302);
            this.gbxKategorija.Margin = new System.Windows.Forms.Padding(4);
            this.gbxKategorija.Name = "gbxKategorija";
            this.gbxKategorija.Padding = new System.Windows.Forms.Padding(4);
            this.gbxKategorija.Size = new System.Drawing.Size(592, 175);
            this.gbxKategorija.TabIndex = 3;
            this.gbxKategorija.TabStop = false;
            this.gbxKategorija.Text = "Kategorija";
            // 
            // btnObrisiKategoriju
            // 
            this.btnObrisiKategoriju.Image = ((System.Drawing.Image)(resources.GetObject("btnObrisiKategoriju.Image")));
            this.btnObrisiKategoriju.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiKategoriju.Location = new System.Drawing.Point(390, 120);
            this.btnObrisiKategoriju.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiKategoriju.Name = "btnObrisiKategoriju";
            this.btnObrisiKategoriju.Size = new System.Drawing.Size(164, 44);
            this.btnObrisiKategoriju.TabIndex = 4;
            this.btnObrisiKategoriju.Text = "Obrisi kategoriju";
            this.btnObrisiKategoriju.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiKategoriju.UseVisualStyleBackColor = true;
            this.btnObrisiKategoriju.Click += new System.EventHandler(this.btnObrisiKategoriju_Click);
            // 
            // btnDodajNovuKategoriju
            // 
            this.btnDodajNovuKategoriju.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajNovuKategoriju.Image")));
            this.btnDodajNovuKategoriju.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajNovuKategoriju.Location = new System.Drawing.Point(8, 120);
            this.btnDodajNovuKategoriju.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajNovuKategoriju.Name = "btnDodajNovuKategoriju";
            this.btnDodajNovuKategoriju.Size = new System.Drawing.Size(135, 44);
            this.btnDodajNovuKategoriju.TabIndex = 3;
            this.btnDodajNovuKategoriju.Text = "Dodaj novu kategoriju";
            this.btnDodajNovuKategoriju.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajNovuKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajNovuKategoriju.Click += new System.EventHandler(this.btnDodajNovuKategoriju_Click);
            // 
            // gbxZabranaUpravljanja
            // 
            this.gbxZabranaUpravljanja.Controls.Add(this.btnObrisiZabranu);
            this.gbxZabranaUpravljanja.Controls.Add(this.btnDodajNovuZabranu);
            this.gbxZabranaUpravljanja.Controls.Add(this.dgvZabranjenoUpravljanje);
            this.gbxZabranaUpravljanja.Location = new System.Drawing.Point(13, 485);
            this.gbxZabranaUpravljanja.Margin = new System.Windows.Forms.Padding(4);
            this.gbxZabranaUpravljanja.Name = "gbxZabranaUpravljanja";
            this.gbxZabranaUpravljanja.Padding = new System.Windows.Forms.Padding(4);
            this.gbxZabranaUpravljanja.Size = new System.Drawing.Size(592, 183);
            this.gbxZabranaUpravljanja.TabIndex = 4;
            this.gbxZabranaUpravljanja.TabStop = false;
            this.gbxZabranaUpravljanja.Text = "Zabrana upravljanja";
            // 
            // btnObrisiZabranu
            // 
            this.btnObrisiZabranu.Image = ((System.Drawing.Image)(resources.GetObject("btnObrisiZabranu.Image")));
            this.btnObrisiZabranu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiZabranu.Location = new System.Drawing.Point(387, 131);
            this.btnObrisiZabranu.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiZabranu.Name = "btnObrisiZabranu";
            this.btnObrisiZabranu.Size = new System.Drawing.Size(167, 38);
            this.btnObrisiZabranu.TabIndex = 2;
            this.btnObrisiZabranu.Text = "Obrisi zabranu";
            this.btnObrisiZabranu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiZabranu.UseVisualStyleBackColor = true;
            this.btnObrisiZabranu.Click += new System.EventHandler(this.btnObrisiZabranu_Click);
            // 
            // btnDodajNovuZabranu
            // 
            this.btnDodajNovuZabranu.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajNovuZabranu.Image")));
            this.btnDodajNovuZabranu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajNovuZabranu.Location = new System.Drawing.Point(0, 131);
            this.btnDodajNovuZabranu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajNovuZabranu.Name = "btnDodajNovuZabranu";
            this.btnDodajNovuZabranu.Size = new System.Drawing.Size(160, 38);
            this.btnDodajNovuZabranu.TabIndex = 1;
            this.btnDodajNovuZabranu.Text = "Dodaj novu zabranu";
            this.btnDodajNovuZabranu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajNovuZabranu.UseVisualStyleBackColor = true;
            this.btnDodajNovuZabranu.Click += new System.EventHandler(this.btnDodajNovuZabranu_Click);
            // 
            // dgvZabranjenoUpravljanje
            // 
            this.dgvZabranjenoUpravljanje.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvZabranjenoUpravljanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZabranjenoUpravljanje.Location = new System.Drawing.Point(0, 23);
            this.dgvZabranjenoUpravljanje.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZabranjenoUpravljanje.Name = "dgvZabranjenoUpravljanje";
            this.dgvZabranjenoUpravljanje.Size = new System.Drawing.Size(555, 100);
            this.dgvZabranjenoUpravljanje.TabIndex = 0;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(13, 676);
            this.btnProsledi.Margin = new System.Windows.Forms.Padding(4);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(117, 39);
            this.btnProsledi.TabIndex = 5;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(400, 676);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(110, 39);
            this.btnZatvori.TabIndex = 6;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // FormVozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 728);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.gbxZabranaUpravljanja);
            this.Controls.Add(this.gbxKategorija);
            this.Controls.Add(this.gbxOsnovniPodaci);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(634, 780);
            this.MinimumSize = new System.Drawing.Size(634, 780);
            this.Name = "FormVozac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozac";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVozac_FormClosing);
            this.gbxOsnovniPodaci.ResumeLayout(false);
            this.gbxOsnovniPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlikaVozaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorija)).EndInit();
            this.gbxKategorija.ResumeLayout(false);
            this.gbxZabranaUpravljanja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabranjenoUpravljanje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.GroupBox gbxOsnovniPodaci;
        private System.Windows.Forms.Label lblBrVozackeDozvole;
        private System.Windows.Forms.Label lblVazenjeDozvoleDo;
        private System.Windows.Forms.Label lblVazenjeDozvoleOd;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblMestoIzdavanja;
        private System.Windows.Forms.TextBox txtMestoIzdavanja;
        private System.Windows.Forms.TextBox txtBrojVozackeDozvole;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.DataGridView dgvKategorija;
        private System.Windows.Forms.ComboBox cbxPol;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.GroupBox gbxKategorija;
        private System.Windows.Forms.Button btnDodajNovuKategoriju;
        private System.Windows.Forms.Button btnObrisiKategoriju;
        private System.Windows.Forms.GroupBox gbxZabranaUpravljanja;
        private System.Windows.Forms.DataGridView dgvZabranjenoUpravljanje;
        private System.Windows.Forms.Button btnDodajNovuZabranu;
        private System.Windows.Forms.Button btnObrisiZabranu;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.PictureBox pbxSlikaVozaca;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
    }
}