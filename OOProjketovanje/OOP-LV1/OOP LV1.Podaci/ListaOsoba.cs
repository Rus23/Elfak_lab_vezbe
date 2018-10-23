using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LV1.Podaci
{
    public class ListaOsoba
    {

        public delegate void SortDelegate();
        public SortDelegate SortListDelegate { get; set; }
        public void SortListValue()
        {
            if (SortListDelegate != null)
                SortListDelegate();
        }

        private List<Osoba> _listaOsoba;
        #region Properties
        public List<Osoba> ListaOsobaValues
        {
            get
            {
                return _listaOsoba;
            }

            set
            {
                _listaOsoba = value;
            }
        }
        #endregion
        #region Consturctors
        private ListaOsoba()
        {
            _listaOsoba = new List<Osoba>();
        }
        #endregion


        private static ListaOsoba _instance = null; 
        public static ListaOsoba Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListaOsoba();

                return _instance;
            }
        }
    }
}
