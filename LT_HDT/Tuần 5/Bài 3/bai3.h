#include<iostream>
using namespace std;
class SoPhuc
{
public:
	friend istream& operator>>(istream& is, SoPhuc& x);
	friend ostream& operator<<(ostream& os, SoPhuc x);
	~SoPhuc();
private:
	double a, b;
};


