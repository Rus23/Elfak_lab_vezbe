#pragma once
#include <iostream>
using namespace std;

class Broj
{
protected:
	char* vrsta;
	double vrednost;
public:
	Broj();
	int operator>(const Broj* a);
	virtual void print(); 

	virtual double vratiVr(); 

protected:
	virtual void postVr() = 0; 
};
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