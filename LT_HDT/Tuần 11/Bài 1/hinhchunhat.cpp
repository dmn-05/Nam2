#include<iostream>
#include"hinhchunhat.h"
using namespace std;



HINHCHUNHAT::HINHCHUNHAT() {
	dai = rong = 0;
}
HINHCHUNHAT::HINHCHUNHAT(double dai, double rong) {
	this->dai = dai;
	this->rong = rong;
}
HINHCHUNHAT::~HINHCHUNHAT() {

}
void HINHCHUNHAT::nhap() {
	cout << "Nhap hinh chu nhat:\n";
	cout << "Nhap chieu dai: ";
	cin >> dai;
	cout << "Nhap chieu rong: ";
	cin >> rong;
}
double HINHCHUNHAT::dienTich() {
	return dai * rong;
}