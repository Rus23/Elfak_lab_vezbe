using System.ComponentModel;

namespace OOP.EF.Data
{
    public class IspitCustom
    {        
        public long student_ispit_id
        {
            set;
            get;
        }
  
        public int ispit_id
        {
            set;
            get;
        }

        [DisplayName("Šifra")]
        public string sifra
        {
            set;
            get;
        }

        [DisplayName("Naziv")]
        public string naziv
        {
            set;
            get;
        }
    }
}
