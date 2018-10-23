#include "Picture.h"

Picture::Picture()
{
	n = 0;
	a = 0;
}
Picture::Picture(int dm)
	:n(dm)
{
	a = new int*[n];
	for (int i = 0; n > i; i++)
		a[i] = new int[n];
}
Picture::~Picture()
{
	if (a != 0)
	{
		for (int i = 0; i < n; i++)
			delete[] a[i];
		delete[] a;

	}
}
Picture::Picture(const Picture &p)
{
	n = p.n;
	a = new int*[n];
	for (int i = 0; i<n; i++)
		a[i] = new int[n];
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
			a[i][j] = p.a[i][j];

	}
}

void Picture::Brightness()
{
	int s;
	cout << "Unesite vrednost koju zelite da dodate svim elemetima." << endl;
	cin >> s;
	for (int i = 0; i<n; i++)
		for (int j = 0; j < n; j++)
		{
			a[i][j] = s + a[i][j];
			if (a[i][j] < 0)
				a[i][j] = 0;
			if (a[i][j] > 512)
				a[i][j] = 512;
		}
}

Picture operator+=(Picture& U, int s1)
{
	cout << "Vrednost koja je dodata svim clanovima matrice: " << s1 << endl;
	for (int i = 0; i<U.n; i++)
		for (int j = 0; j < U.n; j++)
		{
			U.a[i][j] = s1 + U.a[i][j];
			if (U.a[i][j] < 0)
				U.a[i][j] = 0;
			if (U.a[i][j] > 512)
				U.a[i][j] = 512;
		}
	return U;
}


Picture& Picture::operator=(Picture& e)
{
	if (this != &e)
	{
		// Zasto? Da li ce da se prekopira, ako ne oslobodimo memoriju? 
		this->kopiraj(e);
	}
	return *this;
}
Picture& Picture:: operator+(const Picture& s)
{
	Picture* r = new Picture;
	r->zauzmi(n);
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			r->a[i][j] = (this->a[i][j] + s.a[i][j]) / 2;
		}
	}
	return *r;
}

istream& operator >> (istream &ulaz, Picture &v)
{
	for (int i = 0; i < v.n; i++)
		for (int j = 0; j < v.n; j++)
		{
			ulaz >> v.a[i][j];
			if (v.a[i][j] < 0)
				v.a[i][j] = 0;

			if (v.a[i][j] > 512)
				v.a[i][j] = 512;

		}
	return ulaz;
}
ostream& operator << (ostream &izlaz, const Picture &v)
{
	for (int i = 0; i < v.n; i++)
	{
		for (int j = 0; j < v.n; j++)
		{
			cout << v.a[i][j] << " ";
		}
		izlaz << endl;
	}
	return izlaz;
}


int Picture::vrednost(int x, int y)
{
	int i = x;
	int j = y;
	int g = a[i][j];
	return g;
}
void Picture::zauzmi(int dim)
{
	n = dim;
	a = new int*[n];
	for (int i = 0; i < n; i++)
		a[i] = new int[n];
}
void Picture::kopiraj(Picture z)
{
	zauzmi(z.n);
	for (int i = 0; i < z.n; i++)
	{
		for (int j = 0; j < z.n; j++)
			a[i][j] = z.a[i][j];
	}

}
void Picture::obrisi()
{
	for (int i = 0; i < n; i++)
	{
		delete[] a[i];
	}
	delete[] a;
}
