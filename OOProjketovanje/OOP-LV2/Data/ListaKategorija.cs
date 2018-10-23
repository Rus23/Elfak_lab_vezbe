using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ListaKategorija
    {
        List<Kategorija> _listaKategorija = new List<Kategorija>();
        public ListaKategorija() { }

        public List<Kategorija> ListaKategorijaValues { get { return _listaKategorija; }  }

        public void DodajKategoriju(Kategorija k)
        {
            _listaKategorija.Add(k);
        }
        public bool ObrisiKategoriju(String kat)
        {
            Kategorija tmpKategorija = null;

            foreach (var k in _listaKategorija )
            {
                if (k.KategorijaValue == kat)
                {
                    tmpKategorija = k;
                    break;
                }
            }

            if (tmpKategorija != null)
            {
                _listaKategorija.Remove(tmpKategorija);
                return true;
            }

            return false;
        }
    }
}
