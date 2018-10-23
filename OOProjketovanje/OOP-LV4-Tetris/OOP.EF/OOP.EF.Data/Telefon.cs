using System.ComponentModel;

namespace OOP.EF.Data
{
    public class Telefon
    {
        public long student_telefon_id
        {
            get;
            set;
        }

        [DisplayName("Telefon")]
        public string telefon
        {
            get;
            set;
        }
    }
}
