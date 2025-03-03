#include<iostream>
#include"ellipse.h"
#include<cmath>
using namespace std;

Ellipse::Ellipse() {
	dklon = dknho = 0;
}
istream& operator >> (istream& is, Ellipse& x) {
	cout << "Nhap duong kinh lon: ";
	is >> x.dklon;
	cout << "Nhap duong kinh nho: ";
	is >> x.dknho;
	return is;
}
ostream& operator << (ostream& os, Ellipse x) {
	os << "Ban kinh lon: " << x.dklon << endl;
	os << "Ban kinh nho: " << x.dknho << endl;
	return os;
}
float Ellipse::dientich() {
	return p * dklon * dknho;
}
float Ellipse::chuvi() {
	return p * (3 * (dklon + dknho) - sqrt((3 * dklon + dknho)*(dklon + 3 * dknho)));
}
Ellipse::~Ellipse() {
	
}