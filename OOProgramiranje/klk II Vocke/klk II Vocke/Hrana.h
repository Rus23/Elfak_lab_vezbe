#pragma once
#include <iostream>
#include <fstream>
#include "Greska.h"

using namespace std;

class Hrana
{
protected:
	int A;
	int B;
	int x, y;

public:
	
	virtual bool operator <(int a) 
	{ if (A < a) 
	{ 
		return true;
	}
	return false; 
	}
	


};
