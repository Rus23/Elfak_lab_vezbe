#pragma once
#include <iostream>
using namespace std;

class Node
{
public:
	Node *left, *right;
	int info;
public:
	Node() { left = right = NULL; }
	Node(int i) { info = i; left = right = NULL; }
	Node(int i, Node *l, Node *r) { info = i; left = l; right = r; }

	bool isEQ(int in) { return info == in; }
	bool isLT(int in) { return info < in; }

	void setKey(int i) { info = i; }
	int getKey() { return info; }

	void printNode()
	{
		cout << "_" << info;
	}
};