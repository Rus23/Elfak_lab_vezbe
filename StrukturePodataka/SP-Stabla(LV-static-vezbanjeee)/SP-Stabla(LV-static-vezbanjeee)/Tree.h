#pragma once
#include <iostream>
using namespace std;

class Tree
{
	int size;
	int count;
	int* niz;
public:
	Tree() { size = 0; count = 0; niz = NULL; }
	Tree(int s) { size = s; count = 0; niz = new int[size];
	for (int i = 0; i < size; i++)
		niz[i] = NULL;
	}
	void insert(int in);



	void printTree()
	{
		for (int i = 0; i < size; i++)
			cout << "_" << niz[i];
		cout << endl;
	}
	int getCount() { return count; }
};
void Tree::insert(int in)
{
	int i = 0;
	while (i < size && niz[i] != 0)
	{
		if (niz[i] > in) {
			i = i * 2 + 1;
			if (niz[i] == 0) {
				niz[i] = in; // levi
				count++;
				return;
			}
		}
		else {
			i = i * 2 + 2;
			if (niz[i] == 0) {
				niz[i] = in; // desni
				count++;
				return;
			}
		}

	}
	if (i >= size) {
		cout << "Tree is FULL!!!" << endl;
		return;
	}
	niz[i] = in;
	count++;

}