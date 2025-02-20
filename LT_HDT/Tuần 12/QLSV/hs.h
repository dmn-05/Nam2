#ifndef _HS_
#define _HS_
#include<iostream>
#include<string>
#include"nguoi.h"
using namespace std;

class HS :public NGUOI
{
public:
	HS();
	~HS();
	void nhap();
	void xuat();
	double diemtb();
	string loaithanhtich();
protected:
	double toan, van, anh;
};
#endif // !_HS_