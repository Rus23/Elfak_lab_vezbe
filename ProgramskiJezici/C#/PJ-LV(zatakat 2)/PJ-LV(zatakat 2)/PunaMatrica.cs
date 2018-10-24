using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_LV_zatakat_2_
{
    class PunaMatrica : IKvadratnaMatrica
    {
        private int dim;
        private int[,] matrix;
        private int[,] m;
   

        public PunaMatrica(int d)
        {
            dim = d;
            matrix = new int[dim,dim];
            for(int i = 0; i < dim; i++)
            {
                for(int j=0;j<dim;j++)
                {
                    Console.WriteLine("Unesite ele. matrice[" + i + "," + j + "]");
                    this[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public int this[int i, int j]
        {
            get
            {
                return matrix[i,j];
            }

            set
            {
                matrix[i,j] = value;
            }
        }

        public double determinantaMatrice()
        {
            int[,] A;
            A= new int[dim,dim];
            int N = dim;
		for(int i = 0; i<dim;i++)
			for(int j = 0; j<dim;j++)
				A[i,j]=matrix[i,j];
		int rez = determinante(A, N);
		return rez;
        }
        public int determinante(int[,] A, int N)
        {
            int res;


            if (N == 1)
                res = A[0,0];
            else if (N == 2)
                res = A[0,0] * A[1,1] - A[1,0] * A[0,1];

            else
            {
                res = 0;
                for (int j1 = 0; j1 < N; j1++)
                {
                    m = generateSubArray(A, N, j1);
                    res += Convert.ToInt32(Math.Pow(-1.0, 1.0 + j1 + 1.0) * A[0, j1] * determinante(m, N - 1));
                }
            }
            return res;
        }
        public int[,] generateSubArray(int[,] A, int N, int j1)
        {
            m = new int[N - 1, N-1];
            //for (int k = 0; k < (N - 1); k++)
            //    m[k] = new int[N - 1];

            for (int i = 1; i < N; i++)
            {
                int j2 = 0;
                for (int j = 0; j < N; j++)
                {
                    if (j == j1)
                        continue;
                    m[i - 1,j2] = A[i,j];
                    j2++;
                }
            }
            return m;
        }

        public void printMatricu()
        {
            Console.WriteLine("Puna matrica: ");
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    Console.Write(this[i,j]+"[" + i + "," + j + "] ");
                }
                Console.WriteLine();
            }
        }
    }
}
