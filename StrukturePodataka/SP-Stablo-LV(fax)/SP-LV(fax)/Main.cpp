#include <iostream>
#include "Tree.h"
#include "Node.h"
using namespace std;

void main()
{
	Tree drvo;

	drvo.insert(7);
	drvo.insert(11);
	drvo.insert(9);
	drvo.insert(12);
	drvo.insert(3);
	drvo.insert(5);
	drvo.insert(2);
	drvo.insert(1);
	cout << "drvo:" << endl;
	drvo.printAll();
	int br=drvo.atLevel(drvo.getRoot(), 3, 0);
	cout <<endl<< "U "<<3 <<". redu " << "ima " << br << " cvora"<<endl;

	system("Pause");

}