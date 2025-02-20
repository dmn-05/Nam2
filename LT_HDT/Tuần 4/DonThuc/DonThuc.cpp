#include<iostream>
#include"DonThuc.h"
using namespace std;

istream& operator>>(istream& is, DonThuc& x) {
	cout << "Nhap a : ";
	is >> x.a;
	cout << "Nhap b: ";
	is >> x.b;
	return is;
}
ostream& operator<<(ostream& os, DonThuc x) {
	os << x.a << "x + " << x.b << endl;
	return os;
}
DonThuc DonThuc::operator+(DonThuc dt) {
	DonThuc t;
	t.a = a + dt.a;
	t.b = b + dt.b;
	return t;
}
DonThuc DonThuc::operator-(DonThuc dt) {
	DonThuc h;
	h.a = a - dt.a;
	h.b = b - dt.b;
	return h;
}


