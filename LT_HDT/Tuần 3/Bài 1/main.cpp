#include "PhanSo.h"
#include<iostream>
using namespace std;

void main() {
	PhanSo A, B;
	cout << "Nhap phan so thu 1:\n";
	A.Nhap();
	cout << "Nhap phan so thu 2:\n";
	B.Nhap();
	cout << "Phan so thu 1: ";
	A.Xuat();
	cout << "Phan so thu 2: ";
	B.Xuat();
	cout << "Tong hai phan so:\n";
	A.Tong(B).Xuat();
	cout << "Hieu hai phan so:\n";
	A.Hieu(B).Xuat();
	cout << "Tich hai phan so:\n";
	A.Tich(B).Xuat();
	cout << "Thuong hai phan so:\n";
	A.Thuong(B).Xuat();
	cout << "So sanh hai phan so:\n";
	A.SoSanh(B);
}