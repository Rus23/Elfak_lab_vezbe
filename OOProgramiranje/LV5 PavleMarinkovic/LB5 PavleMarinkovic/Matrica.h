#pragma once
#include <iostream>
using namespace std;

template <class T>
class Matrica
{
	T** mat;
	int n;
	int m;
public:
	Matrica();     
	Matrica(int a, int b);

	~Matrica();

	T GetElement(int x, int y);
	void SetElement(int x, int y, T newValue);

	int GetX();
	int GetY();

	void operator=(Matrica& matr);
	Matrica operator*(Matrica& ma); 
	friend ostream& operator << <>(ostream& izlaz, Matrica<T>& matrix);

	void obrisi();
	void zauzmi(int dim1, int dim2);

};

template <class T>
Matrica<T> ::Matrica()
	{
		zauzmi(12, 12);
}

template <class T>
Matrica<T>:: Matrica(int a, int b) : n(a), m(b) // Konstruktor
{
	zauzmi(n, m);
}

template <class T>
Matrica<T>:: ~Matrica() // Destruktor
{
	if (n != 0 && m != 0)
	{
		obrisi();
	}
}

template<class T>
T Matrica<T> :: GetElement(int x, int y) // Uzmi element
{
	return mat[x][y];
}
template<class T>
void Matrica<T> :: SetElement(int x, int y, T newValue) // Postavi element
{
	this->mat[x][y] = newValue;
}

template <class T>
int Matrica<T> :: GetX() // Uzmi velicinu n 
{
	return this->n;
}
template <class T>
int Matrica<T> :: GetY() // Uzmi velicinu m
{
	return this->m;
}

template <class T>
Matrica<T> Matrica<T>::operator*(Matrica& ma) 
{
	if (this->n == ma.m && this->m == ma.n) {
		Matrica<T>* mul = new Matrica<T>(ma.n, this->m);
		for (int i = 0; i < ma.n; i++) {
			for (int j = 0; j < this->m; j++)
			{
				T null=0;
				mul->mat[j][i] = null;          //                     T s;
				for (int k = 0; k < this->n; k++)
				{
					mul->mat[j][i] = mul->mat[j][i] + this->mat[k][i] * ma.mat[j][k];
				}
				                  // Zasto ovde s ne postoji?          mul->mat[i][j] = s;
			}
		}
		return *mul;
	}
	else
	{
		cout << "          ***** GRESKA *****" << endl
			<< "  Nije moguce mnoziti ovde 2 matrice!"<< endl 
			<< "      -Velicine se ne poklapaju-" << endl;

		Matrica<T>* nul = new Matrica<T>();
		return *nul;
	}
}

template <class T>
void Matrica<T> :: operator=(Matrica& matr)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			this->mat[i][j] = matr.mat[i][j];
		}
	}
}

template<class T>
ostream & operator << <>(ostream & izlaz, Matrica<T>& matrix)
{
	{
		for (int i = 0; i < matrix.GetX(); i++)
		{
			for (int j = 0; j < matrix.GetY(); j++)
			{
				cout << matrix.GetElement(i, j) << " ";
			}
			izlaz << endl;
		}
		return izlaz;
	}
}

template <class T>
void Matrica<T>:: obrisi()
{
	for (int i = 0; i < n; i++)
		delete[] mat[i];
	delete[] mat;
}

template <class T>
void Matrica<T>::zauzmi(int dim1, int dim2)
{
	mat = new T*[dim1];
	for (int i = 0; i < dim1; i++)
		mat[i] = new T[dim2];
}
