#include "Broj.h"
#include <iostream>
using namespace std;

int Broj::operator>(const Broj* a)
{
	if (this->vrednost > a->vrednost)
	{
		return 1;
	}
	else
	{
		return 0;
	}
}
Broj::Broj()
{
	vrednost = 0;
	vrsta = 0;
}
void Broj::print()
{
	cout << "Vrsta: " << this->vrsta << endl;
	cout << "Vrednost: " << this->vrednost << endl << endl;
}
double Broj::vratiVr()
{
	return this->vrednost;
}
