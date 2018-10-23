#pragma once
#include <iostream>
#include <fstream>
#include "Greska.h"
using namespace std;

template <class T,int n, int m>
class Masina
{
	T** mat;
	int ii=0;
	int jj=0;
	char* klasa = "KlasaA";
	
public:
	Masina() { zauzmi(); }
	~Masina() { obrisi(); }

	void dodaj(T&);
	void ukloni(int, int);

	void sortiraj(Masina&);

	void prebaci_u_Hladnjacu(char*);
	void vrati_iz_Hladnjace(char*);

	friend ostream& operator << <>(ostream& izl, Masina<T,n,m>& obj);


	void zauzmi();
	void obrisi();

};
template <class T, int n, int m>
void Masina<T, n, m>::vrati_iz_Hladnjace(char* moj_fajl)
{
	int dim1, dim2;
	char* pom = new char;
	ifstream fajl;
	fajl.open(moj_fajl, ios_base::in);
	if (fajl.good()) {
			fajl >> pom
				>> dim1
				>> dim2;
			this->klasa = pom;
			if (dim1 <= n && dim2 <= m) {
				for (int i = 0; i < dim1; i++) {
					for (int j = 0; j < dim2; j++) {
						fajl >> mat[i][j];
					}
				}
			}
			else { throw NEMA_DOVOLJNO_MESTA_U_GAJBICI; }
		
	}
	else { throw ZAGLAVILA_SE_VRATA_HLADNJACE; }
	}


template <class T, int n, int m>
void Masina<T, n, m>::prebaci_u_Hladnjacu(char* moj_fajl)
{
	ofstream fajl(moj_fajl);
	if (fajl.good())
	{
		fajl << klasa << endl
			<< n << endl
			<< m << endl;
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				fajl << mat[i][j];
			}
		}
	}
	else { throw GRESKA_SA_HLADNJACOM; }
	fajl.close();
}

template <class T, int n, int m>
ostream& operator << <>(ostream& izl, Masina<T,n,m>& obj)
{
	cout << obj.klasa << endl;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j<m; j++) {
			izl << obj.mat[i][j] << " ";
		}
		cout << endl;
	}
	
	return izl;
}

template <class T, int n, int m>
void Masina<T, n, m>::ukloni(int a, int b)
{
	if (a == ii && b == jj) {
		delete mat[a][b];
		if (ii == 0) { ii = n - 1, j--; }
		else
		{
			ii--;
		}
	}
	else
	{
		throw MOZE_SE_SKLONITI_SAMO_ELEMENT_KOJI_JE_ZADNJI_UNESEN;
	}
}

template <class T, int n, int m>
void Masina<T, n, m>::dodaj(T& a)
{
	int p = 2;
	int pi = ii + 1;
	int pj = jj + 1;
	if (pi*pj <= n*m)
	{
		mat[ii][jj] = a;
		if (a < p) { klasa = "KlasaB"; }
		if (jj < m-1) { 
			jj++;
		}
		else{
			jj = 0;
			if (ii < n-1) {
				ii++;
			}
		}
	}
	else { throw NEMA_MESTA; }
}


template <class T, int n, int m>
void Masina<T, n, m>::obrisi()
{
	for (int i = 0; i < n; i++) {
		delete[] mat[i];
	}
	delete[] mat;
}

template <class T, int n, int m>
void Masina<T, n, m>::zauzmi()
{
	this->mat = new T*[n];
	for (int i = 0; i < n; i++)
		mat[i] = new T[n];
}
