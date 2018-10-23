#include <iostream>
#include "Picture.h"
using namespace std;

class Kolekcija
{
	int maxBrS;
	Picture* S;

public:
	Kolekcija();
	~Kolekcija();
	void dodajS(Picture& y);

	void Zauzmi(int b);

	friend ostream& operator<<(ostream& izlaz, const Kolekcija& s1);

};

