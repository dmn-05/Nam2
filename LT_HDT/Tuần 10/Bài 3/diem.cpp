#include <iostream>
#include"diem.h"
#include"cmath"
using namespace std;

Diem::Diem()
{
	x = y = 0;
}
istream& operator >> (istream& is, Diem& x) {
	cout << "Nhap x: ";
	is >> x.x;
	cout << "Nhap y: ";
	is >> x.y;

	return is;
}
ostream& operator << (ostream& os, Diem x) {
	os << "toa do x: " << x.x << endl;
	os << "toa do y: " << x.y << endl;
	return os;
}
float Diem::getX() {
	return x;
}
float Diem::getY() {
	return y;
}
void Diem::setX(float a) {
	x = a;
}
void Diem::setY(float a) {
	y = a;
}
float Diem::khoangcach(Diem x) {
	return sqrt(pow(x.x - x, 2) + pow(y.x - y, 2));
}
Diem::~Diem()
{
}