#include<iostream>
#include"hinhvuong.h"
using namespace std;

HINHVUONG::HINHVUONG() {
	dai = rong = 0;
}
HINHVUONG::~HINHVUONG() {

}
void HINHVUONG::nhap() {
	double canh;
	cout << "Nhap hinh vuong:\n";
	cout << "Nhap canh: ";
	cin >> canh;
	dai = rong = canh;
}