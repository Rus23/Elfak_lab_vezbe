using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tetris2.Podaci
{
    public interface IController
    {
        void levaStrelica();
        void desnaStrelica();
        void goreStrelica();
        void doleStrelica();
        void spejs();

        Model getModel { get; }
    }
}
