using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_MineSwiper
{
    public partial class FormKonfig : Form
    {
        public FormKonfig()
        {
            InitializeComponent();
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if(txtBrMina.Text == String.Empty)
            {
                MessageBox.Show("Morate uneti broj mina!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBrMina.Focus();
            }
            else if (BrMina < 10)
            {
                MessageBox.Show("Broj mina ne sme biti manji od 10!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBrMina.Focus();
                return;

            }
            if(txtVelicina.Text == String.Empty)
            {
                MessageBox.Show("Morate uneti velicinu matrice!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVelicina.Focus();
            }
            else if(Velicina<9)
            {
                MessageBox.Show("Velicina polja ne sme biti manja od 9!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVelicina.Focus();
                return;

            }
            this.Close();
            DialogResult = System.Windows.Forms.DialogResult.OK;
            
        }
        public int Velicina
        {

            get
            {
                return Int32.Parse(txtVelicina.Text);
            }
        }
        public int BrMina
        {

            get
            {
                return Int32.Parse(txtBrMina.Text);
            }
        }
    }
}
