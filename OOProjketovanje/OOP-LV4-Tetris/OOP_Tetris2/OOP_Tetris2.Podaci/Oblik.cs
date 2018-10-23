using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOP_Tetris2.Podaci
{
    public class Oblik
    {
        Model model;
        int idOblika;
        String boja;
       

        Label[,] matLabela;
         
        int n;
        int[,] matrix;

        int x;
        int y;

        int w;
        int h;
        #region Property
        public Model Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public int IdOblika
        {
            get
            {
                return idOblika;
            }

            set
            {
                idOblika = value;
            }
        }

        public string Boja
        {
            get
            {
                return boja;
            }

            set
            {
                boja = value;
            }
        }

        public Label[,] MatLabela
        {
            get
            {
                return matLabela;
            }

            set
            {
                matLabela = value;
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

        public int[,] Matrix
        {
            get
            {
                return matrix;
            }

            set
            {
                matrix = value;
            }
        }

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

        public int W
        {
            get
            {
                return w;
            }

            set
            {
                w = value;
            }
        }

        public int H
        {
            get
            {
                return h;
            }

            set
            {
                h = value;
            }
        }

       
        #endregion

        #region Konstruktroske metode
        void postaviSveNule()
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    Matrix[i, j] = 0;
        }
        void inicijalizujMAtLab()
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    MatLabela[i, j] = new Label();

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    
                    MatLabela[i, j].BorderStyle = BorderStyle.FixedSingle;
                    MatLabela[i, j].BackColor = Color.Azure;                   

                }
        }
        void staviVelicnieLabele(int w, int h)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    MatLabela[i, j].Width = 20;
                    MatLabela[i, j].Height = 20;

                }
        }
        #endregion

        #region Konstruktori
        public Oblik() { }
        public Oblik(int id)
        {
            IdOblika = id;

            N = 3;
            Matrix = new int[N, N];
            postaviSveNule();

            MatLabela = new Label[N, N];
            inicijalizujMAtLab();
            

            switch (id) 
            { //0-nista; 1-naDole; 2-naDesno; 3-naLevo; 4-naDesno + naDole; 5-naLevo + naDole; 
                //6 - naLevo + naDesno; 7-naLevo + naDesno + naDole
                case 0:
                    Matrix[2, 1] = 7;
                    MatLabela[2, 1].BackColor = System.Drawing.Color.Yellow;
                    break;
                case 1:
                    Matrix[0, 1] = 6;
                    Matrix[1, 1] = 6;
                    Matrix[2, 1] = 7;
                    MatLabela[0, 1].BackColor = System.Drawing.Color.Blue;
                    MatLabela[1, 1].BackColor = System.Drawing.Color.Blue;
                    MatLabela[2, 1].BackColor = System.Drawing.Color.Blue;
                    break;
                case 2:
                    Matrix[0, 0] = 0; Matrix[0, 1] = 6; Matrix[0, 2] = 0;
                    Matrix[1, 0] = 5; Matrix[1, 1] = 0; Matrix[1, 2] = 4;
                    Matrix[2, 0] = 0; Matrix[2, 1] = 7; Matrix[2, 2] = 0;
                    MatLabela[0, 1].BackColor = Color.Purple;
                    MatLabela[2, 1].BackColor = Color.Purple;
                    for (int i = 0; i < N; i++)
                            MatLabela[1, i].BackColor = Color.Purple;
                    break;
                case 3:
                    Matrix[0, 0] = 3; Matrix[0, 1] = 0; Matrix[0, 2] = 2;
                    Matrix[1, 0] = 3; Matrix[1, 1] = 0; Matrix[1, 2] = 2;
                    Matrix[2, 0] = 5; Matrix[2, 1] = 1; Matrix[2, 2] = 4;
                    for (int i = 0; i < N; i++)
                        for (int j = 0; j < N; j++)
                            MatLabela[i, j].BackColor = Color.Green;
                    break;
                case 4:
                    Matrix[0, 0] = 0; Matrix[0, 1] = 0; Matrix[0, 2] = 0;
                    Matrix[1, 0] = 0; Matrix[1, 1] = 6; Matrix[1, 2] = 0;
                    Matrix[2, 0] = 5; Matrix[2, 1] = 1; Matrix[2, 2] = 4;

                    matLabela[1, 1].BackColor = Color.Red;
                    matLabela[2, 0].BackColor = Color.Red;
                    matLabela[2, 1].BackColor = Color.Red;
                    matLabela[2, 2].BackColor = Color.Red;
                    break;
                case 5:
                    Matrix[0, 0] = 0; Matrix[0, 1] = 0; Matrix[0, 2] = 0;
                    Matrix[1, 0] = 6; Matrix[1, 1] = 0; Matrix[1, 2] = 6;
                    Matrix[2, 0] = 5; Matrix[2, 1] = 1; Matrix[2, 2] = 4;

                    matLabela[1, 0].BackColor = Color.OrangeRed;
                    matLabela[1, 2].BackColor = Color.OrangeRed;
                    matLabela[2, 0].BackColor = Color.OrangeRed;
                    matLabela[2, 1].BackColor = Color.OrangeRed;
                    matLabela[2, 2].BackColor = Color.OrangeRed;

                    break;
                default:
                    Matrix[2, 1] = 7;
                    MatLabela[1, 1].BackColor = System.Drawing.Color.Yellow;                    
                    break;
            }


        }
        #endregion
    }
}
