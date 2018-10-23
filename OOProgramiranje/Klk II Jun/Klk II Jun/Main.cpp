#include <iostream>
#include "Matrica.h"
#include <fstream>
using namespace std;

void main()
{
	int a;
	Matrica<int, 3> m1;
	m1.ReadEle("Matrica.txt");
	cout << m1;
	cout << "Nesto, msm 1:" << endl;
	int b0 = 1;
	int* b = new int;
	int* b1 = new int;
	b1 = &b0;
	cout << b1;
	cin >> a;

}