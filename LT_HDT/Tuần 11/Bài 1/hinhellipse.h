#ifndef _ELLIPSE_
#define _ELLIPSE_
#include<iostream>
#include"hinh.h"
using namespace std;

class ELLIPSE : public HINH
{
protected:
	double Ra, Rb;
public:
	ELLIPSE();
	ELLIPSE(double Ra, double Rb);
	~ELLIPSE();
	virtual void nhap();
	virtual double dienTich();
};
#endif // !_ELLIPSE_
