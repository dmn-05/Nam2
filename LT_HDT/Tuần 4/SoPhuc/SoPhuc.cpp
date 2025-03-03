#include<iostream>
#include"SoPhuc.h"
#include<cmath>
using namespace std;

istream& operator>>(istream& is, SoPhuc& x) {
	cout << "Nhap Phan Thuc: ";
	is >> x.a;
	cout << "Nhap Phan Ao: ";
	is >> x.b;
	return is;
}
ostream& operator<<(ostream& os, SoPhuc x) {
	os << x.a << " + " << x.b << "i" << endl;
	return os;
}
SoPhuc SoPhuc::operator+(SoPhuc sp) {
	SoPhuc t;
	t.a = a + sp.a;
	t.b = b + sp.b;
	return t;
}
SoPhuc SoPhuc::operator-(SoPhuc sp) {
	SoPhuc h;
	h.a = a - sp.a;
	h.b = b - sp.b;
	return h;
}
SoPhuc SoPhuc::operator*(SoPhuc sp) {
	SoPhuc t;
	t.a = (a * sp.a) - (b * sp.b);
	t.b = (a * sp.b) + (b + sp.a);
	return t;
}
SoPhuc SoPhuc::operator/(SoPhuc sp) {
	SoPhuc t;
	t.a = ((a * sp.a) + (b * sp.b)) / pow(sp.a, 2) + pow(sp.b, 2);
	t.b = ((b * sp.a) - (a * sp.b)) / pow(sp.a, 2) + pow(sp.b, 2);
	return t;
}
bool SoPhuc::operator>(SoPhuc sp) {
	double dolonA = sqrt(pow(a, 2) + pow(b, 2));
	double dolonB = sqrt(pow(sp.a, 2) + pow(sp.b, 2));
	double kq = dolonA - dolonB;
	if (kq > 0) {
		return true;
	}
	return false;
}
bool SoPhuc::operator>=(SoPhuc sp) {
	double dolonA = sqrt(pow(a, 2) + pow(b, 2));
	double dolonB = sqrt(pow(sp.a, 2) + pow(sp.b, 2));
	double kq = dolonA - dolonB;
	if (kq >= 0) {
		return true;
	}
	return false;
}
bool SoPhuc::operator<(SoPhuc sp) {
	double dolonA = sqrt(pow(a, 2) + pow(b, 2));
	double dolonB = sqrt(pow(sp.a, 2) + pow(sp.b, 2));
	double kq = dolonA - dolonB;
	if (kq < 0) {
		return true;
	}
	return false;
}
bool SoPhuc::operator<=(SoPhuc sp) {
	double dolonA = sqrt(pow(a, 2) + pow(b, 2));
	double dolonB = sqrt(pow(sp.a, 2) + pow(sp.b, 2));
	double kq = dolonA - dolonB;
	if (kq <= 0) {
		return true;
	}
	return false;
}
bool SoPhuc::operator==(SoPhuc sp) {
	double dolonA = sqrt(pow(a, 2) + pow(b, 2));
	double dolonB = sqrt(pow(sp.a, 2) + pow(sp.b, 2));
	double kq = dolonA - dolonB;
	if (kq == 0) {
		return true;
	}
	return false;
}
