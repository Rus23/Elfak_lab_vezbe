#pragma once
#include <iostream>
using namespace std;

class Picture
{
public:
	Picture();
	Picture(int dm);
	~Picture();
	Picture(const Picture& p);
	inline int dimenzijeM();

	void Brightness();
	friend Picture operator+=(Picture& U, int s1);

	int vrednost(int x, int y);

	void zauzmi(int dim);
	void kopiraj(Picture z);
	void obrisi();


	friend istream& operator >> (istream& ulaz, Picture& v);
	friend ostream& operator<<(ostream& izlaz, const Picture& v);

	Picture& operator+(const Picture& s);
	Picture& operator=(Picture& e);


private:
	int** a;
	int n;
};

int Picture::dimenzijeM()
{
	return n;
}