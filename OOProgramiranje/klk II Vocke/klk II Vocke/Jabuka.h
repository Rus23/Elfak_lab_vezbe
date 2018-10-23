#pragma once
#include <iostream>
#include <fstream>
#include "Hrana.h"
#include "Greska.h"

using namespace std;

class Jabuka : public Hrana
{
private:
	char* zemlja_Porekla;
	int tezina;


public:
	Jabuka() { zemlja_Porekla = "NeZnamo", tezina = 1; }
	Jabuka(char* zemlja, int tez, int klasA)
		:zemlja_Porekla(zemlja),tezina(tez)
	{
		if (tez < klasA) {
			this->B = 1;
			A = 0;}
		else { A = 10, B = 0; }
	}

	friend ostream& operator << (ostream& izl, Jabuka& jab);
	friend ofstream& operator << (ofstream&, Jabuka&);
	friend ifstream& operator >> (ifstream&, Jabuka&);



};
ifstream& operator >> (ifstream& ul, Jabuka& jab)
{
	char* p = new char;
	ul >> p 
		>> jab.tezina 
		>> jab.A
		>> jab.B;
	jab.zemlja_Porekla = p;
	return ul;
}

ofstream& operator << (ofstream& izl, Jabuka& jab)
{
	izl << jab.zemlja_Porekla << endl
		<< jab.tezina << endl
		<< jab.A << endl
		<< jab.B << endl;
	return izl;
}

ostream& operator << (ostream& izl, Jabuka& jab)
{
	izl << "Zemlja porekla: " << jab.zemlja_Porekla << endl
		<< "Tezina: " << jab.tezina << endl;
	if (jab.A) {
		cout << "Klasa: A" << endl;
	}
	else { cout << "Klasa: B" << endl; }
	return izl;
}

