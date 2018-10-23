using OOP.EF.Data;
using System;
using System.Windows.Forms;

namespace OOP.EF.App
{
    public partial class FormStudent : Form
    {
        #region Atributes

        private student _selectedStudent;

        #endregion

        #region Constructors

        public FormStudent()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public student SelectedStudent
        {
            get
            {
                return _selectedStudent;
            }

            set
            {
                _selectedStudent = value;
                LoadPodaciToConstrols();
            }
        }

        #endregion

        #region Methodes

        private void LoadPodaciToConstrols()
        {
            if (_selectedStudent != null)
            {
                txtIme.Text = _selectedStudent.ime;
                txtPrezime.Text = _selectedStudent.prezime;
                txtIndeks.Text = _selectedStudent.index.ToString(); ;
            }
        }


        private bool Validacija()
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Niste popunili polje Ime.", "Obavestenje",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Niste popunili polje Prezime.", "Obavestenje",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (String.IsNullOrEmpty(txtIndeks.Text))
            {
                MessageBox.Show("Niste popunili polje Indeks.", "Obavestenje",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void AddNew()
        {
            int indeks = Int32.Parse(txtIndeks.Text);
            Common.AddNewStudent(txtIme.Text, txtPrezime.Text, indeks);
        }

        private void UpdateStudent()
        {
            int indeks = Int32.Parse(txtIndeks.Text);
            Common.UpdateStudent(txtIme.Text, txtPrezime.Text, indeks, _selectedStudent.student_id);
        }

        #endregion

        #region Events

        private void txtIndeks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            if (_selectedStudent == null)
            {
                AddNew();
            }
            else
            {
                UpdateStudent();
            }

            this.Close();
            DialogResult = DialogResult.Yes;
        }

        #endregion

        public static DialogResult AddNewStudent()
        {
            using (var frm = new FormStudent())
            {
                return frm.ShowDialog();
            }
        }

        public static DialogResult UpdateStudent(long studentId)
        {
            using (var frm = new FormStudent())
            {
                frm.SelectedStudent = Common.GetStudent(studentId);
                return frm.ShowDialog();
            }
        }
    }
}
