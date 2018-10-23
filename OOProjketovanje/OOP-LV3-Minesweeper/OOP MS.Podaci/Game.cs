using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OOP_MS.Podaci
{
    struct Pozicija
    {
        int x;
        int y;

        #region Properties
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
        #endregion
    }
    [Serializable]
    public class Game
    {
        private Polje[,] _matrix ;
        private Panel mojPanel;
        private Polje[] niz_polja;

        public Panel MojPanel
        {
            get { return mojPanel; }
            set { mojPanel = value; }
        }
        

        private int n;

        private int _brKlikova;
        private int _vremeKraj;
        private int _brMina;
        private int _brZastavica;
        private int _brojPoteza;

        bool drugiprsten;

        private bool kraj = false;

        #region Properties
        public Polje[,] Matrix
        {
            get
            {
                return _matrix;
            }

            set
            {
                _matrix = value;
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

        public int BrKlikova
        {
            get
            {
                return _brKlikova;
            }

            set
            {
                _brKlikova = value;
            }
        }

        public int VremeKraj
        {
            get
            {
                return _vremeKraj;
            }

            set
            {
                _vremeKraj = value;
            }
        }

        public int BrMina
        {
            get
            {
                return _brMina;
            }

            set
            {
                _brMina = value;
            }
        }

        public int BrZastavica
        {
            get
            {
                return _brZastavica;
            }

            set
            {
                _brZastavica = value;
            }
        }
        public int BrojPoteza
        {
            get
            {
                return _brojPoteza;
            }

            set
            {
                _brojPoteza = value;
            }
        }

        public bool Kraj
        {
            get
            {
                return kraj;
            }

            set
            {
                kraj = value;
            }
        }
        [XmlArrayItem("NizPolja", typeof(String))]
        public Polje[] Niz_polja
        {
            get
            {
                return niz_polja;
            }

            set
            {
                niz_polja = value;
            }
        }

        public bool Drugiprsten
        {
            get
            {
                return drugiprsten;
            }

            set
            {
                drugiprsten = value;
            }
        }
        #endregion
        #region Constructors
        public Game()
        {
            Drugiprsten = false;
            mojPanel = new Panel();
            n = 9;
            mojPanel.Width = 400;
            mojPanel.Height = 400;
            
            _matrix = new Polje[n, n];

            for (int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    
                    _matrix[i, j]=new Podaci.Polje(this, i, j, false);
                }
            }


            this.generisiMine();

            _brKlikova = 0;
            _brMina = 10;
            _brZastavica = 13;
            BrojPoteza = (n * n) - _brMina;


        }

        public Game(int mine, int dim)
        {
            Drugiprsten = false;
            mojPanel = new Panel();
            n = dim;
            mojPanel.Width = 400;
            mojPanel.Height = 400;

            _matrix = new Polje[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    _matrix[i, j] = new Podaci.Polje(this, i, j, false);
                }
            }


            this.generisiMine();

            _brKlikova = 0;
            _brMina = mine;
            _brZastavica = 13;
            BrojPoteza = (n * n) - _brMina;


        }
        public Game(int dimenzija)
        {
            Drugiprsten = false;
            mojPanel = new Panel();
            n = dimenzija;// treba n=dim
            this.Niz_polja = new Polje[this.n * this.n];

            mojPanel.Width = 400;
            mojPanel.Height = 400;

            _matrix = new Polje[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    _matrix[i, j] = new Podaci.Polje(this, i, j, false);
                }
            }

            _brKlikova = 0;
            _brZastavica = 13;
            BrojPoteza = (n * n) - _brMina;


        }

        
        

        #endregion
        #region Metode
        public void brMinaOkolo(int i, int j)
        {
            if (_matrix[i, j].BrMina > 0)
                return;
            if (!this.drugiprsten)
            {
                for (int k = i - 1; k < i + 2; k++)
                    for (int g = j - 1; g < j + 2; g++)
                    {
                        if (k < 0 || k == n || g < 0 || g == n)
                            continue;
                        else
                            if (_matrix[k, g].Mina)
                            _matrix[i, j].BrMina++;
                    }
            }
            else
            {
                for (int k = i - 2; k < i + 3; k++)
                    for (int g = j - 2; g < j + 3; g++)
                    {
                        if (k < 0 || k == n || g < 0 || g == n || k > n || g > n)
                            continue;
                        else
                            if (_matrix[k, g].Mina)
                            _matrix[i, j].BrMina++;
                    }
            }
            
            if (_matrix[i, j].BrMina == 0)
                return;
            else if (_matrix[i, j].Zastavica)
                return;

            _matrix[i, j].Sivo();
            _matrix[i, j].Btn.Text = _matrix[i, j].BrMina.ToString();
            _matrix[i, j].Btn.BackColor = Color.LightBlue;
            _matrix[i, j].ImaBroj = true;

            switch (_matrix[i, j].BrMina)
            {

                case 1:                
                    _matrix[i, j].Btn.ForeColor = Color.Green;
                    break;
                case 2:
                     _matrix[i, j].Btn.ForeColor = Color.Blue;
                    break;
                case 3:                    
                    _matrix[i, j].Btn.ForeColor = Color.Red;
                    break;
                default:                   
                    _matrix[i, j].Btn.ForeColor = Color.DarkRed;
                    break;
            }
            

        }
        public void crtaj()
        {            
            for(int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    MojPanel.Controls.Add(_matrix[i, j].Btn);

                    
                    _matrix[i, j].X = i; 
                    _matrix[i, j].Y = j;
                }
            generisiMine();
        }

        private void generisiMine()
        {
            Random r = new Random();
            int x;
            int y;
            int i = 0;
            while (i < _brMina)
            {
                x = r.Next(n - 1);
                y = r.Next(n - 1);
                if (_matrix[x, y].Mina == false)
                {
                    _matrix[x, y].Mina = true;
                    i++;
                }
            }            
        }

        public void KrajIgre()
        {

            Image image1 = Image.FromFile(@"C:\Users\Administrator\Desktop\MS\Mine2.ico");

            int height = this._matrix[0, 0].Btn.Height-10;
            int width = this._matrix[0, 0].Btn.Width-10;
            Bitmap pom = new Bitmap(image1, new Size(width, height));
            
            for (int i = 0; i < this.n; i++)
                for (int j = 0; j < this.n; j++)
                {
                    if (this._matrix[i, j].Mina)
                    {
                        this._matrix[i, j].Btn.Image = pom;
                    }
                    else
                    {
                        this._matrix[i, j].Btn.BackColor = Color.White;
                    }

                }
            this.mojPanel.Enabled = false;
        }

        public void OcistiPolja(int x, int y)
        {
            if ((x > n - 1) || (x < 0) || (y > n - 1) || (y < 0))
                return;
            if (_matrix[x, y].Otvoreno || _matrix[x,y].Zastavica)
                return;
            
            this.brMinaOkolo(x, y);

            if (_matrix[x, y].BrMina == 0)
            {

                if (!_matrix[x, y].Zastavica)
                {
                    
                    this._matrix[x, y].Btn.Enabled = false;
                    _matrix[x, y].Otvoreno = true;
                    _matrix[x, y].Btn.BackgroundImage = null;
                    _matrix[x, y].Btn.Image = null;
                    this._matrix[x, y].Btn.BackColor = Color.LightBlue;
                }

                OcistiPolja(x - 1, y - 1);
                OcistiPolja(x - 1, y);
                OcistiPolja(x - 1, y + 1);
                OcistiPolja(x, y - 1);
                OcistiPolja(x, y + 1);
                OcistiPolja(x + 1, y - 1);
                OcistiPolja(x + 1, y);
                OcistiPolja(x + 1, y + 1);

            }
            else
                return;
                



        }
        public bool Pobedio()
        {

            int broj = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (_matrix[i, j].ImaBroj == true || _matrix[i, j].Otvoreno == true)
                        broj ++;
            BrojPoteza = broj;
            if (broj == (((n * n) - this._brMina)-1))
                return true;
            else
                return false;


        }
        public Polje[] MatricauNiz()
        {
            this.Niz_polja = new Polje[this.n * this.n];
            int k = 0;

            for (int i = 0; i < this.n; i++)
                for (int j = 0; j < this.n; j++)
                {
                    this.Niz_polja[k] =_matrix[i, j];
                    k++;
                }
            return Niz_polja;

        }
        public void NizuMatricu()
        {
            int k = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    MojPanel.Controls.Add(_matrix[i, j].Btn);

                    if (Niz_polja[k].ImaBroj)
                    {
                        int pom = Int32.Parse(Niz_polja[k].UnutrasnjiBroj);
                        _matrix[i, j].Btn.Text = Niz_polja[k].UnutrasnjiBroj;
                        if(pom==1)
                            _matrix[i, j].Btn.ForeColor = Color.Green;
                        else if(pom==2)
                            _matrix[i, j].Btn.ForeColor = Color.Blue;
                        else if (pom==3)                  
                            _matrix[i, j].Btn.ForeColor = Color.Red;
                        else                   
                            _matrix[i, j].Btn.ForeColor = Color.DarkRed;
                    }
                    if (Niz_polja[k].Mina)
                        _matrix[i, j].Mina = true;
                    if (Niz_polja[k].Zastavica)
                    {
                        _matrix[i, j].Zastavica = true;
                        _matrix[i, j].Btn.BackgroundImage = Image.FromFile(@"C:\Users\Administrator\Desktop\MS\Flag.ico");
                    }
                    if(Niz_polja[k].Otvoreno)
                    {
                        _matrix[i, j].Otvoreno = true;
                        _matrix[i, j].Btn.BackColor = Color.LightBlue;

                    }
                    k++;
                }

        }

       

        #endregion

    }
}
