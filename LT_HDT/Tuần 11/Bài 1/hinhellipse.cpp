#include<iostream>
#include"hinhellipse.h"
using namespace std;

ELLIPSE::ELLIPSE() {
	Ra = Rb = 0;
}
ELLIPSE::ELLIPSE(double Ra, double Rb) {
	this->Ra = Ra;
	this->Rb = Rb;
}
ELLIPSE::~ELLIPSE() {

}
void ELLIPSE::nhap() {
	cout << "Nhap ban kinh lon: ";
	cin >> Ra;
	cout << "Nhap ban kinh nho: ";
	cin >> Rb;
}
double ELLIPSE::dienTich() {
	return 3.14 * Ra * Rb;
}