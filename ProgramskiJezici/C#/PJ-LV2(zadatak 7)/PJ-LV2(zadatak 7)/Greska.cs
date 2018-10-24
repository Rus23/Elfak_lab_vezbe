using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_LV2_zadatak_7_
{
    class Greska:Exception
    {
        public Greska() : base() { }
        public Greska(string s) : base(s) { }
        public Greska(string s,ref int br) : base(s)
        {
            br *= -1;
        }
        public Greska(string s,ref int brx, ref int bry) : base(s)
        {
            if (brx < 0)
            {
                brx *= -1;
            }
            else
                bry *= -1;
        }
    }
}
