#ifndef _DonThuc_
#define _DonThuc_

#include<iostream>
using namespace std;

class DonThuc {
private:
	int a,b;
public:
	friend istream& operator>>(istream& is, DonThuc& x);
	friend ostream& operator<<(ostream& os, DonThuc x);
	DonThuc operator+(DonThuc dt);
	DonThuc operator-(DonThuc dt);
};
#endif
