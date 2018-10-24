using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_LV2_zadatak_7_
{
    interface IGeometrijskaSlika
    {
        double povrsina();
        double obim();

        void upisi_u_Bin_F(string imeF);
        void procitaj_iz_Bin_F(string imeF);

        void upisi_u_Fajl(string imeF);
        void procitaj_iz_Fajla(string imeF);

        void ucitaj_Sliku();
        void prikazi_Sliku();


    }
}
