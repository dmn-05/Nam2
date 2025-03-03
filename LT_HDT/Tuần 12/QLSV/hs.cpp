#include<iostream>
#include"hs.h"
#include<string>
using namespace std;

HS::HS() {
	toan = anh = van = 0;
}
HS::~HS() {

}
void HS::nhap() {
	NGUOI::nhap();
	cout << "Nhap diem toan: ";
	cin >> toan;
	cout << "Nhap diem anh: ";
	cin >> anh;
	cout << "Nhap diem van: ";
	cin >> van;
}
void HS::xuat() {
	NGUOI::xuat();
	cout << "diem toan: " << toan << endl;
	cout << "diem anh: " << anh << endl;
	cout << "diem van: " << van << endl;
}
double HS::diemtb() {
	return (toan * 2 + van * 2 + anh) / 5;
}
string HS::loaithanhtich() {
	double diemtb = this->diemtb();
	if (diemtb >= 8 && toan >= 6.5 && anh >= 6.5 && van >= 6.5)
	{
		return "Gioi";
	}
	else if (diemtb >= 6.5 && toan >= 5 && anh >= 5 && van >= 5)
	{
		return "Kha";
	}
	else if (diemtb >= 5 && toan >= 3 && anh >= 3 && van >= 3)
	{
		return "Trung Binh";
	}
	else
	{
		return "Kem";
	}
}