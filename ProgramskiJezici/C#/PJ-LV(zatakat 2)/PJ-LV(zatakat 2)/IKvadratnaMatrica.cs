using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_LV_zatakat_2_
{
    interface IKvadratnaMatrica
    {
        double determinantaMatrice();
        void printMatricu();
        int this[int i, int j] { get; set; }
    }
}
