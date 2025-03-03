#ifndef _SoPhuc_
#define _SoPhuc_

#include<iostream>
using namespace std;

class SoPhuc {
private:
	double a, b;
public:
	friend istream& operator>>(istream& is, SoPhuc& x);
	friend ostream& operator<<(ostream& os, SoPhuc x);
	SoPhuc operator+(SoPhuc sp);
	SoPhuc operator-(SoPhuc sp);
	SoPhuc operator*(SoPhuc sp);
	SoPhuc operator/(SoPhuc sp);

	bool operator>(SoPhuc sp);
	bool operator>=(SoPhuc sp);
	bool operator<(SoPhuc sp);
	bool operator<=(SoPhuc sp);
	bool operator==(SoPhuc sp);
};
#endif

