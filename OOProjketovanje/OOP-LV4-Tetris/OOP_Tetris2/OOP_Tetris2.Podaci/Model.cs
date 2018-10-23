using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Tetris2.Podaci
{
    public class Model : IModel
    {

        Oblik oblik;
        Panel mojPanel;

        Panel logickiPanel;
        Label[,] logickeLabele;
        int[,] logickaMatrica;
        

        int n;
        int m;

        Label[,] labelePanel;


        bool proveraDesno;
        bool proveraLevo;
        bool provera;

        #region Property
        public Oblik Oblik
        {
            get
            {
                return oblik;
            }

            set
            {
                oblik = value;
            }
        }

        public Panel MojPanel
        {
            get
            {
                return mojPanel;
            }

            set
            {
                mojPanel = value;
            }
        }

        public int N
        {
            get
            {
                return n;
            }

            set
            {
                n = value;
            }
        }

        public int M
        {
            get
            {
                return m;
            }

            set
            {
                m = value;
            }
        }

        public Label[,] LabelePanel
        {
            get
            {
                return labelePanel;
            }

            set
            {
                labelePanel = value;
            }
        }

        public bool Provera
        {
            get
            {
                return provera;
            }

            set
            {
                provera = value;
            }
        }

        public int[,] LogickaMatrica
        {
            get
            {
                return logickaMatrica;
            }

            set
            {
                logickaMatrica = value;
            }
        }

        public Panel LogickiPanel
        {
            get
            {
                return logickiPanel;
            }

            set
            {
                logickiPanel = value;
            }
        }

        public bool ProveraDesno
        {
            get
            {
                return proveraDesno;
            }

            set
            {
                proveraDesno = value;
            }
        }

        public bool ProveraLevo
        {
            get
            {
                return proveraLevo;
            }

            set
            {
                proveraLevo = value;
            }
        }

        public Label[,] LogickeLabele
        {
            get
            {
                return logickeLabele;
            }

            set
            {
                logickeLabele = value;
            }
        }


        #endregion

        #region Konstruktor
        public Model(int n, int m)
        {
            this.N = n;
            this.M = m;

            LabelePanel = new Label[n, m];
            LogickaMatrica = new int[n, m];
            LogickeLabele = new Label[n, m];

            LogickiPanel = new Panel();            
            MojPanel = new Panel();

            postaviSveNule(); // za logicku matricu
            inicijalizujLogickiPanel();
            postaviDizajnLogickihLabela(20);


            inicijalizujLabelePanel();
            postaviDizajnLabele(20);

            provera = true;
            proveraDesno = true;
        }

        #endregion

        #region Konstruktorske metode
        void postaviDizajnLabele(int dimenzija)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    LabelePanel[i, j].Width = dimenzija;
                    LabelePanel[i, j].Height = dimenzija;
                    LabelePanel[i, j].BackColor = Color.Azure;
                    LabelePanel[i, j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                }
            }
        }
        void postaviDizajnLogickihLabela(int dimenzija)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    LogickeLabele[i, j].Width = dimenzija;
                    LogickeLabele[i, j].Height = dimenzija;
                    LogickeLabele[i, j].BackColor = Color.White;
                    LogickeLabele[i, j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                }
            }
        }
        void inicijalizujLogickiPanel()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    LogickeLabele[i, j] = new Label();
        }

        void inicijalizujLabelePanel()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    LabelePanel[i, j] = new Label();
        }
        void postaviSveNule()
        {
            for (int i = 0; i < this.n; i++)
                for (int j = 0; j < this.m; j++)
                    logickaMatrica[i, j] = 0;
        }
        #endregion

        #region Metode


        public void pokreni()
        {
            // Random random = new Random();
            //int randomNumber = random.Next(0, 5);

            //Oblik = new Oblik(randomNumber);
            //Oblik = new Oblik(2);

            

            Oblik.X = 0;
            Oblik.Y = (M / 2);

            int vrsta;
            int kolona;

            int i = 0;
            int j = 0;

            for (vrsta = Oblik.X; vrsta < 3; vrsta++)
            {
                for (kolona = Oblik.Y; kolona < (Oblik.Y + 3); kolona++)// Oblik -1: Oblik +2
                {
                    if (Oblik.MatLabela[i, j].BackColor == Color.Azure)
                    {
                        j++;
                        continue;
                    }
                    this.LabelePanel[vrsta, kolona].BackColor = Oblik.MatLabela[i, j].BackColor;

                    this.logickaMatrica[vrsta, kolona] = oblik.Matrix[i,j];
                    this.LogickeLabele[vrsta, kolona].Text = this.logickaMatrica[vrsta, kolona].ToString();                   

                    j++;
                }
                i++;
                j = 0;
            }
            crtajPanel();
        }

        private bool moze_NaDole()
        {
            int i = 0;
            int j = 0;
            provera = true;

            if ((Oblik.IdOblika == 1 || Oblik.IdOblika == 4) && ((Oblik.X + 3) ==N))
                return true;

            for (int vrsta = Oblik.X; vrsta < 3 + Oblik.X && provera; vrsta++)
            {//(Oblik.Y - 1) ; (Oblik.Y + 2)
                for (int kolona = Oblik.Y ; kolona < (Oblik.Y + 3) && provera; kolona++) 
                {

                    if (Oblik.MatLabela[i, j].BackColor == Color.Azure)
                    {
                        j++;
                        continue;
                    }
                    else
                    {
                        provera = this.kvadratic_naDole(i, j, vrsta, kolona);
                        j++;
                    }

                }
                i++;
                j = 0;
            }
            return provera;
        }
        private bool kvadratic_naDole(int i, int j, int vrsta, int kolona)
        {
            if (oblik.Matrix[i, j] == 1 ||
                oblik.Matrix[i, j] == 4 ||
                oblik.Matrix[i, j] == 5 ||
                oblik.Matrix[i, j] == 7 ) // ako 2 ili 4 proveri
            {
                if (vrsta + 1 < this.n)
                    return labelePanel[vrsta + 1, kolona].BackColor == Color.Azure;
                return false;
            }
            else
                return true;

        }
        public void pomeraj()
        {

            int i = 2;
            int j = 2;

            if (!moze_NaDole())
            {
                provera = false;
                return;
            }
            else
            {

                for (int vrsta = Oblik.X + 2; vrsta >= Oblik.X; vrsta--)
                {
                    for (int kolona = Oblik.Y + 2; kolona >= Oblik.Y; kolona--)
                    {
                        if (Oblik.MatLabela[i, j].BackColor == Color.Azure)
                        {
                            j--;
                            continue;
                        }
                        else
                        {
                            this.LabelePanel[vrsta+1, kolona].BackColor = Oblik.MatLabela[i, j].BackColor;

                            this.LabelePanel[vrsta, kolona].BackColor = Color.Azure;

                            this.logickaMatrica[vrsta+1, kolona] = oblik.Matrix[i, j];
                            this.LogickeLabele[vrsta+1, kolona].Text = oblik.Matrix[i, j].ToString();

                            this.logickaMatrica[vrsta, kolona] = 0;
                            this.LogickeLabele[vrsta, kolona].Text = "";

                            j--;
                        }
                    }
                    i--;
                    j = 2;
                }
                Oblik.X++;
                crtajPanel();
            }

        }
        
        private bool kvadratic_Log_NaDesno(int vrsta, int kolona)
        {
            if (logickaMatrica[vrsta, kolona] == 2 || 
                logickaMatrica[vrsta, kolona] == 4 ||
                logickaMatrica[vrsta, kolona] == 6 ||
                logickaMatrica[vrsta, kolona] == 7)
            {
                return logickaMatrica[vrsta, kolona + 1] == 0;
            }
            else
            {
                return true;
            }
        }
        private bool moze_Li_NaDesno()
        {
            proveraDesno = true;
            int i = 0;
            int j = 0;
            if ((Oblik.IdOblika == 0 || Oblik.IdOblika == 1) && ((Oblik.Y) == -1))
            {
                return true;
            }
            else
            {
                for (int vrsta = Oblik.X; vrsta < Oblik.X + 3 && proveraDesno; vrsta++)
                {
                    for (int kolona = Oblik.Y; kolona < Oblik.Y + 3 && proveraDesno; kolona++)
                    {
                        
                       proveraDesno = kvadratic_Log_NaDesno(vrsta, kolona);
                        
                        j++;
                    }
                    j = 0;
                    i++;
                }
            }
            return proveraDesno;
        }
        public void pomeriDesno()
        {

            int i = 2;
            int j = 2;

            if (!moze_Li_NaDesno())
            {
                return;
            }
            else
            {   
                for (int vrsta = Oblik.X + 2; vrsta >= Oblik.X; vrsta--)
                { 
                    for (int kolona = Oblik.Y + 2; kolona >= Oblik.Y; kolona--)
                    {
                        if (Oblik.MatLabela[i, j].BackColor == Color.Azure)
                        {
                            j--;
                            continue;
                        }
                        else
                        {
                            this.LabelePanel[vrsta, kolona+1].BackColor = Oblik.MatLabela[i, j].BackColor;
                            this.LabelePanel[vrsta, kolona].BackColor = Color.Azure;

                            this.logickaMatrica[vrsta, kolona+1] = oblik.Matrix[i, j];
                            this.LogickeLabele[vrsta, kolona+1].Text = oblik.Matrix[i, j].ToString();

                            this.logickaMatrica[vrsta, kolona] = 0;
                            this.LogickeLabele[vrsta, kolona].Text = "";

                            j--;
                        }
                    }
                    i--;
                    j = 2;
                }
                Oblik.Y++;
                crtajPanel();
            }


        }
        private bool kvadratic_Log_NaLevo(int vrsta, int kolona)
        {
            if (logickaMatrica[vrsta, kolona] == 3 ||
                logickaMatrica[vrsta, kolona] == 5 ||
                logickaMatrica[vrsta, kolona] == 6 ||
                logickaMatrica[vrsta, kolona] == 7)
            {
                return logickaMatrica[vrsta, kolona - 1] == 0;
            }
            else
            {
                return true;
            }
        }
        private bool moze_Li_NaLevo()
        {
            proveraLevo = true;
            int i = 0;
            int j = 0;
            if ( (Oblik.IdOblika == 0 || Oblik.IdOblika == 1) && ((Oblik.Y)+2==m) )
            {
                return true;
            }
            else
            {
                for (int vrsta = Oblik.X; vrsta < Oblik.X + 3 && proveraLevo; vrsta++)
                {
                    for (int kolona = Oblik.Y; kolona < Oblik.Y + 3 && proveraLevo; kolona++)
                    {
                        // if (oblik.IdOblika <= 1 && oblik.Y - 1 < -1)
                        //     return false;
                       
                        proveraLevo = kvadratic_Log_NaLevo(vrsta, kolona);
                        
                        j++;
                    }
                    j = 0;
                    i++;
                }
            }
            return proveraLevo;
        }
        public void pomeriLevo()
        {
            int i = 2;
            int j = 0;

            if (!moze_Li_NaLevo())
            {
                return;
            }
            else
            {
                for (int vrsta = Oblik.X + 2; vrsta >= Oblik.X; vrsta--)
                {
                    for (int kolona = Oblik.Y ; kolona <= Oblik.Y +2; kolona++)
                    {
                        if (Oblik.MatLabela[i, j].BackColor == Color.Azure)
                        {
                            j++;
                            continue;
                        }
                        else
                        {
                            this.LabelePanel[vrsta, kolona - 1].BackColor = Oblik.MatLabela[i, j].BackColor;
                            this.LabelePanel[vrsta, kolona].BackColor = Color.Azure;

                            this.logickaMatrica[vrsta, kolona - 1] = oblik.Matrix[i,j];
                            this.LogickeLabele[vrsta, kolona-1].Text = oblik.Matrix[i, j].ToString();

                            this.logickaMatrica[vrsta, kolona] = 0;
                            this.LogickeLabele[vrsta, kolona].Text = "";

                            j++;
                        }
                    }
                    i--;
                    j = 0;
                }
                Oblik.Y--;
                crtajPanel();
            }
        }

        public void promeniSkor()
        {
            throw new NotImplementedException();
        }
        private bool plavojedan()
        {
            if (this.LogickeLabele[oblik.X + 1, oblik.Y].Text != "")
                return false;
            else if (this.LogickeLabele[oblik.X + 1, oblik.Y + 2].Text != "")
                return false;
            else return true;
        }
        private bool plavodva()
        {
            if (this.LogickeLabele[oblik.X, oblik.Y+1].Text != "")
                return false;
            else if (this.LogickeLabele[oblik.X + 2, oblik.Y + 1].Text != "")
                return false;
            else return true;
        }
        public void rotiraj()
        {
            if (Oblik.IdOblika == 1)
            {

                if (Oblik.Matrix[1, 1] == 6) //uspravan je
                {
                    if (this.plavojedan())
                    {
                        for (int i = 0; i < 3; i++)
                            for (int j = 0; j < 3; j++)
                            {
                                Oblik.Matrix[i, j] = 0;
                                Oblik.MatLabela[i, j].BackColor = Color.Azure;

                            }
                        for (int i = Oblik.X; i < Oblik.X + 3; i++)
                            for (int j = Oblik.Y; j < Oblik.Y + 3; j++)
                            {
                                this.LogickeLabele[i, j].Text = "";
                                this.labelePanel[i, j].BackColor = Color.Azure;
                            }

                        Oblik.MatLabela[1, 0].BackColor = Color.Blue;
                        Oblik.MatLabela[1, 1].BackColor = Color.Blue;
                        oblik.MatLabela[1, 2].BackColor = Color.Blue;

                        this.LogickeLabele[Oblik.X + 1, Oblik.Y].Text = "5";
                        this.LogickeLabele[Oblik.X + 1, Oblik.Y + 1].Text = "1";
                        this.LogickeLabele[Oblik.X + 1, Oblik.Y + 2].Text = "4";

                        this.labelePanel[Oblik.X + 1, Oblik.Y].BackColor = Color.Blue;
                        this.labelePanel[Oblik.X + 1, Oblik.Y + 1].BackColor = Color.Blue;
                        this.labelePanel[Oblik.X + 1, Oblik.Y + 2].BackColor = Color.Blue;



                        Oblik.Matrix[1, 0] = 5;
                        Oblik.Matrix[1, 1] = 1;
                        oblik.Matrix[1, 2] = 4;

                    }
                }
                else if (this.plavodva()) //horizontalan je 
                {
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            Oblik.Matrix[i, j] = 0;
                            Oblik.MatLabela[i, j].BackColor = Color.Azure;

                        }
                    for (int i = Oblik.X; i < Oblik.X + 3; i++)
                        for (int j = Oblik.Y; j < Oblik.Y + 3; j++)
                        {
                            this.LogickeLabele[i, j].Text = "";
                            this.labelePanel[i, j].BackColor = Color.Azure;
                        }

                    Oblik.MatLabela[0, 1].BackColor = Color.Blue;
                    Oblik.MatLabela[1, 1].BackColor = Color.Blue;
                    oblik.MatLabela[2, 1].BackColor = Color.Blue;

                    this.LogickeLabele[Oblik.X, Oblik.Y + 1].Text = "6";
                    this.LogickeLabele[Oblik.X + 1, Oblik.Y + 1].Text = "6";
                    this.LogickeLabele[Oblik.X + 2, Oblik.Y + 1].Text = "7";

                    this.labelePanel[Oblik.X, Oblik.Y + 1].BackColor = Color.Blue;
                    this.labelePanel[Oblik.X + 1, Oblik.Y + 1].BackColor = Color.Blue;
                    this.labelePanel[Oblik.X + 2, Oblik.Y + 1].BackColor = Color.Blue;



                    Oblik.Matrix[0, 1] = 6;
                    Oblik.Matrix[1, 1] = 6;
                    oblik.Matrix[2, 1] = 7;



                }
                else
                    return;

            }
            else if (Oblik.IdOblika == 4)
            {
                if (this.logickaMatrica[Oblik.X + 1, Oblik.Y + 1] == 6) // iz nultog u prvi
                {
                    if (proveriRotacijuIz_0u1())
                        rotirajCetvrtiOblik(1);
                }
                else if (this.logickaMatrica[Oblik.X + 1, Oblik.Y + 1] == 4) //iz prvog u drugi
                {
                    if (proveriRotacijuIz_1u2())
                        rotirajCetvrtiOblik(2);
                }
                else if (this.logickaMatrica[Oblik.X + 1, Oblik.Y + 1] == 7)
                {
                    if (proveriRotacijuIz_2u3())
                        rotirajCetvrtiOblik(3);
                }
                else
                {
                    if (proveriRotacijuIZ_3u0())
                        rotirajCetvrtiOblik(0);
                }


            }
            else if(oblik.IdOblika == 5)
            {
                if(this.logickaMatrica[Oblik.X,Oblik.Y+1] == 0 )
                {
                    if (proveriRotacijuIz_0u1_Peti())
                        rotirajPetiOblik(1);
                }
            }
                return;
        }
        bool proveriRotacijuIz_0u1_Peti()
        {
            return (this.logickaMatrica[Oblik.X, Oblik.Y] == 0 &&
                this.logickaMatrica[Oblik.X, oblik.Y + 1] == 0);
        }
        bool proveriRotacijuIZ_1u2_Peti()
        {
            return (this.logickaMatrica[Oblik.X, Oblik.Y + 2] == 0 &&
                this.logickaMatrica[Oblik.X + 1, oblik.Y + 2] == 0);
        }
        bool proveriRoacijuIz_2u3_Peti()
        {
            return (this.logickaMatrica[Oblik.X+2, Oblik.Y + 1] == 0 &&
                this.logickaMatrica[Oblik.X + 2, oblik.Y + 2] == 0);
        }
        bool proveriRotacijuIz_3u1_Peti()
        {
            return (this.logickaMatrica[Oblik.X+1, Oblik.Y] == 0 &&
                this.logickaMatrica[Oblik.X + 2, oblik.Y] == 0);
        }
        public void ubrzajPad()
        {
            throw new NotImplementedException();
        }

        public void zalepiDole()
        {
            throw new NotImplementedException();
        }

        public bool zaustavi()
        {
            return false;
        }
        public void crtajPanel()
        {
            MojPanel.Width = M * LabelePanel[0, 0].Width;
            MojPanel.Height = N * LabelePanel[0, 0].Height;

            LogickiPanel.Width = M * LogickeLabele[0, 0].Width;
            LogickiPanel.Height = N * LogickeLabele[0, 0].Height;

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    if(i==N-1 || j==0 || j==M-1)
                    {
                        LabelePanel[i, j].BackColor = Color.Black;
                        LogickaMatrica[i, j] = 11;
                        LogickeLabele[i, j].Text = "P";
                    }
                    LabelePanel[i, j].Left = j * LabelePanel[0, 0].Width;
                    LabelePanel[i, j].Top = i * LabelePanel[0, 0].Height;

                    MojPanel.Controls.Add(LabelePanel[i, j]);

                    LogickeLabele[i, j].Left = j * LogickeLabele[0, 0].Width;
                    LogickeLabele[i, j].Top = i * LogickeLabele[0,0].Height;

                    LogickiPanel.Controls.Add(LogickeLabele[i, j]);
                }


        }

        public bool daLiMozeDaSeKrece(int vrsta, int kolona) // univerzalna OVAKO NE MOZE
        {
            if (oblik.Matrix[vrsta, kolona] == 1)
                return true;
            if (oblik.Matrix[vrsta, kolona] == 2)
            {
                if (vrsta + 1 < this.n)
                    return labelePanel[vrsta + 1, kolona].BackColor == Color.Azure;
                return false;
            }
            if (oblik.Matrix[vrsta, kolona] == 3)
            {
                if (kolona + 1 < this.m && kolona - 1 > 0) // treba da znamo da li ide na levo ili desno...
                    return labelePanel[vrsta, kolona + 1].BackColor == Color.Azure
                    && labelePanel[vrsta, kolona - 1].BackColor == Color.Azure;
                return false;
            }
            else // ako je oblik.Matrix[vrsta,kolona] == 4
            {
                if (vrsta + 1 < this.n && kolona + 1 < this.m && kolona - 1 > 0)
                    return labelePanel[vrsta + 1, kolona].BackColor == Color.Azure
                        && labelePanel[vrsta, kolona + 1].BackColor == Color.Azure
                        && labelePanel[vrsta, kolona - 1].BackColor == Color.Azure;
                return false;
            }
        }

        void obrisiOblikPrecizno()
        {
            int i = 0;
            int j = 0;
            for (int vrsta = Oblik.X; vrsta < Oblik.X + 3; vrsta++)
            {
                for (int kolona = Oblik.Y; kolona < Oblik.Y + 3; kolona++)
                {
                    if (oblik.Matrix[i, j] > 0)
                    {
                        labelePanel[vrsta, kolona].BackColor = Color.Azure;
                        logickaMatrica[vrsta, kolona] = 0;
                        LogickeLabele[vrsta, kolona].Text = "";

                        oblik.MatLabela[i, j].BackColor = Color.Azure;
                        oblik.Matrix[i, j] = 0;
                    }
                    j++;
                }
                i++;
                j = 0;
            }
        }
        void postaviVrednostLogickoj_Matrici_i_Labeli(int i, int j, int vrednost)
        {
            logickaMatrica[i, j] = vrednost;
            LogickeLabele[i, j].Text = vrednost.ToString();
        }
        void postaviBojeObliku(Color boja)
        {
            int i = 0;int j = 0;
            for (int vrsta = Oblik.X; vrsta < Oblik.X + 3; vrsta++)
            {
                for(int kolona = Oblik.Y; kolona<Oblik.Y+3;kolona++)
                {
                    if(Oblik.Matrix[i,j] > 0)
                    {
                        labelePanel[vrsta, Oblik.Y].BackColor = boja;
                        oblik.MatLabela[i, j].BackColor = boja;
                    }                    

                    j++;
                }
                j = 0;
                i++;
            }
        }
        void rotirajPetiOblik(int uFiguru)
        {
            if(uFiguru == 1)
            {
                obrisiOblikPrecizno();

                int i = 0;
                int j = 0;

                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X, Oblik.Y, 3);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X, Oblik.Y + 1, 4);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X+1, Oblik.Y, 6);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X + 2, Oblik.Y, 5);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X + 2, Oblik.Y + 1, 4);

                oblik.Matrix[0, 1] = 3;
                oblik.Matrix[0, 1] = 4;
                oblik.Matrix[1, 0] = 6;
                oblik.Matrix[2, 0] = 5;
                oblik.Matrix[2, 1] = 4;

                postaviBojeObliku(Color.OrangeRed);

            }
        }
        void rotirajCetvrtiOblik(int uFiguru)
        {
            if (uFiguru == 1)
            {
                obrisiOblikPrecizno();

                int i = 0;
                int j = 0;
                for (int vrsta = Oblik.X; vrsta < Oblik.X + 3; vrsta++)
                {
                    labelePanel[vrsta, Oblik.Y].BackColor = Color.Red;
                    oblik.MatLabela[i++, j].BackColor = Color.Red;
                }
                labelePanel[Oblik.X + 1, Oblik.Y + 1].BackColor = Color.Red;
                oblik.MatLabela[1, 1].BackColor = Color.Red;

                LogickaMatrica[Oblik.X, Oblik.Y] = 3;
                LogickaMatrica[Oblik.X + 1, Oblik.Y] = 3;
                LogickaMatrica[Oblik.X + 2, Oblik.Y] = 7;
                LogickaMatrica[Oblik.X + 1, Oblik.Y + 1] = 4;

                LogickeLabele[Oblik.X, Oblik.Y].Text = "3";
                LogickeLabele[Oblik.X + 1, Oblik.Y].Text = "3";
                LogickeLabele[Oblik.X + 2, Oblik.Y].Text = "7";
                LogickeLabele[Oblik.X + 1, Oblik.Y + 1].Text = "4";


                oblik.Matrix[0, 0] = 3;
                oblik.Matrix[1, 0] = 3;
                oblik.Matrix[2, 0] = 7;
                oblik.Matrix[1, 1] = 4;

            }
            else if (uFiguru == 2)
            {
                obrisiOblikPrecizno();

                int i = 0;
                int j = 0;

                for (int kolona = Oblik.Y; kolona < Oblik.Y + 3; kolona++)
                {
                    labelePanel[Oblik.X, kolona].BackColor = Color.Red;
                    oblik.MatLabela[i, j++].BackColor = Color.Red;
                }
                labelePanel[Oblik.X + 1, Oblik.Y + 1].BackColor = Color.Red;
                oblik.MatLabela[1, 1].BackColor = Color.Red;

                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X, Oblik.Y, 5);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X, Oblik.Y + 1, 8);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X, Oblik.Y + 2, 4);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X + 1, Oblik.Y + 1, 7);


                oblik.Matrix[0, 0] = 5;
                oblik.Matrix[0, 1] = 8;
                oblik.Matrix[0, 2] = 4;
                oblik.Matrix[1, 1] = 7;
            }
            else if (uFiguru == 3)
            {
                obrisiOblikPrecizno();

                int i = 0;
                int j = 0;

                for (int vrsta = Oblik.X; vrsta < Oblik.X + 3; vrsta++)
                {
                    labelePanel[vrsta, Oblik.Y + 2].BackColor = Color.Red;
                    oblik.MatLabela[i++, j + 2].BackColor = Color.Red;
                }
                labelePanel[Oblik.X + 1, Oblik.Y + 1].BackColor = Color.Red;
                oblik.MatLabela[1, 1].BackColor = Color.Red;

                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X, Oblik.Y + 2, 6);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X + 1, Oblik.Y + 2, 2);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X + 2, Oblik.Y + 2, 7);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X + 1, Oblik.Y + 1, 5);

                oblik.Matrix[0, 2] = 6;
                oblik.Matrix[1, 2] = 2;
                oblik.Matrix[2, 2] = 7;
                oblik.Matrix[1, 1] = 5;
            }
            else
            {
                obrisiOblikPrecizno();

                int i = 0;
                int j = 0;

                for (int kolona = Oblik.Y; kolona < Oblik.Y + 3; kolona++)
                {
                    labelePanel[Oblik.X + 2, kolona].BackColor = Color.Red;
                    oblik.MatLabela[i + 2, j++].BackColor = Color.Red;
                }
                labelePanel[Oblik.X + 1, Oblik.Y + 1].BackColor = Color.Red;
                oblik.MatLabela[1, 1].BackColor = Color.Red;

                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X + 2, Oblik.Y, 5);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X + 2, Oblik.Y + 1, 1);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X + 2, Oblik.Y + 2, 4);
                postaviVrednostLogickoj_Matrici_i_Labeli(Oblik.X + 1, Oblik.Y + 1, 6);


                oblik.Matrix[2, 0] = 5;
                oblik.Matrix[2, 1] = 1;
                oblik.Matrix[2, 2] = 4;
                oblik.Matrix[1, 1] = 6;
            }
        }
        bool proveriRotacijuIz_0u1()
        {
            bool rot = true;
            for (int vrsta = Oblik.X; vrsta < Oblik.X + 3 && rot; vrsta++)
            {
                if (this.logickaMatrica[vrsta, Oblik.Y] == 0 ||
                    this.logickaMatrica[vrsta, Oblik.Y] > 8 ||
                    this.logickaMatrica[vrsta, Oblik.Y] == 5) // njen levi krak
                    rot = true;
                else
                    rot = false;
            }
            return rot;
        }
        bool proveriRotacijuIz_1u2()
        {
            bool rot = true;
            for (int kolona = Oblik.Y + 1; kolona < Oblik.Y + 3; kolona++)
            {// krece od Oblik.Y + 1 da ne bi proveravalo njen skroz gornji levi krak jer je tu vec crveno
                if (this.logickaMatrica[Oblik.X, kolona] == 0 ||
                    this.logickaMatrica[Oblik.X, kolona] > 8)
                    rot = true;
                else
                    rot = false;
            }
            return rot;
        }
        bool proveriRotacijuIz_2u3()
        {
            return ((this.logickaMatrica[Oblik.X + 1, Oblik.Y + 2] == 0
                || this.logickaMatrica[Oblik.X + 1, Oblik.Y + 2] > 8)
                && (this.logickaMatrica[Oblik.X + 2, Oblik.Y + 2] == 0
                || this.logickaMatrica[Oblik.X + 1, Oblik.Y + 2] > 8));

        }
        bool proveriRotacijuIZ_3u0()
        {
            return ((this.logickaMatrica[Oblik.X + 2, Oblik.Y] == 0
                || this.logickaMatrica[Oblik.X + 2, Oblik.Y] > 8)
                && (this.logickaMatrica[Oblik.X + 2, Oblik.Y + 1] == 0
                || this.logickaMatrica[Oblik.X + 2, Oblik.Y + 1] > 8));
        }



        #endregion
    }
}
