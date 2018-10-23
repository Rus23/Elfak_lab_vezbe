using OOP.EF.Data;
using System;
using System.Windows.Forms;

namespace OOP.EF.App
{
    public partial class FormMain : Form
    {
        #region Constructors

        public FormMain()
        {
            InitializeComponent();

            dgvIspiti.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTelefon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        #endregion

        #region Methodes

        public void LoadStudenti()
        {
            cmbStudenti.DisplayMember = "ZaPrikaz";
            cmbStudenti.ValueMember = "Id";

            cmbStudenti.DataSource = Common.GetStudenti();
        }

        public void LoadIspiti()
        {
            if (cmbStudenti.SelectedValue == null)
                return;

            long studentId = (long)cmbStudenti.SelectedValue;

            dgvIspiti.DataSource = Common.GetIspitiAll(studentId);
            dgvIspiti.Columns["student_ispit_id"].Visible = false;
            dgvIspiti.Columns["ispit_id"].Visible = false;
        }

        public void LoadTelefon()
        {
            if (cmbStudenti.SelectedValue == null)
                return;

            long studentId = (long)cmbStudenti.SelectedValue;
            dgvTelefon.DataSource = Common.GetTelefon(studentId);
            dgvTelefon.Columns["student_telefon_id"].Visible = false;
        }

        #endregion

        #region Events

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadStudenti();
        }

        private void cmbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIspiti();
            LoadTelefon();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Da li ste sigurni?", "Obavestenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            DialogResult dlg = FormStudent.AddNewStudent();
            if (dlg == DialogResult.Yes)
            {
                LoadStudenti();
                MessageBox.Show("Student je uspesno dodat.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIzmeniStudenta_Click(object sender, EventArgs e)
        {
            if (cmbStudenti.SelectedValue == null)
                return;

            long studentId = (long)cmbStudenti.SelectedValue;

            DialogResult dlg = FormStudent.UpdateStudent(studentId);
            if (dlg == DialogResult.Yes)
            {
                LoadStudenti();
                MessageBox.Show("Student je uspesno azuriran.", "Obavestenje",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbStudenti.SelectedValue = studentId;
            }
        }

        private void btnObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (cmbStudenti.SelectedValue == null)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da izvrsite izabranu akciju?", "Obavestenje",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
                return;

            long studentId = (long)cmbStudenti.SelectedValue;

            Common.DeleteStudent(studentId);

            LoadStudenti();
            MessageBox.Show("Student je uspesno obrisan.", "Obavestenje",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDodajTelefon_Click(object sender, EventArgs e)
        {
            if (cmbStudenti.SelectedValue == null)
                return;

            using (var frm = new FormDodajTelefon())
            {
                long id = (long)cmbStudenti.SelectedValue;
                frm.StudentId = id;
                if (frm.ShowDialog() == DialogResult.Yes)
                    LoadTelefon();
            }
        }

        private void btnObrisiTelefon_Click(object sender, EventArgs e)
        {
            if (dgvTelefon.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da izvrsite izabranu akciju?", "Obavestenje",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
                return;

            int selectedIndex = dgvTelefon.SelectedRows[0].Index;
            long id = (long)dgvTelefon["student_telefon_id", selectedIndex].Value;
            Common.DeleteTelefon(id);

            LoadTelefon();

            MessageBox.Show("Izabrani telefon je uspesno obrisan.", "Obavestenje",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIspiti_Click(object sender, EventArgs e)
        {
            using (var frm = new FormIspit())
            {
                frm.ShowDialog();
            }
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
            long id = (long)dgvIspiti["student_ispit_id", selectedIndex].Value;

            Common.DeleteStudentIspit(id);

            LoadIspiti();

            MessageBox.Show("Izabrani ispit je uspesno obrisan.", "Obavestenje",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDodajIspit_Click(object sender, EventArgs e)
        {
            if (cmbStudenti.SelectedValue == null)
                return;

            long studentId = (long)cmbStudenti.SelectedValue;

            var frm = new FormDodajIspit();
            frm.StudentId = studentId;

            DialogResult dlg = frm.ShowDialog();

            if (dlg == DialogResult.Yes)
            {
                LoadIspiti();
                MessageBox.Show("Ispit je uspesno dodat.", "Obavestenje",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
