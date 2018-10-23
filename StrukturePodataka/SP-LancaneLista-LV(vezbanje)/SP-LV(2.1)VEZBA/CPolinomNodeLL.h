#pragma once
#include <iostream>
using namespace std;
#include "Polinom.h"

class CPolinomNodeLL
{
public:
	Polinom p;
	CPolinomNodeLL* next;
public:
	CPolinomNodeLL() {next = NULL;}
	CPolinomNodeLL(double kof, int ex)
	{
		p.setPol(kof, ex);
		next = NULL;
	}
	CPolinomNodeLL(double kof, int ex, CPolinomNodeLL* n)
	{
		p.setPol(kof, ex);
		next = n;
	}
	~CPolinomNodeLL(){}
	void printNode()
	{
		cout << p;
	}
	CPolinomNodeLL* getNext() { return this->next; }
	bool isEqual(double a, int b)
	{
		return p.getKof() == a && p.getEx() == b;
	}
};