#pragma once
#include <iostream>
#include <fstream>
#include "Hrana.h"
#include "Greska.h"

using namespace std;

class Tikvica : public Hrana
{
private:
	char* vrsta;
	int duzina;

public:
	Tikvica() :vrsta("NeZnamo"),duzina(1){}
	Tikvica(char* vrs, int duz, int klasA)
		:vrsta(vrs), duzina(duz)
	{
		if (duz<klasA)
		{
			B = 10, A = 0;
		}
		else { A = 10, B = 0; }
	}

	friend ostream& operator << (ostream& izl, Tikvica& jab);
	friend ofstream& operator << (ofstream&, Tikvica&);
	friend ifstream& operator >> (ifstream&, Tikvica&);
};
ifstream& operator >> (ifstream& ul, Tikvica& tk)
{
	char* p = new char;
	ul >> p 
		>> tk.duzina
		>> tk.A 
		>> tk.B;
	tk.vrsta = p;
	return ul;
}


ofstream& operator << (ofstream& izl, Tikvica& tk)
{
	izl << tk.vrsta << endl
		<< tk.duzina << endl
		<< tk.A << endl
		<< tk.B;
	return izl;
}


ostream& operator << (ostream& izl, Tikvica& jab)
{
	izl << "Vrsta: " << jab.vrsta << endl;
	cout << "Duzina: " << jab.duzina << endl;
	if (jab.A) { cout << "Klasa: A"; }
	else { cout << "Klasa: B"; }
	return izl;
}