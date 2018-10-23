using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ListaVozaca
    {
        public delegate void SortDelagate();
        public SortDelagate SortListDelegate { get; set; }

        private List<Vozac> Lista_vozaca;

        public List<Vozac> ListaVozacaValues
        {
            get
            {
                return Lista_vozaca;
            }
        }

        private ListaVozaca()
        {
            Lista_vozaca = new List<Vozac>();
        }

        private static ListaVozaca instanca = null;

        public static ListaVozaca Instanca
        {
            get
            {
                if (instanca == null)
                    instanca = new ListaVozaca();
                return instanca;

            }
        }
        public void SortListValue()
        {
            if (SortListDelegate != null)
                SortListDelegate();
        }

        #region Metode
        public bool DodajVozaca(Vozac o)
        {
            if (PostojiVozacUListi(o))
                return false;

            Lista_vozaca.Insert(0, o);
            return true;
        }
        public bool ObrisiListu()
        {

            if (Lista_vozaca.Count == 0)
                return false;
            else
            {
                Lista_vozaca.Clear();
                return true;
            }
        }

        public bool ObrisiVozaca(Vozac o)
        {
            if (!PostojiVozacUListi(o))
                return false;

            Lista_vozaca.Remove(o);
            return true;
        }

        public bool ObrisiVozaca(String brVozacke)
        {
            Vozac tmpVozac = null;

            foreach (var v in Lista_vozaca)
            {
                if (v.Broj_vozacke_dozvole == brVozacke)
                {
                    tmpVozac = v;
                    break;
                }
            }

            if (tmpVozac != null)
            {
                Lista_vozaca.Remove(tmpVozac);
                return true;
            }

            return false;
        }

        public bool PostojiVozacUListi(Vozac o)
        {
            foreach (var v in Lista_vozaca)
            {
                if (v.Broj_vozacke_dozvole == o.Broj_vozacke_dozvole)
                    return true;
            }

            return false;
        }

        public bool PostojiVozacUListi(String brVozacke)
        {
            foreach (var v in Lista_vozaca)
            {
                if (v.Broj_vozacke_dozvole == brVozacke)
                    return true;
            }

            return false;
        }

        public Vozac GetVozac(String brVozacke)
        {
            foreach (var v in Lista_vozaca)
            {
                if (v.Broj_vozacke_dozvole == brVozacke)
                    return v;
            }

            return null;
        }
        #endregion

    }
}
