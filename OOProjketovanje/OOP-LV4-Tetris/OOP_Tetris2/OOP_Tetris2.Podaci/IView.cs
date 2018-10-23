using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tetris2.Podaci
{
    public interface IView
    {
        void AddListener(IController controller);

        string Total
        {
            get;
            set;
        }
    }
}
