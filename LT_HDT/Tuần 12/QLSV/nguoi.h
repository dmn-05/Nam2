#ifndef _NGUOI_
#define _NGUOI_
#include<iostream>
#include<string>
using namespace std;

class NGUOI
{
public:
	NGUOI();
	~NGUOI();
	void nhap();
	void xuat();
	friend istream& operator>>(istream& is, NGUOI& nguoi);
	friend ostream& operator<<(ostream& os, NGUOI nguoi);
	int tuoi();
protected:
	string hoten, gioitinh, noisinh, diachi;
	int namsinh;
};
#endif // !_NGUOI_
