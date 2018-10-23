#pragma once
#include <iostream>
#include <math.h>
using namespace std;

class Utakmica
{
	double kvota_00;
	double kvota_10;
	double kvota_2plus;
	double pare;

public:
	Utakmica() :kvota_00(0), kvota_10(0), kvota_2plus(0), pare(0) {}

	Utakmica(double kv_00, double kv_10, double kv_2plus, double ulog)
	{
		kvota_00 = kv_00;
		kvota_10 = kv_10;
		kvota_2plus = kv_2plus;
		pare = ulog;
	}
	

	void izracunaj();

};
void Utakmica::izracunaj()
{
	int t = 1;
	cout << "Zelis da se program ponovo pokrene? " << endl
		<< "Posle znakova pitanja (?????) unesi: " << endl
		<< "1 za DA" << endl
		<< "0 za NE ( ili bilo koji drugi broj)" << endl;
	double dobitak;
	double tk1_00, tk2_10, tk3_2plus, proc, profit, kvota;
	while (t == 1) {
		cout << "Unesite kvotu za konacan ishod 0:0 " << endl;
		cin >> kvota_00;
		cout << "Unesite kvotu za pobedu favorita 1:0" << endl;
		cin >> kvota_10;
		cout << "Unesite kvotu za 2+" << endl;
		cin >> kvota_2plus;
		cout << "Koliki dobitak zelite? " << endl;
		cin >> dobitak;
		//cout << "Koliki profit zelite u % ?" << endl;
		//cin >> proc;
		//dobitak = pare + (pare * 8) / 100;

		tk1_00 = dobitak / kvota_00;
		tk2_10 = dobitak / kvota_10;
		tk3_2plus = dobitak / kvota_2plus;
		pare = tk1_00 + tk2_10 + tk3_2plus;
		profit = dobitak - pare;
		proc = (profit * 100) / pare;

		cout << endl << "Dobitak: " << dobitak << " din." << endl; // NIJE CONST !!!
		cout << "Profit: " << profit << " din. (" << proc << "%)" << endl << endl; // NIJE CONST !!!
		cout << "Ukupan ulog: " << pare << " din." << endl << endl;
		cout << "Tiket(0:0) treba uplatiti za: " << tk1_00 << " din. " << endl;
		cout << "Tiket(1:0) treba uplatiti za: " << tk2_10 << " din. " << endl;
		cout << "Tiket(2+) treba uplatiti za: " << tk3_2plus << " din. " << endl << endl;

		cout << "?????" << endl;
		cin >> t;

	}
	
		
	

	
	
}
