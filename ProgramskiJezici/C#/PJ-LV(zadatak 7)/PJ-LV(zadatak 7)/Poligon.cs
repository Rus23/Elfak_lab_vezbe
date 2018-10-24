using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_LV_zadatak_7_
{
    struct Tacka
    {
        //public int x, y;
        //Tacka(int a, int b)
        //{
        //    x = a; y = b;
        //}
        private int X;
        private int Y;

        public int x
        {
            get { return this.X; }
            set { this.X = value; }
        }
        public int y
        {
            get { return Y; }
            set { Y = value; } 
        }

        public Tacka(int a, int b)
        {
            X = a;
            Y = b;
        }
    }
    abstract class Poligon
    {
        protected int brT;
        protected Tacka[] temena;

        public Poligon()
        {
            brT = 0;
            temena = new Tacka[brT];

        }
        public Poligon(int a)
        {
            brT = a;
            temena = new Tacka[brT];
            for(int i=0;i<brT;i++)
            {
                Console.WriteLine("Upisi koordinatu x");
                temena[i].x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Upisi koordinatu y");
                temena[i].y = Convert.ToInt32(Console.ReadLine());
            }
        }

        private double rastojanje(Tacka b, Tacka a)
        {
            double d = Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
            return d;
        }
        public double obimPoligona()
        {
           
            return obimPoligona(brT,0);
            
        }
        public double obimPoligona(int br, double  d)
        {
            br--;
            if (br > 0)
            {
                d += this.rastojanje(this.temena[br], this.temena[br - 1]);
                return obimPoligona( br, d);
            }
            else
            {
                return d += this.rastojanje(this.temena[br], this.temena[brT-1]); 
            }
        }
        public void printTemena()
        {
            foreach(Tacka t in temena)
            {
                int i = 1;
                Console.WriteLine("T" + i + "(" + t.x + "," + t.y + ")");
                i++;
            }
        }
        public abstract double povrsinaPoligona();

    }
}
