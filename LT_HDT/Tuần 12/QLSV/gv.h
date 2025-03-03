#ifndef _GV_
#define _GV_
#include<iostream>
#include<string>
#include"nguoi.h"
using namespace std;

class GV :public NGUOI
{
public:
	GV();
	~GV();
	void nhap();
	void xuat();
	/*friend istream& operator>>(istream& is, GV& gv);
	friend ostream& operator<<(ostream& os, GV gv);*/
	int sonamgd();
protected:
	int nambdgd;
	string chuyenmon;

};
#endif // !_GV_