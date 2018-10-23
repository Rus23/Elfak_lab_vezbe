#pragma once
#include "Node.h"
#include <iostream>
using namespace std;

class Tree
{
private:
	Node* root;
	int count;
public:
	Tree() { root = NULL; count = NULL; }
	~Tree() { deleteTree(root); }
	void deleteTree(Node*) {}
	Node* getRoot() { return root; }
	bool isEmpty() { return root == NULL; }
	void insert(int);

	void printAll() {
		printAll(root);
	}
	void printAll(Node* n) {
		if (n != NULL) {
			n->printNode();
			printAll(n->left);
			printAll(n->right);
		}
	}

	int atLevel(Node* p, int level, int);
	int howMuch(int nivo, int level) {
		int br = 0;
		atLevel(root, level, 0);
		return br;
	}

};
int Tree::atLevel(Node *n, int level, int lv)
{
	if(n != NULL)
	{
		if (level == lv & n!=NULL ) {
			return 1;
		}
		else {
			lv++;
			return (atLevel(n->left, level, lv) + atLevel(n->right, level, lv));
		}
	}
	return 0;
}

void Tree::insert(int el)
{
		Node *p = root;
		while (p != NULL)
		{
			if (p->isLT(el)) {
				if (p->right == NULL) {
					p->right = new Node(el);
					count++;
					return;
				}
				p = p->right;
			}

			else {
				if (p->left == NULL) {
					p->left = new Node(el);
					count++;
					return;
				}
				p = p->left;
			}
		}
		root = new Node(el);
		count++;
		return;
}
