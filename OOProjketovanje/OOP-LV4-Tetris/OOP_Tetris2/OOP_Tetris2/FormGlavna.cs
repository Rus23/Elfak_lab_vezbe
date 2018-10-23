using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Tetris2.Podaci;
using Extension;
using System.Xml.Serialization;

namespace OOP_Tetris2
{
    [Serializable]
    public struct Igrac
    {
        int poeni;
        String ime;
        String prezime;

        public String ZaPrikaz
        {
            get
            {
                return Ime + " " +Prezime + " " + Poeni + " ";
            }
        }
        [XmlAttribute]
        public int Poeni
        {
            get
            {
                return poeni;
            }

            set
            {
                poeni = value;
            }
        }
        [XmlAttribute]
        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }
        [XmlAttribute]
        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        
    }
    [Serializable]
    public partial class FormGlavna : Form
    {
        private Tetris tet;
        Oblik ob;
        bool pauza;
        int id_sledeceg;
        Label[,] labeleNaredniOblik;
        int br_poena;

        Igrac player;

        List<Igrac> listaigraca;

        int pomeraj;
        int vreme;
        int interval;

        int visina;
        int sirina;




        #region Property
        public Tetris Tet
        {
            get
            {
                return tet;
            }

            set
            {
                tet = value;
            }
        }

        public Igrac Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }
        [XmlArrayItem("ListaIgraca", typeof(String))]
        public List<Igrac> Listaigraca
        {
            get
            {
                return listaigraca;
            }

            set
            {
                listaigraca = value;
            }
        }

        
        
        #endregion

        public FormGlavna()
        {            
            InitializeComponent();
            Init();        
           
        }
        void Init()
        {
            Listaigraca = new List<Igrac>();
        }
        
        void pokreniTajmer()
        {
           
            pomeraj++;
            if (pomeraj < visina - 2 && Tet.Mod.Provera)
            {



                Tet.Mod.pomeraj();

            }
            else
            {
                timerTetris.Stop();
                pomeraj = 0;
                tet.Mod.Provera = true;

               
                ob = new Oblik(id_sledeceg);

                Random random = new Random();
                id_sledeceg = random.Next(0, 6);
                crtajsledecielement(new Oblik(id_sledeceg));

                Tet.Mod.Oblik = ob;

                proveri_ispunjene_vrste();

                Tet.Mod.pokreni();
                timerTetris.Start();
            }
            //proveri_ispunjene_vrste();
            //proveri_ispunjen_red(tet.Mod.N);
        }
        private void crtajsledecielement(Oblik o)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    labeleNaredniOblik[i, j].Left = 100 + (j * 20);
                    labeleNaredniOblik[i, j].Top = 450 + (i * 20);
                    labeleNaredniOblik[i, j].Width = 20;
                    labeleNaredniOblik[i, j].Height = 20;
                    labeleNaredniOblik[i, j].BackColor = o.MatLabela[i,j].BackColor;
                    labeleNaredniOblik[i, j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.Controls.Add(labeleNaredniOblik[i, j]);
                }
            }
        }
        void proveri_ispunjen_red(int vrsta)
        {
            bool racnaj = true;
            for (int j = 0; j < tet.Mod.M - 1 && racnaj; j++)
            {
                if (tet.Mod.LogickaMatrica[vrsta, j] > 0 || tet.Mod.LogickaMatrica[vrsta, j] < 11)
                {
                    racnaj = true;
                }
                else
                    racnaj = false;
            }
            if(racnaj)
            {
                for (int j = 0; j < tet.Mod.M - 1; j++)
                {
                    tet.Mod.LabelePanel[vrsta, j] = tet.Mod.LabelePanel[vrsta - 1, j];
                }
                proveri_ispunjen_red(vrsta - 1);
            }

        }
        private void proveri_ispunjene_vrste()
        {
            int broj = 0;
            for (int i = tet.Mod.N - 2; i >= 0; i--)
            {
                for (int j = 1; j < tet.Mod.M-1; j++)
                    if (tet.Mod.LogickeLabele[i,j].Text != "")
                        broj++;
                if(broj==tet.Mod.M-2)
                {
                    
                    br_poena=br_poena+100;
                    lblPoeni.Text = br_poena.ToString();

                    for (int k=i;k>0;k--)
                        for (int m=0;m<tet.Mod.M;m++)
                        {
                            tet.Mod.LabelePanel[k, m].BackColor = tet.Mod.LabelePanel[k - 1, m].BackColor;
                            tet.Mod.LogickaMatrica[k, m] = tet.Mod.LogickaMatrica[k - 1, m];
                            tet.Mod.LogickeLabele[k, m].Text = tet.Mod.LogickeLabele[k - 1, m].Text;
                        }

                }
                broj = 0;

            }
        }
        private void FormGlavna_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(txtIme.Text==String.Empty)
            {
                MessageBox.Show("Niste uneli ime igraca!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPrezime.Text == String.Empty)
            {
                MessageBox.Show("Niste uneli prezime igraca!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtbxKolone.Text == String.Empty)
            {
                MessageBox.Show("Niste uneli broj kolona!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtbxVrste.Text == String.Empty)
            {
                MessageBox.Show("Niste uneli broj vrsta!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtbxBrzina.Text == String.Empty)
            {
                MessageBox.Show("Niste uneli brzinu!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            

            visina = Int32.Parse(txtbxVrste.Text);
            sirina = Int32.Parse(txtbxKolone.Text);
            vreme = 0;

            
            Tet = new Tetris(visina, sirina);
            

            Tet.Height = visina * 2 * 20 + 10;
            Tet.Width = sirina * 2 * 20 + 50;
            Tet.Left = gbxKontrole.Width + 30;
            Tet.Top = 30;
            Tet.Mod.LogickiPanel.Visible = false; //ovo sam dodao


            this.Height = Tet.Height + 30;
            this.Width = gbxKontrole.Width + Tet.Width - Tet.Mod.LogickiPanel.Width +30;
            this.Controls.Add(Tet);

            interval = Int32.Parse(txtbxBrzina.Text);
            this.timerTetris.Interval = interval;
            this.timerTetris.Stop();
            this.timerVreme.Stop();

            this.pauza = false;

            labeleNaredniOblik = new Label[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    this.labeleNaredniOblik[i, j] = new Label();
            br_poena = 0;
           

            pomeraj = 0;

            

            Random random = new Random();
            id_sledeceg = random.Next(0, 6);
            ob = new Oblik(id_sledeceg);

            id_sledeceg = random.Next(0, 6);
            this.crtajsledecielement(new Oblik(id_sledeceg));
               // this.crtajsledecielement(new Oblik(1));

            Tet.Mod.Oblik = ob;


            Tet.Mod.pokreni();
            

            timerTetris.Start();
            timerVreme.Start();
            this.Focus();
            
        }

        private void timerTetris_Tick(object sender, EventArgs e)
        {
                pokreniTajmer();            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (pauza)
            {
                pauza = false;
                pokreniTajmer();
                timerTetris.Start();
                timerVreme.Start();
                btnStart.Focus();
            }
            else
            {
                timerVreme.Stop();
                timerTetris.Stop();
                pauza = true;
                btnStart.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            timerVreme.Stop();
            timerTetris.Stop();

            player = new Igrac();
            player.Ime = txtIme.Text;
            player.Prezime = txtPrezime.Text;
            player.Poeni = Int32.Parse(lblPoeni.Text);
            Listaigraca.Add(Player);
            MessageBox.Show("Skor je uspesno sacuvan", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            timerVreme.Start();
            timerTetris.Start();
            btnStart.Focus();

        }

        private void btnStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D || e.KeyData==Keys.L)
            {
                tet.Mod.pomeriDesno();
            }
            if (e.KeyData == Keys.A || e.KeyData == Keys.J)
            {
                tet.Mod.pomeriLevo();
            }
            
        }

        private void timerVreme_Tick(object sender, EventArgs e)
        {
            lblVreme.Text = vreme++.ToString();
        }

        private void btnStart_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.K || e.KeyData == Keys.S)
                timerTetris.Interval = interval;
            if(e.KeyData==Keys.P)
            {
                if (pauza)
                {
                    pauza = false;
                    pokreniTajmer();
                    timerTetris.Start();
                    btnStart.Focus();
                }
                else
                {
                    timerVreme.Stop();
                    timerTetris.Stop();
                    pauza = true;
                    btnStart.Focus();
                }
            }
        }

        private void btnStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 's' || e.KeyChar == 'k')
            {
                timerTetris.Interval = 200;
            }
            if(e.KeyChar=='w' || e.KeyChar=='i')
            {
                tet.Mod.rotiraj();
            }
        }

        private void SacuvajTrenutniSkorToolStripMenuItem_Click(object sender, EventArgs e) // ovo je za pause ali nije htelo da se preimenuje
        {
            if (pauza)
            {
                pauza = false;
                pokreniTajmer();
                timerTetris.Start();
                btnStart.Focus();
            }
            else
            {
                timerVreme.Stop();
                timerTetris.Stop();
                pauza = true;
                btnStart.Focus();
            }

        }

        private void pokreniNovuIgruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerVreme.Stop();
            timerTetris.Stop();
            this.Controls.Clear();
            this.InitializeComponent();
            this.vreme = 0;

        }

        private void sacuvajListuUXMLFajlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerVreme.Stop();
            timerTetris.Stop();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "xml files (*.xml)|*.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Listaigraca.Serialize(sfd.FileName);
            }
            timerVreme.Start();
            timerTetris.Start();
        }

        private void sacuvajTrenutniSkorToolStripMenuItem1_Click(object sender, EventArgs e) //pravi sacuvaj score
        {
            timerVreme.Stop();
            timerTetris.Stop();

            player = new Igrac();
            player.Ime = txtIme.Text;
            player.Prezime = txtPrezime.Text;
            player.Poeni = Int32.Parse(lblPoeni.Text);
            Listaigraca.Add(Player);
            MessageBox.Show("Skor je uspesno sacuvan", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            timerVreme.Start();
            timerTetris.Start();
            btnStart.Focus();
        }

        private void prikaziListuSaOsvojenimPoenimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerVreme.Stop();
            timerTetris.Stop();

            var frm = new FormRezultati(this);
            frm.ShowDialog();

            timerVreme.Start();
            timerTetris.Start();
            btnStart.Focus();
        }


    }
}
