using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_MS.Podaci;
using System.Xml.Serialization;
using System.IO;
using Extension;

namespace OOP_MineSwiper
{
    public partial class FormGlavna : Form
    {
        
        
        int vreme = 0;
        Game igra;
        public FormGlavna()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            cbxDrugiPrsten.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelGame.Controls.Clear();
            
            igra = new Game();
            igra.MojPanel = panelGame;
            igra.MojPanel.Enabled = true;
            igra.crtaj();
            vreme = 0;

            timerIgre.Start();
            cbxDrugiPrsten.Enabled = true;

        }
        

        private void lblZastavice_Click(object sender, EventArgs e)
        {

        }

        private void timerIgre_Tick(object sender, EventArgs e)
        {
            lblZastavice.Text = igra.BrZastavica.ToString();
            if(igra.Kraj)
            {
                timerIgre.Enabled = false;
            }
            if(vreme == 240 )
            {
                timerIgre.Enabled = false;
                MessageBox.Show("Isteklo Vam je vreme!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
            else
            {
                ++vreme;
                lblVreme.Text = vreme.ToString();
            }
            
           
        }

        private void konfiguracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var konfig = new FormKonfig();
            DialogResult result = konfig.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)

            {
                int brmina = konfig.BrMina;
                int velicina = konfig.Velicina;

                panelGame.Controls.Clear();
                igra = new Game(brmina, velicina);
                igra.MojPanel = panelGame;
                igra.MojPanel.Enabled = true;
                igra.crtaj();

                lblVreme.Text = "0";
                timerIgre.Start();
            }
        }

        private void ucitajIzXMLFajlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml files (*.xml)|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                panelGame.Controls.Clear();
               
                List<Polje> pomlista = new List<Polje>();
                pomlista = pomlista.DeSerialize(ofd.FileName);
                int pom = (int)Math.Sqrt(pomlista.Count);                

                igra = new Game(pom);

                igra.MojPanel = panelGame;
                igra.MojPanel.Enabled = true;
                igra.Niz_polja= igra.Niz_polja.DeSerialize(ofd.FileName);
                igra.NizuMatricu(); 
            }
        }

        private void snimiUXMLFajlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "xml files (*.xml)|*.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
               
               igra.MatricauNiz().Serialize(sfd.FileName);
            }
        }

        private void cbxDrugiPrsten_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDrugiPrsten.Checked)
                igra.Drugiprsten = true;
            else
                igra.Drugiprsten = false;
        }
    }
}
