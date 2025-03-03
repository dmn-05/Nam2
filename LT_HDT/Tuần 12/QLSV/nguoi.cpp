#include<iostream>
#include<string>
#include"nguoi.h"
using namespace std;
NGUOI::NGUOI()
{
	hoten = gioitinh = noisinh = diachi = "";
	namsinh = 0;
}

NGUOI::~NGUOI()
{
}
void NGUOI::nhap() {
	cout << "Nhap ho ten: ";
	getline(cin, hoten);
	cout << "Nhap gioi tinh: ";
	getline(cin, gioitinh);
	cout << "Nhap nam sinh: ";
	cin >> namsinh;
	cin.ignore();
	cout << "Nhap noi sinh: ";
	getline(cin, noisinh);
	cout << "Nhap dia chi: ";
	getline(cin, diachi);
}
void NGUOI::xuat() {
	cout << "ho ten: " << hoten << endl;
	cout << "gioi tinh: " << gioitinh << endl;
	cout << "nam sinh: " << namsinh << endl;
	cout << "Nhap noi sinh: " << noisinh << endl;
	cout << "Nhap dia chi: " << diachi << endl;
}
//istream& operator>>(istream& is, NGUOI& nguoi) {
//	cout << "Nhap ho ten: ";
//	getline(is, nguoi.hoten);
//	cout << "Nhap gioi tinh: ";
//	getline(is, nguoi.gioitinh);
//	cout << "Nhap nam sinh: ";
//	is >> nguoi.namsinh;
//	is.ignore();
//	cout << "Nhap noi sinh: ";
//	getline(is, nguoi.noisinh);
//	cout << "Nhap dia chi: ";
//	getline(is, nguoi.diachi);
//}
//ostream& operator<<(ostream& os, NGUOI nguoi) {
//	os << "ho ten: " << nguoi.hoten << endl;
//	os << "gioi tinh: " << nguoi.gioitinh << endl;
//	os << "nam sinh: " << nguoi.namsinh << endl;
//	os << "Nhap noi sinh: " << nguoi.noisinh << endl;
//	os << "Nhap dia chi: " << nguoi.diachi << endl;
//}
int NGUOI::tuoi(){
	int tuoihientai;
	int namhientai;
	time_t t = time(nullptr);
	tm* now = localtime(&t);
	namhientai = now->tm_year + 1900;
	tuoihientai = namhientai - namsinh;
	return tuoihientai;
}




