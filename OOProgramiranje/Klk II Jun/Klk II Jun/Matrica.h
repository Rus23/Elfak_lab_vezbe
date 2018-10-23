#pragma once
#include <iostream>
#include <string>
#include <fstream>
#include "Greska.h"
using namespace std;

template <class T,int n>
class Matrica
{
	T*** matr;
public:
	Matrica() { zauzmi(); }
	~Matrica() { obrisi(); }

	T* Find(T&);
	void Arrange();
	void Reverse();
	void Set(T&);
	void Clear(int, int);

	void WriteEle(char*);
	void ReadEle(char*);

	friend ostream& operator << <>(ostream& izlaz, Matrica<T,n>& nesto);

	void zauzmi();
	void obrisi();
};
template<class T,int n>
void Matrica<T, n>::ReadEle(char* ime_fajla)
{
	ifstream fajl;
	fajl.open(ime_fajla);
	if (fajl.good()) {
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < n; j++) {
				T* pom = new T;
				fajl >> *pom;
				this->matr[i][j] = pom;
			}
		}
	}
	else {throw LOSE_OTVARANJE;}
	fajl.close();
}

template<class T, int n>
void Matrica<T, n>::WriteEle(char* ime_fajla) 
{
	ofstream fajl(ime_fajla);
	try {
		if (fajl.good()) {
			for (int i = 0; i < n; i++) {
				for (int j = 0; j < n; j++) {
					fajl << this->matr[i][j];
				}
			}
		}
		else { throw "lose otvaranje fajla: "; } //LOSE_OTVARANJE; }
	}
	catch (char* msg)
	{
		cerr << msg << endl;
	}
	fajl.close();
}
template<class T, int n>
ostream& operator << <>(ostream& izlaz, Matrica<T,n>& nesto) 
{
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < n; j++) {
			T* pom= new T;
			pom = nesto.matr[i][j];
			izlaz << pom << " ";
		}
		cout << endl;
	}
	return izlaz;
}


template<class T, int n>
void Matrica<T,n>::Reverse()
{
	T* p;
	for (int i = 0; i < n; ++) {
		for (int j = 0; n / 2 > j; j++) {
			p = matr[n - (j + 1)][i];
			niz[n - (j + 1)][i] = niz[j][i];
			niz[j][i] = p;
		}
	}
}



template<class T, int n>
inline void Matrica<T, n>::Arrange()
{
	T* p;
	for (int j = 0; j < 0; j++) {
		for (int i = 0; i < n-1; i++)
		{
			for (int k = i+1; k < n; k++) {
				if (matr[j][i] < matr[j][k])
				{
					p = matr[j][i];
					matr[j][i] = matr[j][k];
					matr[j][k] = p;
				}
			}
		}
	}
}



template <class T, int n>
void Matrica<T, n>::obrisi()
{
	for (int i = 0; i < n; i++) {
		delete[] matr[i];
	}
	delete[] matr;
}


template <class T,int n>
void Matrica<T, n>::zauzmi()
{
	matr = new T**[n];
	for (int i = 0; i < n; i++) {
		matr[i] = new T*[n];
	}
}

