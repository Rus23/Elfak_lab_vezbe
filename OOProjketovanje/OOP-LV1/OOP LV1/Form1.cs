using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_LV1.Extensions;
using OOP_LV1.Podaci;
using System.IO;

namespace OOP_LV1
{
    public partial class Form1 : Form
    {
        private bool rezultat;

        public Form1()
        {
            InitializeComponent();

            Init(); // Enable neke dugmice... :D 
        }

        #region MojeMetode

        private void Init()
        {
            ListaOsoba.Instance.SortListDelegate = new ListaOsoba.SortDelegate(this.Sort_CmbSortirajPo);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cmbSortirajPo.SelectedItem = "PO IMENU";
        }

        private void Sort_CmbSortirajPo()
        {
            if (cmbSortirajPo.SelectedItem.ToString() == "PO PREZIMENU")
                ListaOsoba.Instance.ListaOsobaValues.Sort((x, y) => String.Compare(x.Prezime, y.Prezime));
            else if (cmbSortirajPo.SelectedItem.ToString() == "PO DATUMU ROĐENJA")
                ListaOsoba.Instance.ListaOsobaValues.Sort((x, y) => DateTime.Compare(x.DatumRodjenja, y.DatumRodjenja));
            else
                ListaOsoba.Instance.ListaOsobaValues.Sort((x, y) => String.Compare(x.Ime, y.Ime));
        }

        private bool Validacija()
        {
            bool validno = true;
            if (String.IsNullOrEmpty(txtAdresaStanovanja.Text))
            {
                Console.Beep();
                MessageBox.Show("Polje \"Adresa stanovanja\" ne sme biti prazno!",
                    "Obavestenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                validno = false;
                txtAdresaStanovanja.Focus();
            }
            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                Console.Beep();
                MessageBox.Show("Polje \"Prezime\" ne sme biti prazno!",
                    "Obavestenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                validno = false;
                txtPrezime.Focus();
            }
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                Console.Beep();
                MessageBox.Show("Polje \"Ime\" ne sme biti prazno!",
                    "Obavestenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                validno = false;
                txtIme.Focus();
            }
                                    
            return validno;
        }
        private void Osvezi_lbxListaOsoba()
        {
            lbxListaOsoba.DataSource = ListaOsoba.Instance.ListaOsobaValues.ToList();
        }
        private void IzKontrolaUObjekat(Osoba o)
        {
            o.Ime = txtIme.Text;
            o.Prezime = txtPrezime.Text;
            o.Telefon = txtTelefon.Text;
            o.Adresa = txtAdresaStanovanja.Text;
            o.DatumRodjenja = dtpDatumRodjenja.Value;
        }
        private void izObjektaUKontrole(Osoba o)
        {
            txtIme.Text = o.Ime;
            txtPrezime.Text = o.Prezime;
            txtTelefon.Text = o.Telefon;
            txtAdresaStanovanja.Text = o.Adresa;
            dtpDatumRodjenja.Value = o.DatumRodjenja;
        }
        private void OnemoguciSveDugmiceSemZapamti()
        {
            btnAzuriraj.Enabled = false;
            btnFajl_Lista.Enabled = false;
            btnLista_Fajl.Enabled = false;
            btnObrisiListu.Enabled = false;
            btnObrisiOsobu.Enabled = false;
            btnSortirajListu.Enabled = false;
            btnPonisti.Enabled = false;
        }
        private void OmoguciSveDugimice()
        {
            btnAzuriraj.Enabled = true;
            btnFajl_Lista.Enabled = true;
            btnLista_Fajl.Enabled = true;
            btnObrisiListu.Enabled = true;
            btnObrisiOsobu.Enabled = true;
            btnSortirajListu.Enabled = true;
            btnZapamti.Enabled = true;
            btnPonisti.Enabled = true;
        }
        private void SacuvajOsobuUFajl(Osoba osoba, StreamWriter sw)
        {
            sw.WriteLine(osoba.Ime);
            sw.WriteLine(osoba.Prezime);
            sw.WriteLine(osoba.Telefon);
            sw.WriteLine(osoba.Adresa);
            sw.WriteLine(osoba.DatumRodjenja);
        }
        private void ProcitajOsobuIzFajla(Osoba osoba, StreamReader sr)
        {
            osoba.Ime = sr.ReadLine();
            osoba.Prezime = sr.ReadLine();
            osoba.Telefon = sr.ReadLine();
            osoba.Adresa = sr.ReadLine();
            osoba.DatumRodjenja = DateTime.Parse(sr.ReadLine());
        }
        private void IzListeUFajl(String path, ListaOsoba lista)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(lista.ListaOsobaValues.Count);
                foreach (var osoba in lista.ListaOsobaValues)
                {
                    SacuvajOsobuUFajl(osoba, sw);
                }
            }
        }
        private void IzFajlaUListu(string path, ListaOsoba lista)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                int n = int.Parse(sr.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Osoba osoba = new Osoba();
                    ProcitajOsobuIzFajla(osoba, sr);

                    if(!PostojiDuplikatZa(osoba))
                        ListaOsoba.Instance.ListaOsobaValues.Add(osoba);
                }

            }
        }
        private bool PostojiDuplikatZa(Osoba o)
        {
            foreach(Osoba osoba in ListaOsoba.Instance.ListaOsobaValues)
            {
                if (o.ToStringOsoba() == osoba.ToStringOsoba())
                    return true;
            }
            return false;
        }
        DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Sigurno zelite da zatvorite aplikaciju?", "Pitanje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        private void AzurirajOsobu(int i)
        {
            ListaOsoba.Instance.ListaOsobaValues[i].Ime = txtIme.Text;
            ListaOsoba.Instance.ListaOsobaValues[i].Prezime = txtPrezime.Text;
            ListaOsoba.Instance.ListaOsobaValues[i].Telefon = txtTelefon.Text;
            ListaOsoba.Instance.ListaOsobaValues[i].Adresa = txtAdresaStanovanja.Text;
            ListaOsoba.Instance.ListaOsobaValues[i].DatumRodjenja = dtpDatumRodjenja.Value;
        }
               
        #endregion

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                Console.Beep();
                e.Handled = true;
            }

        }

        private void txtPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar)) // Razlika izmedju Char. i char.
                e.Handled = true;
        }

        private void txtTelefon_Leave(object sender, EventArgs e)
        {
            if (!txtTelefon.Text.ProveriFormatZaTelefon())
            {
                MessageBox.Show("Broj telefona treba uneti u formatu:+381 11 123456",
                    "Greska",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTelefon.Focus();
            }
            

        }

        private void txtIme_Leave(object sender, EventArgs e)
        {
            txtIme.Text = txtIme.Text.PostaviPrvoVelikoSlovo();
        }

        private void txtPrezime_Leave(object sender, EventArgs e)
        {
            txtPrezime.Text = txtPrezime.Text.PostaviPrvoVelikoSlovo();
        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;
            if (btnZapamti.Text == "Zapamti")
            {
                Osoba o = new Osoba();
                IzKontrolaUObjekat(o);

                ListaOsoba.Instance.DodajOsobu(o);
            }
            else
            {
                Osoba selekOsoba = (Osoba)lbxListaOsoba.SelectedItem;
                int i = 0;
                foreach (Osoba listOsoba in ListaOsoba.Instance.ListaOsobaValues)
                {
                    if (selekOsoba.Ime == listOsoba.Ime && selekOsoba.Prezime == listOsoba.Prezime && selekOsoba.Telefon == listOsoba.Telefon)
                    {
                        AzurirajOsobu(i);
                    }
                    i++;
                }
                btnZapamti.Text = "Zapamti";
            }

            OmoguciSveDugimice();
            Osvezi_lbxListaOsoba();
            txtIme.Focus();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtTelefon.Text = "";
            txtAdresaStanovanja.Text = "";
            dtpDatumRodjenja.Value = DateTime.Now;

            btnZapamti.Text = "Zapamti";
            OmoguciSveDugimice();
            txtIme.Focus();
        }

        private void btnObrisiOsobu_Click(object sender, EventArgs e)
        {
            if (lbxListaOsoba.SelectedItem == null)
                return;

            ListaOsoba.Instance.ObrisiOsobu((Osoba)lbxListaOsoba.SelectedItem);

            Osvezi_lbxListaOsoba();
        }

        private void btnObrisiListu_Click(object sender, EventArgs e)
        {
            ListaOsoba.Instance.ObrisiListu();

            Osvezi_lbxListaOsoba();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (lbxListaOsoba.SelectedItem == null)
                return;
            izObjektaUKontrole((Osoba)lbxListaOsoba.SelectedItem);
            ListaOsoba.Instance.ObrisiOsobu((Osoba)lbxListaOsoba.SelectedItem);

            OnemoguciSveDugmiceSemZapamti();
            txtIme.Focus();

        }

        private void lbxListaOsoba_DoubleClick(object sender, EventArgs e)
        {
            izObjektaUKontrole((Osoba)lbxListaOsoba.SelectedItem);
            btnZapamti.Text = "Azuriraj";
            OnemoguciSveDugmiceSemZapamti();
            btnPonisti.Enabled = true;
        }

        private void btnLista_Fajl_Click(object sender, EventArgs e)
        {
            if (ListaOsoba.Instance.ListaOsobaValues.Count == 0)
                return;

            if(sfdLista_Fajl.ShowDialog() == DialogResult.OK)
            {
                IzListeUFajl(sfdLista_Fajl.FileName, ListaOsoba.Instance);
            }
        }

        private void btnFajl_Lista_Click(object sender, EventArgs e)
        {
            if(ofdFajl_Lista.ShowDialog() == DialogResult.OK)
            {

                IzFajlaUListu(ofdFajl_Lista.FileName, ListaOsoba.Instance);
                Osvezi_lbxListaOsoba();
            }

        }
                
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Trenutno vreme: " + DateTime.Now.TrenutnoSistmeskoVreme(),
                "Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ZatvoriFormu() == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void btnSortirajListu_Click(object sender, EventArgs e)
        {
            if (ListaOsoba.Instance.ListaOsobaValues.Count == 0)
                return;                                      

            ListaOsoba.Instance.SortListValue();
            Osvezi_lbxListaOsoba();
        }
    }
}
