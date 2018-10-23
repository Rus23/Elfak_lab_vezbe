#pragma once
#include "Broj.h"
#include <iostream>
using namespace std;

class KompleksanBroj : public Broj
{
	int a;
	int b;

public:

	KompleksanBroj();
	KompleksanBroj(int c, int d);

	void postVr();

};