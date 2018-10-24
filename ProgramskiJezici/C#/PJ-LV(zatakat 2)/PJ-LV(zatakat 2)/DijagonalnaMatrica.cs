using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_LV_zatakat_2_
{
    class DijagonalnaMatrica : IKvadratnaMatrica
    {
        int dim;
        int[] gDijag;

        public DijagonalnaMatrica(int d)
        {
            dim = d;
            gDijag = new int[dim];
            for(int i=0;i<dim;i++)
            {
                Console.WriteLine("Unesite ele. dijagonanlne matrice[" + i +","+i+ "]");
                this.gDijag[i] = Convert.ToInt32(Console.ReadLine());
            }
        }


        public int this[int i, int j]
        {
            get
            {
                if (i == j)
                    return this.gDijag[i];
                else
                    return 0;
            }

            set
            {
                if (i == j)
                    this.gDijag[i] = value;
                else
                    return;
            }
        }

        public double determinantaMatrice()
        {
            int u = 1;
            foreach(int d in this.gDijag)
            {
                u *= d;
            }
            return u;
        }

        public void printMatricu()
        {
            Console.WriteLine("Dijagonalna matrica: ");
            for(int i=0; i < dim; i++)
            {
                for(int j =0;j<dim;j++)
                {
                    Console.Write(this[i,j] + "[" + i + "," + j + "] ");
                }
                Console.WriteLine();
            }
        }
    }
}
