using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ListaZabrana
    {
        List<Zabrana> _listaZabrana=new List<Zabrana>();
        public ListaZabrana() { }

        public List<Zabrana> ListaZabranaValues
        {
            get { return _listaZabrana; }
            set { _listaZabrana = value; }
        }

        public void DodajZabranu(Zabrana z)
        {
            _listaZabrana.Add(z);
        }
        public bool ObrisiZabranu(String zab)
        {
            Zabrana tmpZabrana = null;

            foreach (var k in _listaZabrana)
            {
                if (k.Kategorija == zab)
                {
                    tmpZabrana = k;
                    break;
                }
            }

            if (tmpZabrana != null)
            {
                _listaZabrana.Remove(tmpZabrana);
                return true;
            }

            return false;
        }
    }
}
