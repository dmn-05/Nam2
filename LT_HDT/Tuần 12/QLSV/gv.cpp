#include<iostream>
#include"gv.h"
#include<string>
using namespace std;

GV::GV() {
	chuyenmon = "";
	nambdgd = 0;
}
GV::~GV() {

}
void GV::nhap() {
	NGUOI::nhap();
	cout << "Nhap nam bat dau giang day: ";
	cin >> nambdgd;
	cin.ignore();
	cout << "Nhap chuyen mon: ";
	getline(cin, chuyenmon);
}
void GV::xuat() {
	NGUOI::xuat();
	cout << "nam bat dau giang day: " << nambdgd << endl;
	cout << "chuyen mon: " << chuyenmon << endl;
}
//istream& operator>>(istream& is, GV& gv) {
//	
//}
//ostream& operator<<(ostream& os, GV gv) {
//
//}
int GV::sonamgd() {
	int namgiangday;
	int namhientai;
	time_t t = time(nullptr);
	tm* now = localtime(&t);
	namhientai = now->tm_year + 1900;
	namgiangday = namhientai - nambdgd;
	return namgiangday;
}