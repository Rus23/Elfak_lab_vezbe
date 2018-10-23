using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LV1.Extensions
{
    public static class StringExtensions
    {
        public static bool ProveriFormatZaTelefon(this String s)
        {
            if (s == null || s =="")
                return false;

            char[] fakeArray = s.ToCharArray();

            for(int i=0;i<fakeArray.Length;i++)
            {
                if (i == 0 && fakeArray[i] != '+')
                    return false;
                else if (i == 4 && fakeArray[i] != ' ')
                    return false;
                else if (i == 7 && fakeArray[i] != ' ')
                    return false;
                else if (i != 0 && i != 4 && i != 7 && !Char.IsDigit(fakeArray[i]))
                    return false;               
            }
            return true;
        }
        public static String PostaviPrvoVelikoSlovo(this String s)
        {
            if (String.IsNullOrEmpty(s))
                return s;

            char[] charArray = s.ToCharArray();

            charArray[0] = Char.ToUpper(charArray[0]);

            for (int i = 1; i < charArray.Length; i++)
                charArray[i] = Char.ToLower(charArray[i]);


            String str;
            str = new String(charArray);

            return str;
        }
    }
}
