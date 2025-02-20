#ifndef _HCNhat_
#define _HCNhat_
#include<iostream>
using namespace std;

class HCN
{
public:
	HCN();
	friend istream& operator >> (istream& is, HCN& x);
	friend ostream& operator << (ostream& os, HCN x);
	float dientich();
	float chuvi();
	~HCN();

protected:
	float dai, rong;
};
#endif // !_HCNhat_

