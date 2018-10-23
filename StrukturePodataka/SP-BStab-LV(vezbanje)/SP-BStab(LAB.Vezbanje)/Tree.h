#pragma once
#include <iostream>
using namespace std;
#include "Node.h"

class Tree
{
protected:
	Node *root;
	int count;
public:
	Tree() { root = NULL; count = 0; }
	~Tree() { deleteTree(root); }
	void deleteTree(Node*);
	bool isEmpty() { return root == NULL; }

	void insert(int in);

	void preorder() { preorder(root); }
	void preorder(Node*);

	int countDifferent();
	void countDifferent(Node*, int& num, int* niz,int& i);
	void countIn(Node*, int&, int*, int&);
};
int Tree::countDifferent()
{
	int size = count;
	int num = 0;
	int i = 0;
	int* niz = new int[size];
	countDifferent(root, num, niz, i);
	delete[] niz;
	return num;
}
void Tree::countDifferent(Node* n,int& num,int* niz, int& i)
{
	if (n != NULL)
	{
		countIn(n, num, niz, i);
		countDifferent(n->left, num, niz, i);
		countDifferent(n->right, num, niz, i);
	}
}
void Tree::countIn(Node* n, int& num, int* niz, int& i)
{
	niz[i] = n->info; 
	if (niz[i - 1] == niz[i])
		i++;
	else num++, i++;
}
void Tree::deleteTree(Node* n)
{

}
void Tree::preorder(Node* n)
{
	if (n != NULL) {
		n->printNode();
		preorder(n->left);
		preorder(n->right);
	}
}
void Tree::insert(int in)
{
	Node *p = root;
	while (p != NULL)
	{
		if (p->isLT(in)) {
			if (p->right == NULL) {
				p->right = new Node(in);
				count++;
				return;
			}
			p = p->right;
		}

		else {
			if (p->left == NULL) {
				p->left = new Node(in);
				count++;
				return;
			}
			p = p->left;
		}
	}
	root = new Node(in);
	count++;
	return;
}