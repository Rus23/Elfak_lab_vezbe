#include "Broj.h"
#include "RacionalanBroj.h"
#include "KompleksanBroj.h"
#include <iostream> 
using namespace std;

void main()
{
	RacionalanBroj* R;
	 R =new RacionalanBroj(4,2);

	KompleksanBroj* K;
	K = new KompleksanBroj(2,8);

	K->postVr();
	K->print();

	R->postVr();
	R->print();
	
	if (R->vratiVr() > K->vratiVr())
	{
		cout << "Vecu vrednost ima:" << endl;
		R->print();
	}
	else
	{
		cout << "Vecu vrednost ima:" << endl;
		K->print();
	}


	cout << "Isto kao i gore samo sa klasom ''Broj'' " << endl  << endl;

	KompleksanBroj bk(2, 8);
	Broj* BK = &bk;

	bk.postVr();
	BK->print();

	RacionalanBroj br(4,2);
	Broj* BR = &br;

	br.postVr();
	BR->print();

	if (BK->operator>(BR))
	{
		cout << "Vecu vrednost ima: " << endl;
		BK->print();
	}
	else
	{
		cout << "Vecu vrednost ima: " << endl;
		BR->print();
	}

	int al;
	cin >> al;

}