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

namespace Lab2
{
    public partial class GlavnaForma : Form
    {
        System.Collections.SortedList komboboks = new System.Collections.SortedList();
        public GlavnaForma()
        {
            InitializeComponent();
            Init();
         
        }
        private void Init()
        {
            btnIzmeniVozaca.Enabled = false;
            btnIzbrisiVozaca.Enabled = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            btnIzmeniVozaca.Enabled = false;

        }

        private void UcitajPodatke()
        {
            dgvListaVozaca.DataSource = ListaVozaca.Instanca.ListaVozacaValues.ToList();
            dgvListaVozaca.Columns["ZaPrikaz"].Visible = false;
            dgvListaVozaca.Columns["MestoIzdavanja"].Visible = false;
            dgvListaVozaca.Columns["Pol"].Visible = false;
            dgvListaVozaca.Columns["DatumRodjenja"].Visible = false;
            //dgvListaVozaca.Columns["VazenjeDozvole_Od"].Visible = false;
            dgvListaVozaca.Columns["VazenjeDozvole_Do"].Visible = false;
            dgvListaVozaca.Columns["Lk"].Visible = false;
            dgvListaVozaca.Columns["Lz"].Visible = false;
            dgvListaVozaca.Columns["PutanjaSlike"].Visible = false;


            if (dgvListaVozaca.RowCount>0)
            {
                btnIzbrisiVozaca.Enabled = true;
                btnIzmeniVozaca.Enabled = true;
            }
            else
            {
                btnIzmeniVozaca.Enabled = false;
                btnIzmeniVozaca.Enabled = false;
            }

        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            komboboks.Add("PO IMENU", new ListaVozaca.SortDelagate(this.SortIme));
            komboboks.Add("PO PREZIMENU", new ListaVozaca.SortDelagate(this.SortPrezime));
            komboboks.Add("PO BROJU VOZACKE DOZVOLE", new ListaVozaca.SortDelagate(this.SortVozacka));
          
            cbxBiraj.DataSource = komboboks.Keys;
            lblTacnoVreme.Text = "";
            timer1.Start();
        }
        private void SortIme()
        {
            ListaVozaca.Instanca.ListaVozacaValues.Sort((o1, o2) => o1.Ime.CompareTo(o2.Ime));
        }
        private void SortPrezime()
        {
            ListaVozaca.Instanca.ListaVozacaValues.Sort((o1, o2) => o1.Prezime.CompareTo(o2.Prezime));
        }
        private void SortVozacka()
        {
            ListaVozaca.Instanca.ListaVozacaValues.Sort((o1, o2) => o1.Broj_vozacke_dozvole.CompareTo(o2.Broj_vozacke_dozvole));
        }
        private void dgvListaVozaca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDodajVozaca_Click(object sender, EventArgs e)
        {

            var form = new FormVozac();
            DialogResult dg = form.ShowDialog();
            if (dg == System.Windows.Forms.DialogResult.OK)
                UcitajPodatke();

        }

        private void btnIzmeniVozaca_Click(object sender, EventArgs e)
        {
            if(dgvListaVozaca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati ceo red!!!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int rowindex = dgvListaVozaca.CurrentCell.RowIndex;
            int columnindex = dgvListaVozaca.CurrentCell.ColumnIndex;

            String pom=dgvListaVozaca.Rows[rowindex].Cells["Broj_vozacke_dozvole"].Value.ToString();
          
            Vozac v = ListaVozaca.Instanca.GetVozac(pom.ToString());

            var form = new FormVozac(v);
            DialogResult dg = form.ShowDialog();
            if (dg == System.Windows.Forms.DialogResult.OK)
                UcitajPodatke();
        }

        private void cbxBiraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaVozaca.SortDelagate sd = (ListaVozaca.SortDelagate)komboboks[cbxBiraj.Text];
            sd();
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            ListaVozaca.Instanca.SortListValue();
            MessageBox.Show("Sortiranje uspesno zavrseno", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UcitajPodatke();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String str = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy."); //time pa property na i na koliko ms da se nesto desava
            lblTacnoVreme.Text = str;
        }

        private void btnIzbrisiVozaca_Click(object sender, EventArgs e)
        {
            int rowindex = dgvListaVozaca.CurrentCell.RowIndex;
            int columnindex = dgvListaVozaca.CurrentCell.ColumnIndex;

            String pom = dgvListaVozaca.Rows[rowindex].Cells["Broj_vozacke_dozvole"].Value.ToString();
            Vozac v = ListaVozaca.Instanca.GetVozac(pom.ToString());
            ListaVozaca.Instanca.ObrisiVozaca(v);
            UcitajPodatke();
        }
    }
}
