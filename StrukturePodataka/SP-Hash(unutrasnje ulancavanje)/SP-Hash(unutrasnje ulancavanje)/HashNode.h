#pragma once
#include <iostream>
using namespace std;

class HashNode
{
public:
	char* key;
	int next;
	int status; //0(slobodan),1(obrisan),2(zazuzet)
public:
	HashNode() { key = NULL; next = -1; status = 0; }
	HashNode(char* k)
	{
		key = new char[strlen(k) + 1]; 
		strcpy(key, k);
		next = -1; status = 2; 
	}
	HashNode(char* k, int n) 
	{
		key = new char[strlen(k)+1]; 
		strcpy(key, k);
		next = n; status = 2; 
	}

	~HashNode() { 
		if (key)
			delete key;
		status = 1;
	}
	bool isEqual(char* a) { return strcmp(key, a) == 0;}
	bool isFree() { return status == 0 || status == 1; }

	void setEl(char* a, int n)
	{
		key = new char[strlen(a) + 1];
		strcpy(key, a);
		status = 2;
		next = n;
	}
	void printNode()
	{
		cout << key << " |Status: " << status << " |Next: " << next;
	}
		



};