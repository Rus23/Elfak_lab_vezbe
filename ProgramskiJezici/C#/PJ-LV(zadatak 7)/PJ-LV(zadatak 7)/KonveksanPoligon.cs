using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_LV_zadatak_7_
{
    class KonveksanPoligon : Poligon
    {
       public KonveksanPoligon(int a) : base(a) { }

        public override double povrsinaPoligona()
        {
           return Math.Abs(this.povrsinaPoligona(brT, 0));
        }
        private double povrsinaPoligona(int br, double u)
        {// p = |x1(y2-y3)+x2(y1-y3)+x3(y1-y2)|
            br--;
            int x1 = brT - 1, x2 = br - 1, x3 = br - 2;
            int y1 = brT - 1, y2 = br - 1, y3 = br - 2;
            u += this.temena[x1].x * (this.temena[y2].y - this.temena[y3].y) + this.temena[x2].x * (this.temena[y1].y - this.temena[y3].y) + this.temena[x3].x * (this.temena[y1].y - this.temena[y2].y);
            if (br-2 > 0  )
            {
                return povrsinaPoligona(br, u);
            }
            else
            {
                return u;
            }
        }
    }
}
