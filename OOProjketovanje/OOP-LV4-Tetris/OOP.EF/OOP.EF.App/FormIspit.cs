using OOP.EF.Data;
using System;
using System.Windows.Forms;

namespace OOP.EF.App
{
    public partial class FormIspit : Form
    {
        public FormIspit()
        {
            InitializeComponent();
            LoadIspiti();
            dgvIspiti.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void LoadIspiti()
        {
            dgvIspiti.DataSource = Common.GetIspiti();
            dgvIspiti.Columns["ispit_id"].Visible = false;
            dgvIspiti.Columns["student_ispit"].Visible = false;
        }

        private bool Validacija()
        {

            if (String.IsNullOrEmpty(txtSifra.Text))
            {
                MessageBox.Show("Niste popunili polje Sifra.", "Obavestenje",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (String.IsNullOrEmpty(txtNaziv.Text))
            {
                MessageBox.Show("Niste popunili polje Naziv.", "Obavestenje",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;

        }

        private void btnObrisiIspit_Click(object sender, EventArgs e)
        {
            if (dgvIspiti.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da izvrsite izabranu akciju?", "Obavestenje",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
                return;

            int selectedIndex = dgvIspiti.SelectedRows[0].Index;
            int id = (int)dgvIspiti["ispit_id", selectedIndex].Value;
            Common.DeleteIspit(id);

            LoadIspiti();

            MessageBox.Show("Izabrani ispit je uspesno obrisan.", "Obavestenje",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDodajIspit_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            Common.AddNewIspit(txtSifra.Text, txtNaziv.Text);
            LoadIspiti();
        }
    }
}