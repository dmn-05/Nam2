#include<iostream>
#include"bai2.h"
using namespace std;

istream& operator>>(istream& is, DonThuc& x) {
	cout << "Nhap a: ";
	is >> x.a;
	cout << "Nhap b: ";
	is >> x.b;
	return is;
}
ostream& operator<<(ostream& os, DonThuc x) {
	os << x.a << "x + " << x.b << endl;
	return os;
}

DonThuc::~DonThuc() {
	cout << "da huy!\n";
}