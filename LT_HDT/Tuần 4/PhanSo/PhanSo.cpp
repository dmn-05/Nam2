#include<iostream>
#include"PhanSo.h"
#include<numeric>
using namespace std;

istream& operator>>(istream& is, PhanSo& x) {
	cout << "Nhap Tu: ";
	is >> x.tu;
	cout << "Nhap Mau: ";
	is >> x.mau;
	return is;
}
ostream& operator<<(ostream& os, PhanSo x) {
	os << x.tu << "/" << x.mau << endl;
	return os;
}
PhanSo PhanSo::operator+(PhanSo ps) {
	PhanSo t;
	t.tu = tu * ps.mau + ps.tu * mau;
	t.mau = mau * ps.mau;
	return t;
}
PhanSo PhanSo::operator-(PhanSo ps) {
	PhanSo h;
	h.tu = tu * ps.mau - ps.tu * mau;
	h.mau = mau * ps.mau;
	return h;
}
PhanSo PhanSo::operator*(PhanSo ps) {
	PhanSo t;
	t.tu = tu * ps.tu;
	t.mau = mau * ps.mau;
	return t;
}
PhanSo PhanSo::operator/(PhanSo ps) {
	PhanSo t;
	t.tu = tu * ps.mau;
	t.mau = ps.tu * mau;
	return t;
}
int gcd(int& a, int& b) {
	while(b != 0) {
		int temp = b;
		b = a % b;
		a = temp;
	}
	return a;
}
void PhanSo::RutGon() {
	int ucln = gcd(tu, mau);
	tu /= ucln;
	mau /= ucln;
}
bool PhanSo::operator>(PhanSo ps) {
	int kq = tu * ps.mau - ps.tu * mau;
	if (kq > 0) {
		return true;
	}
	return false;
}
bool PhanSo::operator>=(PhanSo ps) {
	int kq = tu * ps.mau - ps.tu * mau;
	if (kq >= 0) {
		return true;
	}
	return false;
}
bool PhanSo::operator<(PhanSo ps) {
	int kq = tu * ps.mau - ps.tu * mau;
	if (kq < 0) {
		return true;
	}
	return false;
}
bool PhanSo::operator<=(PhanSo ps) {
	int kq = tu * ps.mau - ps.tu * mau;
	if (kq <= 0) {
		return true;
	}
	return false;
}
bool PhanSo::operator==(PhanSo ps) {
	int kq = tu * ps.mau - ps.tu * mau;
	if (kq == 0) {
		return true;
	}
	return false;
}