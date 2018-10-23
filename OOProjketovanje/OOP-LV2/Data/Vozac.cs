using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Data
{
    public class Vozac
    {
        #region Atributes

        String ime;
        String prezime;
        String broj_vozacke_dozvole;
        String mestoIzdavanja;
        String pol;

        
        String putanjaSlike;

        DateTime datumRodjenja;
        DateTime vazenjeDozvole_Do;
        DateTime vazenjeDozvole_Od;
        //ctrl r ctrl e
        ListaZabrana lz;
        ListaKategorija lk;

        String poslednjaZabrana;
        String datumPrvogPolaganja;
       


        public Vozac(String _ime, String _prezime, String _vozacka, String _mesto,String _pol, DateTime _datRodj,DateTime _datOd,DateTime _datDo,ListaKategorija lista_kategorija,ListaZabrana lista_zabrana)
        {
            Ime = _ime;
            Prezime = _prezime;
            Broj_vozacke_dozvole = _vozacka;
            MestoIzdavanja = _mesto;
            Pol = _pol;
            DatumRodjenja = _datRodj;
            VazenjeDozvole_Od = _datOd;
            VazenjeDozvole_Do = _datDo;
            Lz = lista_zabrana;
            Lk = lista_kategorija;



        }


        #endregion
        #region Properties

        public String ZaPrikaz
        {
            get
            {
                return Ime + Prezime + Broj_vozacke_dozvole;
            }
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string Broj_vozacke_dozvole
        {
            get
            {
                return broj_vozacke_dozvole;
            }

            set
            {
                broj_vozacke_dozvole = value;
            }
        }

        public string MestoIzdavanja
        {
            get
            {
                return mestoIzdavanja;
            }

            set
            {
                mestoIzdavanja = value;
            }
        }

        public string Pol
        {
            get
            {
                return pol;
            }

            set
            {
                pol = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                datumRodjenja = value;
            }
        }

        public DateTime VazenjeDozvole_Do
        {
            get
            {
                return vazenjeDozvole_Do;
            }

            set
            {
                vazenjeDozvole_Do = value;
            }
        }

        public DateTime VazenjeDozvole_Od
        {
            get
            {
                return vazenjeDozvole_Od;
            }

            set
            {
                vazenjeDozvole_Od = value;
            }
        }

        public ListaZabrana Lz
        {
            get
            {
                return lz;
            }

            set
            {
                lz = value;
            }
        }

        public ListaKategorija Lk
        {
            get
            {
                return lk;
            }

            set
            {
                lk = value;
            }
        }

        public string PutanjaSlike
        {
            get
            {
                return putanjaSlike;
            }

            set
            {
                putanjaSlike = value;
            }
        }

        public string DatumPrvogPolaganja
        {
            get
            {
                Lk.ListaKategorijaValues.Sort((a, b) => a.DatumOd.CompareTo(b.DatumOd));
                return Lk.ListaKategorijaValues[0].DatumOd.ToShortDateString();
            }
        }
        public string PoslednjaZabrana
        {
            get
            {
                Lk.ListaKategorijaValues.Sort((a, b) => a.DatumDo.CompareTo(b.DatumDo));
                int index = Lz.ListaZabranaValues.Count;
                if (index == 0)
                    return "";
                else
                    return Lz.ListaZabranaValues[index - 1].DatumDo.ToShortDateString();
            }
        }

        #endregion
        #region Constructors
        public Vozac()
        { }
       
        #endregion

    }
}

