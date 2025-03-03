#include<iostream>
#include"bai3.h"
using namespace std;

istream& operator>>(istream& is, SoPhuc& x) {
	cout << "Nhap a: ";
	is >> x.a;
	cout << "Nhap b: ";
	is >> x.b;
	return is;
}
ostream& operator<<(ostream& os, SoPhuc x) {
	os << x.a << " + " << x.b << "i" << endl;
	return os;
}
SoPhuc::~SoPhuc() {
	cout << "da huy!\n";
}