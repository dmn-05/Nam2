#include<iostream>
#include"hinh.h"
#include"hinhchunhat.h"
#include"hinhvuong.h"
#include"hinhellipse.h"
#include"hinhtron.h"
using namespace std;

void main() {
	HINH* HCN = new HINHCHUNHAT;
	HINH* HV = new HINHVUONG;
	HINH* ELIP = new ELLIPSE;
	HINH* HT = new HINHTRON;

	HCN->nhap();
	cout << HCN->dienTich() << endl;
	HV->nhap();
	cout << HV->dienTich() << endl;
	ELIP->nhap();
	cout << ELIP->dienTich() << endl;
	HT->nhap();
	cout << HT->dienTich() << endl;
}