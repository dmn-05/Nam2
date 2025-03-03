#include<iostream>
using namespace std;

class PhanSo
{
public:
	friend istream& operator>>(istream& is, PhanSo& x);
	friend ostream& operator<<(ostream& os, PhanSo x);
	~PhanSo();

private:
	int tu, mau;
};

