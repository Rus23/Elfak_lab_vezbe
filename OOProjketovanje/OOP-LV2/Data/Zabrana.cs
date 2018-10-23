using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Zabrana
    {
        String kategorija;
        DateTime datumOd;
        DateTime datumDo;
        public Zabrana()
        {

        }
        public Zabrana(String kat,DateTime Od,DateTime Do)
        {
            Kategorija = kat;
            DatumOd = Od;
            DatumDo = Do;
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

        public string Kategorija
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
