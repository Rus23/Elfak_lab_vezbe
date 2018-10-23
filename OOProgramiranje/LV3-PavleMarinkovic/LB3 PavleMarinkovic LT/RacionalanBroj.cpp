#include "RacionalanBroj.h"
#include <math.h> 

RacionalanBroj::RacionalanBroj()
{
	a = 0, b = 0;
}
RacionalanBroj::RacionalanBroj(int c, int d)
{
	vrsta = "Racionaln Broj";
	a = c;
	b = d;
}
void RacionalanBroj::postVr()
{
	this->vrednost = a / b;
}