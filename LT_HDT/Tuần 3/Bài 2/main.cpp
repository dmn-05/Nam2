#include"DonThuc.h"
#include<iostream>
using namespace std;
void main() {
	DonThuc A, B;
	cout << "Nhap don thuc thu 1:\n";
	A.Nhap();
	cout << "Nhap don thuc thu 2:\n";
	B.Nhap();
	cout << "Don thuc thu 1 la: ";
	A.Xuat();
	cout << "Don thuc thu 2 la: ";
	B.Xuat();
	cout << "Tong hai don thuc la: ";
	(A.Tong(B)).Xuat();
	cout << "Hieu hai don thuc la: ";
	(A.Hieu(B)).Xuat();
	cout << "Giai don thuc thu 1 bang 0 ta duoc bien x: " << A.Fx();
	cout << endl;
	cout << "Giai don thuc thu 2 bang 0 ta duoc bien x: " << B.Fx();
	cout << endl;
}