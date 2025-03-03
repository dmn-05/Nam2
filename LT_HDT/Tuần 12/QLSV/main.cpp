#include<iostream>
#include<string>
#include"nguoi.h"
#include"gv.h"
#include"hs.h"
using namespace std;
void main() {
	NGUOI nguoi;
	//nguoi.nhap();
	//nguoi.xuat();
	///*cin >> nguoi;
	//cout << nguoi;*/
	//cout<<nguoi.tuoi();
	/*GV gv;
	gv.nhap();
	gv.xuat();
	cout << gv.tuoi();
	gv.sonamgd();*/
	HS hs;
	hs.nhap();
	hs.xuat();
	cout << hs.tuoi() << endl;
	cout << hs.diemtb() << endl;
	cout << hs.loaithanhtich();
}