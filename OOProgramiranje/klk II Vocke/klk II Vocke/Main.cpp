#include <iostream>
#include <fstream>
#include "Hrana.h"
#include "Jabuka.h"
#include "Masina.h"
#include "Tikvica.h"
#include "Greska.h"

using namespace std;

void main()
{
	try
	{
		Masina<Tikvica, 2, 2> gaj_T;
		/*
		Masina<Jabuka, 2, 2> gaj_J;
		Jabuka j1("Srbija", 160, 150);
		Jabuka j2("Srbija", 120, 150);
		Jabuka j3("Srbija", 160, 150);
		Jabuka j4("Srbija", 100, 150);
		gaj_J.dodaj(j1);
		gaj_J.dodaj(j2);
		gaj_J.dodaj(j3);
		gaj_J.dodaj(j4);
		cout << "Gajbica sa 4 jabuke:" << endl;
		cout << gaj_J;
		gaj_J.prebaci_u_Hladnjacu("HladnjacaJabuka.txt");
		Masina<Jabuka, 3, 3> novaG;
		novaG.vrati_iz_Hladnjace("HladnjacaJabuka.txt");
		cout << "Nova gajbica:" << endl;
		cout << novaG << endl;*/
		Masina<Tikvica, 2, 2> novaT;
		Tikvica t1("Zelena1", 17, 15);
		Tikvica t2("Zelena2", 18, 15);
		Tikvica t3("Zelena3", 19, 15);
		Tikvica t4("Zelena4", 20, 15);
		gaj_T.dodaj(t1);
		gaj_T.dodaj(t2);
		gaj_T.dodaj(t3);
		gaj_T.dodaj(t4);
		gaj_T.prebaci_u_Hladnjacu("Tikvice.txt");
		cout << "*Gajbica Tikvica: " << endl;
		cout << gaj_T << endl;
		novaT.vrati_iz_Hladnjace("Tikvice.txt");
		cout << "*Gajbica Novaa: " << endl;
		cout << novaT << endl;
		
	}
	catch (Greska g) {
		cout << "~~~~~DOSLO JE DO GRESKE~~~~~" << endl
			<< "          BR : " << g;
	}

	int stop;
	cin >> stop;
}