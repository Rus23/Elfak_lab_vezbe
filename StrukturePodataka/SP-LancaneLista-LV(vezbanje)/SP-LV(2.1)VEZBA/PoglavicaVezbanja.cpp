#include <iostream>
using namespace std;
#include "CPolinomLL.h"
#include "CPolinomNodeLL.h"
#include "Polinom.h"

void main()
{

	CPolinomLL ll;
	ll.addToHead(2, 1);
	ll.addToHead(4, 2);
	//ll.addToHead(3, 3);
	//ll.addToTail(5, 0);
	ll.printAll();
	cout << "Brisanje elementa 2x^1." << endl;
	ll.deleteEl(3, 1);
	ll.printAll();

}