#include <iostream>
#include "Node.h"
#include "Tree.h"
using namespace std;

void main()
{
	Tree drvo;
	drvo.insert(7);
	drvo.insert(10);
	drvo.insert(11);
	drvo.insert(9);
	drvo.insert(3);
	drvo.insert(2);
	drvo.insert(4);
	cout << "Drvo(7.3.2.4.10.9.11)" << endl;
	drvo.preorder();
	drvo.insert(4);
	drvo.insert(4);
	drvo.insert(4);
	cout <<endl << "(7.3.2.4.4.10.9.11)(10)" << endl;
	drvo.preorder();
	int br = drvo.countDifferent();
	cout << endl << "Broj razlicitih: " << br << endl;

	system("Pause");

}