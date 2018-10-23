using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tetris2.Podaci
{
    public interface IModel
    {
        void promeniSkor();

        void pomeriLevo();
        void pomeriDesno();
        void zalepiDole();
        void ubrzajPad();
        void rotiraj();

        void pokreni();
        bool zaustavi();
       

        void crtajPanel();
      
    }
}
