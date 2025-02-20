#include<iostream>
#include"HCNhat.h"
#include"HVuong.h"
using namespace std;

void main() {
	HCN hcn;
	HV hv;
	cin >> hcn;
	hv.nhap();
	cout << hcn;
	cout << hv;
	cout << "chu vi hinh chu nhat: " << hcn.chuvi() << endl;
	cout << "chu vi hinh vuong: " << hv.chuvi() << endl;
	cout << "dien tich hinh chu nhat: " << hcn.dientich() << endl;
	cout << "dien tich hinh vuong : " << hv.dientich() << endl;
}
