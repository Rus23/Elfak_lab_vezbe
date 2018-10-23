#include "Kolekcija.h"
#include <iostream>
using namespace std;

void main()
{
	int t = 2;
	Picture A(t);
	cout << "Upisati elemente slike (matrice)." << endl;
	cin >> A;
	cout << "Slika A:                       (Matrica A)" << endl;
	cout << A;

	Picture P(A);
	P += 2;
	cout << "Slika P:                       (Matrica P +=2)" << endl;
	cout << P;

	A.Brightness();
	cout << "Slika A:                       (A.Brightness())" << endl;
	cout << A;

	Picture C(t);
	cout << "Slika C:                       (Matrica C = P + A)" << endl;
	C = A + P;
	cout << C;

	A = C;
	cout << "Slika A:                       (Matrica A = C)" << endl;
	cout << A;

	Kolekcija T;
	T.dodajS(A);
	cout << T;

	Picture Q(6);
	cin >> Q;
}