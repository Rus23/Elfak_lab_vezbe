using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LV1.Extensions
{
    public static class DateTimeExtensions
    {
        public static string TrenutnoSistmeskoVreme(this DateTime d)
        {
            d = DateTime.Now;
            return d.ToString("dd.MM.yyyy HH.mm");
        }
    }
}
