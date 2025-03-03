#include<iostream>
#include"DonThuc.h"
using namespace std;


void DonThuc::Nhap() {
	cout << "Nhap so a: ";
	cin >> a;
	cout << "Nhap so b: ";
	cin >> b;
}
void DonThuc::Xuat() {
	if (b < 0)
	{
		cout << a << "x" << b << endl;
	}
	else
	{
		cout << a << "x+" << b << endl;
	}
}
DonThuc DonThuc::Tong(DonThuc B) {
	DonThuc Sum;
	Sum.a = a + B.a;
	Sum.b = b + B.b;
	return Sum;
}
DonThuc DonThuc::Hieu(DonThuc B) {
	DonThuc Sub;
	Sub.a = a - B.a;
	Sub.b = b - B.b;
	return Sub;
}
double DonThuc::Fx() {
	return -b / double(a);
}