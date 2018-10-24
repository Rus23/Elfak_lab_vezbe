using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_LV2_zadatak_7_
{
    struct Tacka
    {
        private int x, y;

        public int X
        {
            get;
            set;
        }
        public int Y
        {
            get;
            set;
        }
        public override string ToString()
        {
            return "(" + this.X + "," + this.Y + ")";
        }
    }
    class KonvekasnNtougao : IGeometrijskaSlika
    {
        int brT;
        Tacka[] temena;

        char x = 'x';
        char y = 'y';

        public int this[int i, char a] //indexer
        {
            get
            {
                if (a == 'x' || a== 'X')
                {
                    return temena[i].X;
                }
                else if (a == 'y' || a == 'Y')
                {
                    return temena[i].Y;
                }
                else
                    throw new Exception("Losa primena indexera!");
            }
            set
            {
                if (a == 'x' || a == 'X')
                {
                    temena[i].X = value;
                }
                else if (a == 'y' || a == 'Y')
                {
                    temena[i].Y = value;
                }
                else
                    throw new Exception("Losa primena indexera!");
            }
        }
       
        public KonvekasnNtougao()
        {
            brT = 0;
        }
        public KonvekasnNtougao(int b)
        {
            brT = b;
            temena = new Tacka[brT];
        }
        public KonvekasnNtougao(string imeF)
        {
            this.procitaj_iz_Fajla(imeF);
        }

        private double rastojanje(Tacka b, Tacka a)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double obim()
        {
            return obim(brT, 0);
        }
        private double obim(int br, double d)
        {

            br--;
            if (br > 0)
            {
                d += this.rastojanje(this.temena[br], this.temena[br - 1]);
                return obim(br, d);
            }
            else
            {
                return d += this.rastojanje(this.temena[br], this.temena[brT - 1]);
            }
        }
       
        public double povrsina()
        {
            if (brT <= 2)
                throw new Greska("Slika nema povrsinu!");
            return Math.Abs(this.povrsina(brT, 0));
        }
        private double povrsina(int br, double u)
        {
            // p = |x1(y2-y3)+x2(y1-y3)+x3(y1-y2)|
            br--;
            int x1 = brT - 1, x2 = br - 1, x3 = br - 2;
            int y1 = brT - 1, y2 = br - 1, y3 = br - 2;
            u += this[x1, x] * (this[y2,y] - this[y3,y]) + this[x2,x] * (this[y1,y] - this[y3,y]) + this[x3,x] * (this[y1,y] - this[y2,y]);
            if (br - 2 > 0)
            {
                return povrsina(br, u);
            }
            else
            {
                return u;
            }
        }
        public void prikazi_Sliku()
        {
            int i = 1;
            foreach (Tacka t in this.temena)
            {
                Console.Write(" Tacka"+i +t);
                i++;
            }
            Console.WriteLine();
        }

        public void ucitaj_Sliku()
        {
            Console.WriteLine("Unesite broj temena slike");
            int br = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (br < 0)
                    throw new Greska("Upisan je negativan broj!!!", ref br);
            }
            catch(Greska g)
            {
                Console.WriteLine(g);
            }

            brT = br;
            temena = new Tacka[brT];

            for(int i = 0; i < brT; i++)
            {
                Console.WriteLine("Upisite parametar X temena");
                int brX = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Upisite parametar Y temena");
                int brY = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (brY < 0 || brX < 0)
                        throw new Greska("Upisan je negativan broj!!!", ref brX, ref brY);
                }
                catch(Greska g)
                {
                    Console.WriteLine(g);
                }
                finally
                {
                    this[i, x] = brX;
                    this[i, y] = brY;
                }
               
            }
        }

        public void upisi_u_Fajl(string imeF)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(imeF, FileMode.OpenOrCreate)))
            {
                sw.WriteLine(brT);
                foreach (Tacka t in temena)
                {
                    sw.WriteLine(t.X);
                    sw.WriteLine(t.Y);
                }
            }
        }
        public void procitaj_iz_Fajla(string imeF)
        {
            string str = null; 
            using (StreamReader sr = new StreamReader(imeF))
            {
                brT = Convert.ToInt32(sr.ReadLine());
                temena = new Tacka[brT];

                //Console.WriteLine("Iz fajla!!!");
                for(int i=0; i<brT ;i++)
                {
                    this[i, x] = Convert.ToInt32(sr.ReadLine()); // razlika???
                    this[i, y] = Int32.Parse(sr.ReadLine()); // razlika??

                    //Console.Write(" Tacka" + i + temena[i]);
                }
                //Console.WriteLine();
            }
        }

        public void upisi_u_Bin_F(string imeF)
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream(imeF, FileMode.OpenOrCreate)))
            {
                bw.Write(brT);
                foreach(Tacka t in temena)
                {
                    bw.Write(t.X);
                    bw.Write(t.Y);
                }
            }
        }
        public void procitaj_iz_Bin_F(string imeF)
        {
            using(BinaryReader br = new BinaryReader(new FileStream(imeF, FileMode.Open)))
            {
                brT = br.ReadInt32();
                temena = new Tacka[brT];
            for (int i = 0; i < brT; i++)
                {
                    this[i, x] = br.ReadInt32();
                    this[i, y] = br.ReadInt32();

                    //Console.Write(" Tacka" + i + temena[i]);
                }
                //Console.WriteLine();
            }
            
        }
    }
}
