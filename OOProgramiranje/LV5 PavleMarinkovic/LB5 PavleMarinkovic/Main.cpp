#include "Matrica.h"
#include "Complex.h"
#include <iostream>
using namespace std;

void main()
{
	Matrica <int> M(2, 3);
	cout << "Unesi matricu M:" << endl;
	for (int i = 0; i < M.GetX(); i++) {
		for (int j = 0; j < M.GetY(); j++)
		{
			int ele;
			cin >> ele;
			M.SetElement(i, j, ele);
		}
	}
	cout << "Matrica M " << endl;
	cout << M;

	Matrica <int> M1(3, 2);    // vrati na 3,2 
	cout << "Unos Matrica M1:" << endl;
	for (int i = 0; i < M1.GetX(); i++) {
		for (int j = 0; j < M1.GetY(); j++)
		{
			int ele;
			cin >> ele;
			M1.SetElement(i, j, ele);
		}
	}
	cout << "Matrica M1" << endl << M1 << endl << "Matrica M2" << endl << M << endl << endl;
	Matrica <int> M2(2, 2);
	cout << "M2 = M1 * M" << endl;
	M2 = M1*M;
	cout << "Matrica M2:" << endl;
	cout << M2 << endl;
	cout << "Kraj Matrica <int> " << endl;


	Matrica <Complex> K1(3, 2);
	cout << "Unesi matricu K1:" << endl;
	for (int i = 0; i < K1.GetX(); i++) {
		for (int j = 0; j < K1.GetY(); j++)
		{
			Complex ele;
			cin >> ele;
			K1.SetElement(i, j, ele);
		}
	}
	cout << "Matrica K1 " << endl;
	cout << K1 << endl;

	Matrica <Complex> K2(2, 3);
	cout << "Unesi matricu K2:" << endl;
	for (int i = 0; i < K2.GetX(); i++) {
		for (int j = 0; j < K2.GetY(); j++)
		{
			Complex ele;
			cin >> ele;
			K2.SetElement(i, j, ele);
		}
	}
	cout << "Matrica K1:   " << endl << K1 << "Matrica K2:" << endl << K2 << endl << endl;


	Matrica <Complex> K3(2, 2);
	cout << "K3 = K1 * K2" << endl << endl;
	K3 = K1 * K2;
	cout << "Matrica K3:" << endl;
	cout << K3;
	cout << "Kraj Matrica<Complex> " << endl;

	system("Pause");

	
}