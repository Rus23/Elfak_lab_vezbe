using OOP.EF.Data;
using System;
using System.Windows.Forms;

namespace OOP.EF.App
{
    public partial class FormDodajTelefon : Form
    {
        long _studentId;

        public FormDodajTelefon()
        {
            InitializeComponent();
        }

        public long StudentId
        {
            get
            {
                return _studentId;
            }

            set
            {
                _studentId = value;
            }
        }

        private bool Validacija()
        {

            if (String.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("Niste popunili polje Telefon.", "Obavestenje",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;

        }


        private void btnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;
            Common.AddNewTelefon(_studentId, txtTelefon.Text);
            this.Close();
            DialogResult = DialogResult.Yes;
        }
    }
}
