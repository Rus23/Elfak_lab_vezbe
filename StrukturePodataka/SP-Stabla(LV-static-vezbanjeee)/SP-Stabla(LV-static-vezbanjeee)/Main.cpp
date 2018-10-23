#include <iostream>
#include "Tree.h"
using namespace std;

void main()
{
	Tree drvo(7);
	drvo.insert(7);
	drvo.insert(9);
	drvo.insert(10);
	drvo.insert(8);
	drvo.insert(3);
	drvo.insert(2);

	cout << "Drvo:" << drvo.getCount()<< endl;
	drvo.printTree();


	system("Pause");
}