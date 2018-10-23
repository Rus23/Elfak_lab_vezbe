#include "KompleksanBroj.h"
#include <math.h>

KompleksanBroj::KompleksanBroj(int c, int d)
{
	vrsta = "Kompleksan Broj";
	a = c;
	b = d;
}
KompleksanBroj::KompleksanBroj()
{
	a = 0;
	b = 0;
}

void KompleksanBroj::postVr()
{
	vrednost = sqrt(a*a + b*b);
}