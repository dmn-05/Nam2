#include "PhanSo.h"
#include<iostream>
#include<cmath>

using namespace std;

void PhanSo::Nhap()
{
	cout << "Nhap tu so: ";
	cin >> tu;
	cout << "Nhap mau so: ";
	cin >> mau;
}
void PhanSo::Xuat()
{
	cout << tu << "/" << mau << endl;
}
int ucln(int a, int b) {
	while (b != 0) {
		int temp = b;
		b = a % b;
		a = temp;
	}
	return a;
}
void PhanSo::RutGon() {
	int uoccln = ucln(tu, mau);
	tu /= uoccln;
	mau /= uoccln;
}
PhanSo PhanSo::Tong(PhanSo b) {
	PhanSo Sum;
	Sum.tu = tu * b.mau + mau * b.tu;
	Sum.mau = mau * b.mau;
	Sum.RutGon();
	return Sum;
}
PhanSo PhanSo::Hieu(PhanSo b) {
	PhanSo Sub;
	Sub.tu = tu * b.mau - mau * b.tu;
	Sub.mau = mau * b.mau;
	if (Sub.tu < 0)
	{
		Sub.tu = abs(Sub.tu);
		Sub.RutGon();
		Sub.tu *= (-1);
	}
	else
	{
		Sub.RutGon();
	}
	return Sub;
}
PhanSo PhanSo::Tich(PhanSo b) {
	PhanSo Time;
	Time.tu = tu * b.tu;
	Time.mau = mau * b.mau;
	Time.RutGon();
	return Time;
}
PhanSo PhanSo::Thuong(PhanSo b) {
	PhanSo Division;
	Division.tu = tu * b.mau;
	Division.mau = mau * b.tu;
	Division.RutGon();
	return Division;
}
void PhanSo::SoSanh(PhanSo b) {
	PhanSo ps = Hieu(b);
	if (ps.tu > 0) {
		cout << "Phan so thu 1 lon hon\n";
	}
	else if (ps.tu < 0)
	{
		cout << "Phan so thu 2 lon hon\n";
	}
	else
	{
		cout << "Hai phan so bang nhau";
	}
}