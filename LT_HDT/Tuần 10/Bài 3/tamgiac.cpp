#include<iostream>
#include"tamgiac.h"
#include"diem.h"
#include<cmath>
using namespace std;

TamGiac::TamGiac() {
	arr[0].setX(0);
	arr[0].setY(0);
	arr[1].setX(0);
	arr[2].setY(0);
	arr[3].setX(0);
	arr[3].setY(0);
}
istream& operator >> (istream& is, TamGiac& x) {
	float a, b;
	for (int i = 0; i < 3; i++)
	{
		cout << "Diem thu " << i + 1 << ":\n";
		cout << "Nhap toa do x: ";
		is >> a;
		cout << "Nhap toa do y: ";
		is >> b;
		x.arr[i].setX(a);
		x.arr[i].setY(b);
	}
	return is;
}
ostream& operator << (ostream& os, TamGiac x) {
	for (int i = 0; i < 3; i++)
	{
		os << "Diem thu " << i + 1 << ":\n";
		os << "toa do x: " << x.arr->getX() << endl;
		os << "toa do y: " << x.arr->getY() << endl;
	}
	return os;
}
float TamGiac::dientich() {

}
float TamGiac::chuvi() {

}
float TamGiac::trongtam() {

}
TamGiac::~TamGiac() {

}