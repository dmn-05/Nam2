#ifndef _PhanSo_
#define _PhanSo_

#include<iostream>
using namespace std;

class PhanSo {
private:
	int tu, mau;
public:
	friend istream& operator>>(istream& is, PhanSo& x);
	friend ostream& operator<<(ostream& os, PhanSo x);
	PhanSo operator+(PhanSo ps);
	PhanSo operator-(PhanSo ps);
	PhanSo operator*(PhanSo ps);
	PhanSo operator/(PhanSo ps);

	bool operator>(PhanSo ps);
	bool operator>=(PhanSo ps);
	bool operator<(PhanSo ps);
	bool operator<=(PhanSo ps);
	bool operator==(PhanSo ps);
	void RutGon();
};
#endif

