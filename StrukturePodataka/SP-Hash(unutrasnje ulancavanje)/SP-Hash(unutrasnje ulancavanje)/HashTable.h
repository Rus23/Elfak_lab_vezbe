#pragma once
#include <iostream>
using namespace std;
#include "HashNode.h"

class HashTable
{
	HashNode* arr;
	int size;
	int count;

	unsigned int h(char* k)
	{
		unsigned int res = 0;
		unsigned int a = 7;
		for (int i = 0; k[i] != 0; i++)
			res = res << a^k[i];
		return res%size;
	}
	unsigned int g(unsigned int i)
	{
		return (i + 1) % size;
	}
public:
	HashTable(int l)	
	{
		size = l;
		count = 0;
		arr = new HashNode[size];
	}
	~HashTable() { if (arr) delete[] arr; }

	void insert(char* k)
	{
		if (size == count)
			throw "Uma za nenje ude za gnje!!!";
		long pom = h(k);
		if (!arr[pom].isFree())
		{
			while (arr[pom].next != -1)
				pom = arr[pom].next;
			long tmp = pom;
			pom = g(pom); //PAZIIIIIIIIII
			while (!arr[pom].isFree() && tmp != pom) //USLOOOOOV
				pom = g(pom);
			if (pom == tmp)
				throw "LOSAA SEKUNDARNA TRANSFORMACIJA!!!";
			arr[tmp].next = pom;
		}
		arr[pom].setEl(k, -1);
		count++;
	}




};