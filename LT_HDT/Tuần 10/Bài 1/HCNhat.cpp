#include<iostream>
#include"HCNhat.h"
using namespace std;

HCN::HCN()
{
	dai = rong = 0;
}
istream& operator >> (istream& is, HCN& x) {
	cout << "Nhap chieu dai: ";
	is >> x.dai;
	cout << "Nhap chieu rong: ";
	is >> x.rong;
	return is;
}
ostream& operator << (ostream& os, HCN x) {
	os << "Chieu dai: " << x.dai << endl;
	os << "Chieu rong: " << x.rong << endl;
	return os;
}
float HCN::dientich() {
	return dai * rong;
}
float HCN::chuvi() {
	return (dai + rong) * 2;
}
HCN::~HCN()
{
}