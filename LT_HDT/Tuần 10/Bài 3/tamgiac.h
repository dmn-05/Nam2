#ifndef _tamgiac_
#define _tamgiac_
#include<iostream>
#include"diem.h"
class TamGiac
{
public:
	TamGiac();
	friend istream& operator >> (istream& is, TamGiac& x);
	friend ostream& operator << (ostream& os, TamGiac x);
	float dientich();
	float chuvi();
	float trongtam();
	~TamGiac();
private:
	Diem arr[3];
};

#endif // !_tamgiac_

