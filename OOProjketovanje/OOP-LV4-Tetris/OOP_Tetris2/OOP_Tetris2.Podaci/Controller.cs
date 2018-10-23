using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tetris2.Podaci
{
    public class Controller:IController
    {
        IModel model;
        IView view;

        public Controller(IModel m, IView v)
        {
            this.model = m;
            this.view = v;
            this.view.AddListener(this);
        }

        #region Metode
        public IModel getModel
        {
            get
            {
                return model;
            }
        }

        Model IController.getModel
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void desnaStrelica()
        {
            model.pomeriDesno();
        }

        public void levaStrelica()
        {
            model.pomeriLevo();
        }

        public void spejs()
        {
            model.zalepiDole();
        }

        public void goreStrelica()
        {
            model.rotiraj();
        }

        public void doleStrelica()
        {
            model.ubrzajPad();
        }
        #endregion
    }
}
