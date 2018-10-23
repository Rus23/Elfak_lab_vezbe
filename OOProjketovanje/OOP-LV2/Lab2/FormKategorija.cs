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
    public partial class FormKategorija : Form
    {
        bool formclosed = false;
       
        public FormKategorija()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cbxKategorija.SelectedIndex = 0;
        }

        public string Kategorija
        {
            get { return cbxKategorija.SelectedItem.ToString(); }
        }
        public DateTime DatOd
        {
            get { return dtpDatumOD.Value; }
        }
        public DateTime DatDo
        {
            get { return dtpDatumDO.Value; }
        }




        private void btn_Prosledi_Click(object sender, EventArgs e)
        {
           
            //MessageBox.Show("Kategorija je uspesno dodana", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            formclosed = true;
            this.Close();
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void btn_Zatvori_Click(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show("Da li ste sigurni da zelite da zatvorite ovu formu?",
                                               "Obavestenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (di == DialogResult.Yes)
            {
                formclosed = true;
                this.Close();

            }
        }

        private void FormKategorija_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formclosed)
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
    }
}
