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
    public partial class FormZabrana : Form
    {
        bool formclosed=false;
        public FormZabrana()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
        }
        public FormZabrana(ListaKategorija l)
            :this()
        {
                foreach (var v in l.ListaKategorijaValues)
                    cbxZab.Items.Add(v.KategorijaValue.ToString());
                cbxZab.SelectedIndex = 0;
            
        }
        public string Kategorija
        {
            get { return cbxZab.SelectedItem.ToString(); }
        }
        public DateTime DatOd
        {
            get { return dtpOd.Value; }
        }
        public DateTime DatDo
        {
            get { return dtpDO.Value; }
        }

        private void btn_Prosledi_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Zabrana je uspesno dodata", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormZabrana_FormClosing(object sender, FormClosingEventArgs e)
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



