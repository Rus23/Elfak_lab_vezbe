using OOP.EF.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OOP.EF.App
{
    public partial class FormDodajIspit : Form
    {
        private long _studentId;

        public FormDodajIspit()
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
                LoadIspiti();
            }
        }


        private void LoadIspiti()
        {
            List<ispit> i = Common.GetIspiti(_studentId);

            var tmp = i.Select(x => new
            {
                Id = x.ispit_id,
                ZaPrikaz = x.sifra + " - " + x.naziv
            }).ToList();

            cmbIspit.DisplayMember = "ZaPrikaz";
            cmbIspit.ValueMember = "Id";
            cmbIspit.DataSource = tmp;
        }

        private void btnZatvori_Click(object sender, System.EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;

        }

        private void btnProsledi_Click(object sender, System.EventArgs e)
        {
            if (cmbIspit.SelectedValue == null)
                return;

            int ispitId = (int)cmbIspit.SelectedValue;
            Common.AddStudentIspit(_studentId, ispitId);

            this.Close();
            DialogResult = DialogResult.Yes;
        }
    }
}
