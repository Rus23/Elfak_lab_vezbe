#pragma once
#include <iostream>
using namespace std;

class Polinom
{
public: 
	double koeficijent;
	int exponent;
public:
	Polinom() { koeficijent = exponent = 0; }
	Polinom(double kof, int ex) { koeficijent = kof, exponent = ex; }
	Polinom(const Polinom& a) { koeficijent = a.koeficijent, exponent = a.exponent; }
	void setPol(double kof, int ex) { koeficijent = kof, exponent = ex; }
	double getKof() { return koeficijent; }
	int getEx() { return exponent; }
	bool operator==(Polinom&);
	friend void operator <<(ostream& izl, Polinom& po);
};
bool Polinom::operator==(Polinom& a)
{
	if (koeficijent == a.getKof() && exponent == a.getEx())
		return true;
	return false;
}
void operator << (ostream& izl, Polinom& po)
{
	if (po.koeficijent > 0) {
		cout << "+" << po.getKof() << "x^" << po.getEx();
	}
	else {
		cout << po.getKof() << "x^" << po.getEx();
	}

}