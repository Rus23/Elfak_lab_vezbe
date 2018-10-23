using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_LV1.Podaci;

namespace OOP_LV1.Extensions
{
    public static class ListaOsobaExtensions
    {
        
        public static void DodajOsobu(this ListaOsoba l, Osoba o)
        {
            l.ListaOsobaValues.Insert(0, o);
        }
        private static Osoba NadjiOsobu(this ListaOsoba l, Osoba o)
        {
            var osoba = l.ListaOsobaValues.Find(x => x.Ime == o.Ime && x.Prezime == o.Prezime);
            return osoba;
        }
        public static bool ObrisiOsobu(this ListaOsoba l, Osoba o)
        {
            var osoba = l.NadjiOsobu(o);
            if(osoba != null)
            {
                l.ListaOsobaValues.Remove(osoba);
                return true;
            }
            return false;
        }
        public static void ObrisiListu(this ListaOsoba lista)
        {
            lista.ListaOsobaValues.Clear();
        }
    }
}
