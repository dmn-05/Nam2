#include<iostream>
using namespace std;
class DonThuc
{
public: 
	friend istream& operator>>(istream& is, DonThuc& x);
	friend ostream& operator<<(ostream& os, DonThuc x);
	~DonThuc();
	

private:
	double a, b;
};

