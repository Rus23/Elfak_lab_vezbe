using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Tetris2
{
    public partial class FormRezultati : Form
    {
        public FormRezultati()
        {
            InitializeComponent();
        }
        public FormRezultati(FormGlavna f)
        {
            
            InitializeComponent();
            lbxRezultati.Items.Clear();
            f.Listaigraca.Sort((o1, o2) => o1.Poeni.CompareTo(o2.Poeni));
          
            foreach (Igrac i in f.Listaigraca)
            {
                lbxRezultati.Items.Add(i.ZaPrikaz);

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
