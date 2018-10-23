namespace OOP_LV1
{
    partial class Form1
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPreizme = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdresaStanovanja = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtAdresaStanovanja = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxListaOsoba = new System.Windows.Forms.ListBox();
            this.cmbSortirajPo = new System.Windows.Forms.ComboBox();
            this.sfdLista_Fajl = new System.Windows.Forms.SaveFileDialog();
            this.ofdFajl_Lista = new System.Windows.Forms.OpenFileDialog();
            this.btnSortirajListu = new System.Windows.Forms.Button();
            this.btnObrisiListu = new System.Windows.Forms.Button();
            this.btnObrisiOsobu = new System.Windows.Forms.Button();
            this.btnFajl_Lista = new System.Windows.Forms.Button();
            this.btnLista_Fajl = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnZapamti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(42, 37);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(40, 20);
            this.lblIme.TabIndex = 14;
            this.lblIme.Text = "Ime:";
            // 
            // lblPreizme
            // 
            this.lblPreizme.AutoSize = true;
            this.lblPreizme.Location = new System.Drawing.Point(12, 73);
            this.lblPreizme.Name = "lblPreizme";
            this.lblPreizme.Size = new System.Drawing.Size(70, 20);
            this.lblPreizme.TabIndex = 15;
            this.lblPreizme.Text = "Prezime:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(16, 113);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(66, 20);
            this.lblTelefon.TabIndex = 16;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblAdresaStanovanja
            // 
            this.lblAdresaStanovanja.AutoSize = true;
            this.lblAdresaStanovanja.Location = new System.Drawing.Point(358, 70);
            this.lblAdresaStanovanja.Name = "lblAdresaStanovanja";
            this.lblAdresaStanovanja.Size = new System.Drawing.Size(145, 20);
            this.lblAdresaStanovanja.TabIndex = 20;
            this.lblAdresaStanovanja.Text = "Adresa stanovanja:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(358, 33);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(118, 20);
            this.lblDatumRodjenja.TabIndex = 19;
            this.lblDatumRodjenja.Text = "Datum rođenja:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(89, 30);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(252, 26);
            this.txtIme.TabIndex = 0;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            this.txtIme.Leave += new System.EventHandler(this.txtIme_Leave);
            // 
            // txtAdresaStanovanja
            // 
            this.txtAdresaStanovanja.Location = new System.Drawing.Point(362, 107);
            this.txtAdresaStanovanja.Name = "txtAdresaStanovanja";
            this.txtAdresaStanovanja.Size = new System.Drawing.Size(271, 26);
            this.txtAdresaStanovanja.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(88, 107);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(253, 26);
            this.txtTelefon.TabIndex = 2;
            this.txtTelefon.Leave += new System.EventHandler(this.txtTelefon_Leave);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(88, 67);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(253, 26);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrezime_KeyPress);
            this.txtPrezime.Leave += new System.EventHandler(this.txtPrezime_Leave);
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(495, 28);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(138, 26);
            this.dtpDatumRodjenja.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(216, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lista osoba";
            // 
            // lbxListaOsoba
            // 
            this.lbxListaOsoba.FormattingEnabled = true;
            this.lbxListaOsoba.ItemHeight = 20;
            this.lbxListaOsoba.Location = new System.Drawing.Point(16, 273);
            this.lbxListaOsoba.Name = "lbxListaOsoba";
            this.lbxListaOsoba.Size = new System.Drawing.Size(617, 244);
            this.lbxListaOsoba.TabIndex = 17;
            this.lbxListaOsoba.DoubleClick += new System.EventHandler(this.lbxListaOsoba_DoubleClick);
            // 
            // cmbSortirajPo
            // 
            this.cmbSortirajPo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortirajPo.FormattingEnabled = true;
            this.cmbSortirajPo.Items.AddRange(new object[] {
            "PO IMENU",
            "PO PREZIMENU",
            "PO DATUMU ROĐENJA"});
            this.cmbSortirajPo.Location = new System.Drawing.Point(448, 601);
            this.cmbSortirajPo.Name = "cmbSortirajPo";
            this.cmbSortirajPo.Size = new System.Drawing.Size(191, 28);
            this.cmbSortirajPo.TabIndex = 12;
            // 
            // ofdFajl_Lista
            // 
            this.ofdFajl_Lista.FileName = "openFileDialog1";
            // 
            // btnSortirajListu
            // 
            this.btnSortirajListu.Image = global::OOP_LV1.Properties.Resources._007_list;
            this.btnSortirajListu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortirajListu.Location = new System.Drawing.Point(301, 601);
            this.btnSortirajListu.Name = "btnSortirajListu";
            this.btnSortirajListu.Size = new System.Drawing.Size(141, 59);
            this.btnSortirajListu.TabIndex = 13;
            this.btnSortirajListu.Text = "Sortiraj listu:";
            this.btnSortirajListu.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSortirajListu.UseVisualStyleBackColor = true;
            this.btnSortirajListu.Click += new System.EventHandler(this.btnSortirajListu_Click);
            // 
            // btnObrisiListu
            // 
            this.btnObrisiListu.Image = global::OOP_LV1.Properties.Resources._003_can;
            this.btnObrisiListu.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnObrisiListu.Location = new System.Drawing.Point(156, 601);
            this.btnObrisiListu.Name = "btnObrisiListu";
            this.btnObrisiListu.Size = new System.Drawing.Size(125, 59);
            this.btnObrisiListu.TabIndex = 11;
            this.btnObrisiListu.Text = "Obrisi listu osoba";
            this.btnObrisiListu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiListu.UseVisualStyleBackColor = true;
            this.btnObrisiListu.Click += new System.EventHandler(this.btnObrisiListu_Click);
            // 
            // btnObrisiOsobu
            // 
            this.btnObrisiOsobu.Image = global::OOP_LV1.Properties.Resources._002_people1;
            this.btnObrisiOsobu.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnObrisiOsobu.Location = new System.Drawing.Point(12, 601);
            this.btnObrisiOsobu.Name = "btnObrisiOsobu";
            this.btnObrisiOsobu.Size = new System.Drawing.Size(118, 59);
            this.btnObrisiOsobu.TabIndex = 10;
            this.btnObrisiOsobu.Text = "Obrisi izabranu osobu";
            this.btnObrisiOsobu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiOsobu.UseVisualStyleBackColor = true;
            this.btnObrisiOsobu.Click += new System.EventHandler(this.btnObrisiOsobu_Click);
            // 
            // btnFajl_Lista
            // 
            this.btnFajl_Lista.Image = global::OOP_LV1.Properties.Resources._002_upload_1;
            this.btnFajl_Lista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFajl_Lista.Location = new System.Drawing.Point(331, 538);
            this.btnFajl_Lista.Name = "btnFajl_Lista";
            this.btnFajl_Lista.Size = new System.Drawing.Size(145, 43);
            this.btnFajl_Lista.TabIndex = 9;
            this.btnFajl_Lista.Text = "Fajl -> Lista";
            this.btnFajl_Lista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFajl_Lista.UseVisualStyleBackColor = true;
            this.btnFajl_Lista.Click += new System.EventHandler(this.btnFajl_Lista_Click);
            // 
            // btnLista_Fajl
            // 
            this.btnLista_Fajl.Image = global::OOP_LV1.Properties.Resources._001_technology1;
            this.btnLista_Fajl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLista_Fajl.Location = new System.Drawing.Point(156, 538);
            this.btnLista_Fajl.Name = "btnLista_Fajl";
            this.btnLista_Fajl.Size = new System.Drawing.Size(149, 43);
            this.btnLista_Fajl.TabIndex = 8;
            this.btnLista_Fajl.Text = "Lista -> Fajl";
            this.btnLista_Fajl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLista_Fajl.UseVisualStyleBackColor = true;
            this.btnLista_Fajl.Click += new System.EventHandler(this.btnLista_Fajl_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Image = global::OOP_LV1.Properties.Resources._006_retweet;
            this.btnAzuriraj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzuriraj.Location = new System.Drawing.Point(16, 538);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(118, 43);
            this.btnAzuriraj.TabIndex = 7;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Image = global::OOP_LV1.Properties.Resources._008_cancel1;
            this.btnPonisti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPonisti.Location = new System.Drawing.Point(333, 157);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(118, 59);
            this.btnPonisti.TabIndex = 6;
            this.btnPonisti.Text = "Ponisti";
            this.btnPonisti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnZapamti
            // 
            this.btnZapamti.Image = global::OOP_LV1.Properties.Resources._015_plus;
            this.btnZapamti.Location = new System.Drawing.Point(156, 157);
            this.btnZapamti.Name = "btnZapamti";
            this.btnZapamti.Size = new System.Drawing.Size(125, 59);
            this.btnZapamti.TabIndex = 5;
            this.btnZapamti.Text = "Zapamti";
            this.btnZapamti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZapamti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZapamti.UseVisualStyleBackColor = true;
            this.btnZapamti.Click += new System.EventHandler(this.btnZapamti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 672);
            this.Controls.Add(this.cmbSortirajPo);
            this.Controls.Add(this.btnSortirajListu);
            this.Controls.Add(this.btnObrisiListu);
            this.Controls.Add(this.btnObrisiOsobu);
            this.Controls.Add(this.btnFajl_Lista);
            this.Controls.Add(this.btnLista_Fajl);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.lbxListaOsoba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnZapamti);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdresaStanovanja);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblAdresaStanovanja);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblPreizme);
            this.Controls.Add(this.lblIme);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOProjektovanje lab. vezba 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPreizme;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdresaStanovanja;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtAdresaStanovanja;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Button btnZapamti;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxListaOsoba;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnLista_Fajl;
        private System.Windows.Forms.Button btnFajl_Lista;
        private System.Windows.Forms.Button btnObrisiOsobu;
        private System.Windows.Forms.Button btnObrisiListu;
        private System.Windows.Forms.Button btnSortirajListu;
        private System.Windows.Forms.ComboBox cmbSortirajPo;
        private System.Windows.Forms.SaveFileDialog sfdLista_Fajl;
        private System.Windows.Forms.OpenFileDialog ofdFajl_Lista;
    }
}

