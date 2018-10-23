#include "Kolekcija.h"
#include "Picture.h"

Kolekcija::Kolekcija()
{
	S = 0;
	maxBrS = 0;

}
Kolekcija::~Kolekcija()
{
	delete[] S;
}
void Kolekcija::dodajS(Picture& y)
{
	Picture h = y;
	int i = 0;
	int t = 1;
	Zauzmi(23);
	cout << "Kolekcija slika:" << endl;
	while (t == 1)
	{
		cout << "Vrednosti nove slike:" << endl;
		cin >> h;
		this->S[i] = h;
		cout << "Slika " << i << endl;
		cout << this->S[i];
		i++;
		maxBrS = i;
		cout << "Trenutni broj slika: " << maxBrS << endl;
		cout << "Unesite:" << endl
			<< "-broj: 1 (ako ZELITE da dodate sliku)" << endl
			<< "-broj: 0 (ako NE ZELITE da dodate sliku)" << endl;
		cin >> t;
		while (t != 1 && t != 0)
		{
			cout << "!!!GRESKA!!!" << endl;
			cout << "Unesite:" << endl
				<< "-broj: 1 (ako ZELITE da dodate sliku)" << endl
				<< "-broj: 0 (ako NE ZELITE da dodate sliku)" << endl;
			cin >> t;
		}
	}
}


void Kolekcija::Zauzmi(int b)
{
	b++;
	S = new Picture[b];
}
ostream& operator<<(ostream& izlaz, const Kolekcija& s1)
{
	cout << "Maximalan broj slika u kolekciji: " << s1.maxBrS << endl;
	for (int i = 0; i < s1.maxBrS; i++)
	{
		izlaz << s1.S[i] << endl;
	}
	return izlaz;
}
