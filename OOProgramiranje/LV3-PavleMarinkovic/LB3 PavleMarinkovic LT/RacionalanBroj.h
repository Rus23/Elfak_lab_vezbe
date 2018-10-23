#pragma once
#include "Broj.h"
#include <iostream>
using namespace std;

class RacionalanBroj : public Broj
{
	int a;
	int b;

public:
	RacionalanBroj();
	RacionalanBroj(int c, int d);

	virtual void postVr();

};
