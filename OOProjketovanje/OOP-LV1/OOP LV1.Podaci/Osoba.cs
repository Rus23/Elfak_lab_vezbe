using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LV1.Podaci
{
    public partial class Osoba : Object
    {
        #region Atributes
        protected String _ime;
        protected String _prezime;
        protected String _telefon;
        protected String _adresa;
        protected DateTime _datumRodjenja;
        #endregion
        #region Propreties
        public string Ime
        {
            get
            {
                return _ime;
            }

            set
            {
                _ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return _prezime;
            }

            set
            {
                _prezime = value;
            }
        }

        public string Telefon
        {
            get
            {
                return _telefon;
            }

            set
            {
                _telefon = value;
            }
        }

        public string Adresa
        {
            get
            {
                return _adresa;
            }

            set
            {
                _adresa = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return _datumRodjenja;
            }

            set
            {
                _datumRodjenja = value;
            }
        }
        #endregion
        #region Constructors
        public Osoba() { }
        public Osoba(String i, String p, String t, String a, DateTime d)
        {
            _ime = i;
            _prezime = p;
            _telefon = t;
            _adresa = a;
            _datumRodjenja = d;
        }
        #endregion
        public string ToStringOsoba()
        {
            return Ime + Prezime + Telefon + Adresa + DatumRodjenja.ToShortDateString();
        }
        public override string ToString()
        {
            return Ime + " " + Prezime + " Tel: " + Telefon + "; Datum rodjenja: " + DatumRodjenja.ToShortDateString();
        }
    }
}

