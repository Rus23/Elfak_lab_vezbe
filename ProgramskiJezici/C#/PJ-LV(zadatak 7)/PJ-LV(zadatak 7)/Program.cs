using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_LV_zadatak_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            KonveksanPoligon p = new KonveksanPoligon(4);
            p.printTemena();
            Console.WriteLine("Obim poligona: " + p.obimPoligona()+"m");
            Console.WriteLine("Povrsina poligona: " + p.povrsinaPoligona()+"m^2");
        }
    }
}
