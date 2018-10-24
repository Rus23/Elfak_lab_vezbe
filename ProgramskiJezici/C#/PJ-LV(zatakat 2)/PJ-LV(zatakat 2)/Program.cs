using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_LV_zatakat_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            IKvadratnaMatrica p = new PunaMatrica(2);
            IKvadratnaMatrica d = new DijagonalnaMatrica(2);
            p.printMatricu();
            Console.Beep();
            Console.WriteLine("Determinanta matrice:"+p.determinantaMatrice());
            d.printMatricu();
            Console.Beep();
            Console.WriteLine("Determinanta dijagonalne matrice:" + d.determinantaMatrice());


        }
    }
}
