#include <iostream>
#include "Utakmica.h"
#include <math.h>
using namespace std;

int progresivno(int ul,int s, int n)
{
	ul *= 2;
	s += ul;
	n--;
	if (n-1 > 0) {
		return progresivno(ul,s, n);
	}
	else {
		return s;
	}
}

void rucno(int n,int prviBr)
{
	int s = 0;
	int k = 0;
	int i = 1;
	for (; i <= n;) {
		k += prviBr;
		s += k;
		i++;
	}
	cout << "For algoritam" << endl
		<< "Zbir je: " << s << endl;
}
void gaus(int n,int prviBr)
{
	double s;
	if (n % 2 == 0) {
		s = n / 2 * (prviBr + prviBr*n);
		cout << "Moj algoritam" << endl
			<< "Zbir je: " << s << endl;
	}
	else {
		n++;
		s = n / 2 * (prviBr + prviBr*n)-prviBr*n;
		cout << "Moj algoritam" << endl
			<< "Zbir je: " << s << endl;
	}
	
}



void main()
{

	int ul;
	int n;
	cout << "~~~PROGRESIVNO KOCKANJE~~~" << endl;
	cout << "Profit u jednom ulaganju?" << endl;
	cin >> ul;
	cout << "Broj ulaganja?" << endl;
	cin >> n;
	cout << "Potrebno ti je: " << progresivno(ul, ul, n) << " din. " << endl << endl;

	Utakmica A;
	A.izracunaj();
	
	cout << endl << "Kraj!" << endl ;
	system("Pause");
}