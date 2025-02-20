#include<iostream>
#include"bai1.h"
using namespace std;

istream& operator>>(istream& is, PhanSo& x) {
	cout << "Nhap Tu: ";
	is >> x.tu;
	cout << "Nhap Mau:";
	is >> x.mau;
	return is;
}
ostream& operator<<(ostream& os, PhanSo x) {
	os << x.tu << "/" << x.mau << endl;
	return os;
}

PhanSo::~PhanSo() {
	cout << "Phan so da duoc huy\n";
}