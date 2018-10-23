using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Kategorija
    {
        String kategorija;
        DateTime datumOd;
        DateTime datumDo;
        public Kategorija()
        {

        }
        public Kategorija(String kat, DateTime Od, DateTime Do)
        {
            KategorijaValue = kat;
            DatumOd = Od;
            DatumDo = Do;
        }

        public string KategorijaValue
        {
            get
            {
                return kategorija;
            }
            set
            {
                kategorija = value;
            }
        }
        
        public String DatumOdValue
        {
            get
            {
                return DatumOd.ToString("dd.MM.yyyy.");

            }
        }
        public String DatumDoValue
        {
            get
            {
                return DatumDo.ToString("dd.MM.yyyy.");
            }
        }


        public DateTime DatumOd
        {
            get
            {
                return datumOd;
            }

            set
            {
                datumOd = value;
            }
        }

        public DateTime DatumDo
        {
            get
            {
                return datumDo;
            }

            set
            {
                datumDo = value;
            }
        }
    }
}
