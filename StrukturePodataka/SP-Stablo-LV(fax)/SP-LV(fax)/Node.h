#pragma once
#include <iostream>
using namespace std;

class Node
{
public:
	int key;
	Node* left, *right;
public:
	Node() { left = right = NULL; key = NULL; }
	Node(int k) { left = right = NULL; key = k; }
	Node(int k, Node* l, Node* r) { left = l, right = r, key = k; }

	void printNode();

	bool isLT(int el) { return key < el; }
	bool isGT(int el) { return key > el; }
	bool isEQ(int el) { return key == el; }
};
void Node::printNode()
{
	cout << "_" << key;
}
