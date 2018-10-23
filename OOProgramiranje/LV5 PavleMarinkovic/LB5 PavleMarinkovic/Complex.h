#pragma once
#include <iostream>
using namespace std;

class Complex
{
	double re;
	double im;
public:
	Complex()
	{
		re, im = 0;
	}
	Complex(double rea, double ima) : re(rea), im(ima) {}
	Complex(double nula) : re(nula), im(nula) {}
	~Complex() {}

	Complex operator +(Complex& a)
	{
		Complex* kom = new Complex;
		kom->re = a.re + this->re;
		kom->im = a.im + this->im;
		return *kom;
	}

	Complex& operator *(Complex& a)
	{
		Complex* kom1 = new Complex;
		kom1->re = a.re * this->re;
		kom1->im = a.im * this->im;
		return *kom1;
	}
	Complex& operator =(Complex& a)
	{
		this->im = a.im;
		this->re = a.re;
		return *this;
	}

	friend ostream& operator <<(ostream& izlaz, Complex& a)
	{
		izlaz << "Z= " << a.re << "+ i" << a.im;
		return izlaz;
	}
	friend istream& operator >> (istream& ulaz, Complex& a)
	{
		cout << "Unesite Re i Im deo" << endl;
	    ulaz >> a.re >> a.im;
		return ulaz;
	}



};
