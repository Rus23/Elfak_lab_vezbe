using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_LV2_zadatak_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IGeometrijskaSlika s1 = new KonvekasnNtougao();
                IGeometrijskaSlika s2 = new KonvekasnNtougao();
                IGeometrijskaSlika s3 = new KonvekasnNtougao();

                s1.ucitaj_Sliku();
                s1.upisi_u_Fajl("slika.txt");

                s2.procitaj_iz_Fajla("slika.txt");
                s2.upisi_u_Bin_F("slika.bin");

                s3.procitaj_iz_Bin_F("slika.bin");

                Console.WriteLine("Slika 1");
                s1.prikazi_Sliku();

                Console.WriteLine("Slika 2");
                s2.prikazi_Sliku();

                Console.WriteLine("Slika 3");
                s3.prikazi_Sliku();
                Console.WriteLine("Obim: " + s3.obim() + " Povrsina:" + s3.povrsina());

            }
            catch(Greska g)
            {
                Console.WriteLine(g);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.ReadKey();
            }


        }
    }
}
