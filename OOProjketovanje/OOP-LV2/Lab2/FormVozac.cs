using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Lab2.Extensions;
using System.IO;

namespace Lab2
{
    public partial class FormVozac : Form
    {
        bool azur = false;
        //Datum do kad vazi zadanja zabrana
        //Prva kategorija

        private ListaKategorija listak;
        private ListaZabrana listaz;
        String tmpbrvoz;
        bool formaClosed = false;
        String pomPath;
        
        public FormVozac(Vozac v)
            :this()
        {
            txtIme.Text = v.Ime;
            txtPrezime.Text = v.Prezime;
            txtMestoIzdavanja.Text = v.MestoIzdavanja;
            txtBrojVozackeDozvole.Text = v.Broj_vozacke_dozvole;
            tmpbrvoz = v.Broj_vozacke_dozvole;
            if (v.Pol == "M")
                cbxPol.SelectedIndex = 0;
            else if (v.Pol == "Z")
                cbxPol.SelectedIndex = 1;
            dtpDatumRodjenja.Value = v.DatumRodjenja;
            dtpOd.Value = v.VazenjeDozvole_Od;
            dtpDo.Value = v.VazenjeDozvole_Do;
            listak = v.Lk;
            listaz = v.Lz;
            ucitajzabrane();
            ucitajkategorije();
            pomPath = v.PutanjaSlike;
            pbxSlikaVozaca.Image = Image.FromFile(v.PutanjaSlike);

            this.azur = true;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        public FormVozac()
        {
            InitializeComponent();
            cbxPol.SelectedIndex = 0;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            listak = new ListaKategorija();
            listaz = new ListaZabrana();
            btnObrisiZabranu.Enabled = false;
            btnObrisiKategoriju.Enabled = false;

        }

        #region MojeMetode
        private void ErrorBox(string s)
        {
            MessageBox.Show(s, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool validacija_kontrola()
        {
            if (txtIme.Text == "")
            {
                ErrorBox("Polje ime ne sme biti prazno");
                txtIme.Focus();
                return false;
            }
            if (txtPrezime.Text == "")
            {
                ErrorBox("Polje prezime ne sme biti prazno");
                txtPrezime.Focus();
                return false;
            }
            if (txtBrojVozackeDozvole.Text == "")
            {
                ErrorBox("Polje Br. vozacke dozvole ne sme biti prazno");
                txtBrojVozackeDozvole.Focus();
                return false;
            }
            if (txtMestoIzdavanja.Text == "")
            {
                ErrorBox("Polje Mesto izdavanja ne sme biti prazno");
                txtMestoIzdavanja.Focus();
                return false;
            }
            if (pbxSlikaVozaca.Image == null)
            {
                ErrorBox("Svaki vozac mora imati sliku");
                btnDodajSliku.Focus();
                return false;
            }
            return true;
        }

        private void ucitajzabrane()
        {
            dgvZabranjenoUpravljanje.DataSource = this.listaz.ListaZabranaValues.ToList();
            dgvZabranjenoUpravljanje.Columns["DatumDo"].Visible = false;
            dgvZabranjenoUpravljanje.Columns["DatumOd"].Visible = false;


            if (dgvZabranjenoUpravljanje.RowCount > 0)
            {
                btnObrisiZabranu.Enabled = true;
            }
            else
            {
                btnObrisiZabranu.Enabled = false;
                
            }

        }
        private void ucitajkategorije()
        {
            dgvKategorija.DataSource = this.listak.ListaKategorijaValues.ToList();

            dgvKategorija.Columns["DatumDo"].Visible = false;
            dgvKategorija.Columns["DatumOd"].Visible = false;


            if (dgvKategorija.RowCount > 0)
            {
                btnObrisiKategoriju.Enabled = true;
            }
            else
            {
                btnObrisiKategoriju.Enabled = false;

            }
        }

        #endregion

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!validacija_kontrola())
                return;
            if(listak.ListaKategorijaValues.Count==0)
            {
                MessageBox.Show("Vozac mora imati bar jednu kategoriju", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDodajNovuKategoriju.Focus();
                return;
            }
            if (!azur)
            {
                String ime = txtIme.Text;
                String prezime = txtPrezime.Text;
                DateTime datrodj = dtpDatumRodjenja.Value;
                DateTime datod = dtpOd.Value;
                DateTime datdo = dtpDo.Value;
                String brdozvole = txtBrojVozackeDozvole.Text;
                String mestoizdavanja = txtMestoIzdavanja.Text;
                String pol;
                if (cbxPol.SelectedIndex == 0)
                    pol = "M";
                else
                    pol = "Z";
                Vozac v = new Vozac(ime, prezime, brdozvole, mestoizdavanja, pol, datrodj, datod, datdo, listak, listaz);
                if(pbxSlikaVozaca==null || pbxSlikaVozaca.Image==null)
                {
                    MessageBox.Show("Vozac se ne moze ubaciti bez slike!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnDodajSliku.Focus();
                    return;
                }
                else
                {
                    this.SacuvajSliku(v);
                }
                if (!ListaVozaca.Instanca.DodajVozaca(v))
                {
                    MessageBox.Show("Vozac nije uspesno dodat", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
                                
            }
            else
            {
                Vozac v = ListaVozaca.Instanca.GetVozac(tmpbrvoz);
                ListaVozaca.Instanca.ObrisiVozaca(v.Broj_vozacke_dozvole);

                v.Ime = txtIme.Text;
                v.Prezime = txtPrezime.Text;
                v.MestoIzdavanja = txtMestoIzdavanja.Text;
                v.Pol = cbxPol.SelectedItem.ToString();
                v.DatumRodjenja = dtpDatumRodjenja.Value;
                v.VazenjeDozvole_Od = dtpOd.Value;
                v.VazenjeDozvole_Do = dtpDo.Value;
                v.Lk = this.listak;
                v.Lz = this.listaz;
                v.Broj_vozacke_dozvole = txtBrojVozackeDozvole.Text;
                v.PutanjaSlike = pomPath;
                
                SacuvajSliku(v);
                ListaVozaca.Instanca.DodajVozaca(v);

                azur = false;              
                MessageBox.Show("Vozac je uspesno azuriran", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            formaClosed = true;
            
            this.Close();
            this.DialogResult = DialogResult.OK;

        }
        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true; 
        }

        private void txtPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtBrojVozackeDozvole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMestoIzdavanja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnDodajNovuKategoriju_Click(object sender, EventArgs e)
        {
            var frm = new FormKategorija();

            DialogResult dg = frm.ShowDialog();
            if (dg == System.Windows.Forms.DialogResult.OK)
            {
                Kategorija k = new Kategorija(frm.Kategorija, frm.DatOd, frm.DatDo);
                listak.DodajKategoriju(k);
                ucitajkategorije();
            }
        }

        private void btnDodajNovuZabranu_Click(object sender, EventArgs e)
        {
            if (listak.ListaKategorijaValues.Count==0)
            {
                MessageBox.Show("Nema kategorija pa ne moze biti ni kazni", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var frm = new FormZabrana(listak);

            DialogResult dg = frm.ShowDialog();
            if (dg == System.Windows.Forms.DialogResult.OK)
            {
                Zabrana z = new Zabrana(frm.Kategorija, frm.DatOd, frm.DatDo);
                listaz.DodajZabranu(z);
                ucitajzabrane();

            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show("Da li ste sigurni da zelite da zatvorite ovu formu?",
                                              "Obavestenje",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (di == DialogResult.Yes)
            {
                formaClosed = true;
                this.Close();

            }
        }

        private void FormVozac_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formaClosed)
                return;
            else
            {
                var res = MessageBox.Show(this, "Da li ste sigurni da zelite da zatvorite ovu formu", "Obavestenje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;

                }
            }
        }

        private void btnObrisiKategoriju_Click(object sender, EventArgs e)
        {
            int rowindex = dgvKategorija.CurrentCell.RowIndex;
            int columnindex = dgvKategorija.CurrentCell.ColumnIndex;
            String pom = dgvKategorija.Rows[rowindex].Cells["KategorijaValue"].Value.ToString();
            bool brisanje = listak.ObrisiKategoriju(pom);
            if (brisanje)
                MessageBox.Show("Uspesno ste obrisali kategoriju", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Brisanje kategorije nije uspesno", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ucitajkategorije();
        }

        private void btnObrisiZabranu_Click(object sender, EventArgs e)
        {
            int rowindex = dgvZabranjenoUpravljanje.CurrentCell.RowIndex;
            int columnindex = dgvZabranjenoUpravljanje.CurrentCell.ColumnIndex;
            String pom = dgvZabranjenoUpravljanje.Rows[rowindex].Cells["Kategorija"].Value.ToString();
            bool brisanje = listaz.ObrisiZabranu(pom);
            if (brisanje)
                MessageBox.Show("Uspesno ste obrisali kategoriju", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Brisanje kategorije nije uspesno", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ucitajzabrane();
        }
        private void SacuvajSliku(Vozac v)
        {
            v.PutanjaSlike = this.pomPath;
        }
        
        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            if (ofdSlika.ShowDialog() == DialogResult.OK)
            {                
                pbxSlikaVozaca.Image = Image.FromFile(ofdSlika.FileName);
                pomPath = Path.Combine(ofdSlika.InitialDirectory,ofdSlika.FileName);
            }
        }

        private void txtBrojVozackeDozvole_Leave(object sender, EventArgs e)
        {

        }

        private void txtIme_Leave(object sender, EventArgs e)
        {
            txtIme.Text = txtIme.Text.PostaviPrvoVelikoSlovo();
        }

        private void txtPrezime_Leave(object sender, EventArgs e)
        {
            txtPrezime.Text = txtPrezime.Text.PostaviPrvoVelikoSlovo();
        }
    }
}
