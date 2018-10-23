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
    [Serializable]
    public class Polje
    {
        #region Atributes

        private Game _igra;

        private bool _mina = false;
        private bool _zastavica = false;
        private bool _otvoreno = false;


        private int _brMina;

        private bool _imaBroj=false;


        private Button _btn;

        private int _x;
        private int _y;

        #endregion
        #region Propreties
        [XmlElementAttribute("Mina")]
        public bool Mina
        {
            get
            {
                return _mina;
            }

            set
            {
                _mina = value;
            }
        }
        [XmlElementAttribute("Zastavica")]
        public bool Zastavica
        {
            get
            {
                return _zastavica;
            }

            set
            {
                _zastavica = value;
            }
        }
        [XmlElementAttribute("Otvoreno")]
        public bool Otvoreno
        {
            get
            {
                return _otvoreno;
            }

            set
            {
                _otvoreno = value;
            }
        }
        [XmlIgnore]
        public Button Btn
        {
            get
            {
                return _btn;
            }

            set
            {
                _btn = value;
            }
        }
        [XmlElementAttribute("X")]
        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }
        [XmlElementAttribute("Y")]
        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }
        [XmlIgnore]
        public Game Igra
        {
            get
            {
                return _igra;
            }

            set
            {
                _igra = value;
            }
        }
        [XmlIgnore]
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
        [XmlElementAttribute("Unutrasnjitext")]
        public String UnutrasnjiBroj
        {
            get
            {
                if (this.Btn.Text != String.Empty)
                    return this.Btn.Text;
                else return "";

            }
            set
            {
                this.Btn.Text =value;

            }

        }

        public bool ImaBroj
        {
            get
            {
                return _imaBroj;
            }

            set
            {
                _imaBroj = value;
            }
        }



        #endregion
        #region Constructors
        public Polje()
        {
            Btn = new Button();
        }
        public Polje(Game igra, int x, int y, bool mina)
        {
            Igra = igra;


            X = x;
            Y = y;
            if (mina)
                Mina = mina;
            else
                Otvoreno = mina;

            Btn = new Button();

            Btn.Text = "";
           // Btn.Width = 10;
          //  Btn.Height = 10;
            int w = igra.MojPanel.Width / igra.N;
            int h = igra.MojPanel.Height / igra.N;

            Btn.Width = w ;
            Btn.Height = h;

            Btn.Left = w * X;
            Btn.Top = h * Y;

            Btn.Font = new Font(Btn.Font.FontFamily,Btn.Font.Size, FontStyle.Bold);

         //   Btn.Click += new EventHandler(this.Klik);
            Btn.MouseUp += new MouseEventHandler(this.ObaKlika);

        }
        #endregion
        #region Metode

        public void Sivo()
        {
            if (Igra.Matrix[this.X, this.Y]._zastavica)
            {
                Igra.Matrix[this.X, this.Y]._zastavica = false;
                Igra.Matrix[this.X, this.Y].Btn.BackgroundImage = Image.FromFile(@"C:\Users\Aleksa Simic\Desktop\Minesweeper\siva.png");
                if (Igra.Matrix[this.X, this.Y].Btn.Text == String.Empty)
                    Igra.Matrix[this.X, this.Y].Btn.BackColor = Color.Azure;
            }
        }
        public void ObaKlika(object sender,MouseEventArgs e)
        {

            if(e.Button == MouseButtons.Right)
            {
                if (Igra.Matrix[this.X, this.Y].Btn.Text != String.Empty)
                    return;
                Igra.Matrix[this.X, this.Y].Btn.Image = null;
                if (Igra.Matrix[this.X, this.Y]._zastavica )
                {
                    Igra.Matrix[this.X, this.Y]._zastavica = false;

                    Igra.Matrix[this.X, this.Y].Btn.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\MS\siva.png");
                    Igra.BrZastavica++;
                }
                else
                {

                    Igra.Matrix[this.X, this.Y]._zastavica = true;
                    Image image1 = Image.FromFile(@"C:\Users\Administrator\Desktop\MS\Flag.ico");
                    Igra.BrZastavica--;
                    

                    Igra.Matrix[this.X, this.Y].Btn.Image = image1;
                }

            }
            else
            {
                if (Igra.Pobedio())
                    MessageBox.Show("Bravo,pobedili ste minsko polje!", "Obavestanje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Igra.Matrix[this.X, this.Y]._zastavica)
                    return;

                if (Igra.Matrix[this.X, this.Y].Mina)

                {
                    Igra.Kraj = true;
                    Igra.Matrix[this.X, this.Y].Btn.BackColor = Color.Red;
                    Igra.KrajIgre();
                    DialogResult d = MessageBox.Show("Kraj igre!", "Mina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    Igra.brMinaOkolo(this.X, this.Y);
                    if (Igra.Matrix[this.X, this.Y].BrMina == 0)
                        Igra.OcistiPolja(this.X, this.Y);
                }



            }



           


        }
      /*  public void Klik(object sender, EventArgs e)
        {
            Button pomBtn = sender as Button;
            
            MouseEventArgs me = e as MouseEventArgs;
            if (Igra.Matrix[this.X,this.Y]._zastavica)
                return;

            if(Igra.Matrix[this.X, this.Y].Mina)

            {
                Igra.Matrix[this.X, this.Y].Btn.BackColor = Color.Red;
                Igra.KrajIgre();
                DialogResult d = MessageBox.Show("Kraj igre!", "Mina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else //ovde treba neka rekurzija
            {
                Igra.brMinaOkolo(this.X, this.Y);
                if(Igra.Matrix[this.X,this.Y].BrMina == 0)
                    Igra.OcistiPolja(this.X,this.Y);
            }
        }*/
        #endregion
    }
}
