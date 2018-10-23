#include <iostream>
#include <math.h>
using namespace std;

int brKomb(int bp)
{
	int n = bp;
	int br = 0;
	for (int i = 0; i < n - 1; i++) {
		for (int j = i + 1; j < n; j++) {
			br++;
		}
	}
	cout << endl;
	cout << "Postoji " << br << " broj kombinacija ako ima "<< bp <<" pitanja, a ti vuces 2!" << endl;
	return br;
}
void odnos() {
	int sto, ti, t = 1, x;
	cout << "Opet zelis da pokrenes f-ju?" << endl
		<< "Posle znakova pitanja (?????)" << endl
		<< "Unesi broj: " << endl
		<< "1 za DA!" << endl
		<< "0 za NE!" << endl;
	while (t==1)
	{
		cout << "Upisi koliko je 100%: " << endl;
		cin >> sto;
		cout << "Upisi tvoj ucinak: " << endl;
		cin >> ti;
		x = (100 * ti) / sto;
		cout << "Ako ti znas " << ti << " od " << sto << " pitanja, to je: " << x << "% " << endl;
		cout << "?????" << endl;
		cin >> t;
		while (t != 0 && t != 1) {
			cout << "Greska!!!" << endl
				<< "Unesi 1 ili 0 !!!" << endl;
			cin >> t;
		}
	}
}

void main()
{
	odnos();
	
	cout << "STOP";
	int stop;
	cin >> stop;
}