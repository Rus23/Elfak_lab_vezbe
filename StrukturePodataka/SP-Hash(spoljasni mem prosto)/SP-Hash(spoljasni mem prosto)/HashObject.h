#pragma once
#include <iostream>
#include <string>
using namespace std;

class HashObject
{
public:
	char* key;
	HashObject *next;
public:

	HashObject()
	{
		key = NULL;
		next = NULL;
	}

	HashObject(char* p)
	{
		key = new char[strlen(p) + 1];
		strcpy(key, p);
		next = NULL;
	}

	HashObject(char* p, HashObject* n)
	{
		key = new char[strlen(p) + 1];
		strcpy(key, p);
		next = n;
	}

	~HashObject()
	{
		if (key)
			delete key;
	}

	char* returnKey()
	{
		return key;
	}

	bool isEqual(char* p)
	{
		return strcmp(key, p) == 0;
	}
};
