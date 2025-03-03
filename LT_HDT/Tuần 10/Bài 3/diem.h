#ifndef _diem_
#include<iostream>
using namespace std;

class Diem
{
public:
	Diem();
	friend istream& operator >> (istream& is, Diem& x);
	friend ostream& operator << (ostream& os, Diem x);
	float getX();
	float getY();
	void setX(float);
	void setY(float);
	float khoangcach();
	~Diem();

private:
	int x,y;
};
#endif // !_diem_


