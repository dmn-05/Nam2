#ifndef _ellipse_
#define _ellipse_
#include<iostream>
using namespace std;

class Ellipse
{
public:
	Ellipse();
	friend istream& operator >> (istream& is, Ellipse& x);
	friend ostream& operator << (ostream& os, Ellipse x);
	float dientich();
	float chuvi();
	~Ellipse();

protected:
	float p = 3.14, dklon, dknho;
};
#endif // !_ellipse_

