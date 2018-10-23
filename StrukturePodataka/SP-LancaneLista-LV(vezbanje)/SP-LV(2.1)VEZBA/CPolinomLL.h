#pragma once
#include <iostream>
using namespace std;
#include "CPolinomNodeLL.h"
#include "Polinom.h"

class CPolinomLL
{
protected:
	CPolinomNodeLL *head, *tail;
public:
	CPolinomLL()
	{
		head = tail = NULL;
	}
	~CPolinomLL();
	bool isEmpty() { return head == NULL; }
	CPolinomNodeLL* getHead() { return head; }
	void addToHead(double kof, int ex);
	void addToTail(double kof, int ex);
	Polinom deleteFromHead(); // Zasto vraca POLINOM???
	Polinom deleteFromTail();
	CPolinomNodeLL* findNodePtr(double kof, int ex);
	CPolinomNodeLL* getNext(CPolinomNodeLL ptr);
	int getHeadEl();
	int getNextEl(double kof, int ex);
	bool isInList(double kof, int ex);
	void printAll();
	void deleteEl(double kof, int ex);
};
void CPolinomLL::deleteEl(double kof, int ex)
{
	if (isEmpty()) {
		cout << "Lista je prazna!" << endl;
		return;
	}
	Polinom el(kof, ex);
	if (head == tail && el == head->p) {
		delete head;
		head = tail = NULL;
	}
	else if (head->p == el) {
		CPolinomNodeLL* tmp = head;
		head = head->next;
		delete tmp;
	}
	else
	{
		CPolinomNodeLL *pre, *tmp;
		for (pre = head, tmp = head->next; tmp != NULL && !(el == tmp->p); pre = pre->next, tmp = tmp->next);
			if (tmp == NULL) {
				cout << "Nema takvog elementa!" << endl;
			}
			else {
				pre->next = tmp->next;
				if (tmp == tail)
					tail = pre;
				delete tmp;
			}
	}

}


Polinom CPolinomLL::deleteFromTail()
{
	if (isEmpty())
	{
		cout << "Lista je prazna!" << endl;
		Polinom i;
		return  i;
	}
	else
	{
		Polinom el = tail->p;
		CPolinomNodeLL* forDel = tail;
		if (tail == head)
		{
			tail = head = NULL;
		}
		else
		{
			for (CPolinomNodeLL* tmp, *pre = head; tmp != tail; pre = tmp, tmp = tmp->next)
			{
				tail = pre;
			}
			delete forDel;
			return el;
		}
	}
}
Polinom CPolinomLL::deleteFromHead()
{
	if (isEmpty()) {
		cout << "Lista je prazna!" << endl;
		Polinom i;
		return  i;
	}
	CPolinomNodeLL* tmp = head;
	Polinom el = head->p; //???
	if (tail == head)
	{
		head = tail = NULL;
	}
	else
	{
		head = head->next;
	}
	delete tmp;
	return el;
}

void CPolinomLL::addToTail(double kof, int ex)
{
	if (isEmpty()) {
		head = tail = new CPolinomNodeLL(kof, ex);
	}
	else {
		tail->next = new CPolinomNodeLL(kof, ex);
		tail = tail->next;
	}
	
}

CPolinomLL::~CPolinomLL()
{
	while (!isEmpty())
	{
		Polinom tmp = this->deleteFromHead();
	}
}

void CPolinomLL::printAll()
{
	for (CPolinomNodeLL* tmp = head; tmp != NULL; tmp = tmp->getNext()) {
		tmp->printNode();
	}
	cout << endl;
}

void CPolinomLL::addToHead(double kof, int ex)
{
	head = new CPolinomNodeLL(kof, ex, head);
	if (tail == NULL) { tail = head; }
}