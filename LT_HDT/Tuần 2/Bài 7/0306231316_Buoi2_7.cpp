#include<iostream>
using namespace std;

struct PhanSo {
	int tu, mau;
};

void input(PhanSo& ps) {
	cout << "Nhap Tu: ";
	cin >> ps.tu;
	cout << "Nhap mau: ";
	cin >> ps.mau;
}

void output(PhanSo ps) {
	cout << ps.tu << "/" << ps.mau << endl;
}

int ucln(int a, int b) {
	while (b != 0)
	{
		int temp = b;
		b = a % b;
		a = temp;
	}
	return a;
}

void rutgon(int& tu, int& mau) {
	int uoc = ucln(tu, mau);
	tu /= uoc;
	mau /= uoc;
}

PhanSo hieu(PhanSo ps1, PhanSo ps2) {
	PhanSo hieu;
	if (ps1.mau == ps2.mau)
	{
		hieu.tu = ps1.tu - ps2.tu;
		hieu.mau = ps1.mau;
	}
	else
	{
		hieu.tu = (ps1.tu * ps2.mau) - (ps1.mau * ps2.tu);
		hieu.mau = ps1.mau * ps2.mau;
	}
	rutgon(hieu.tu, hieu.mau);
	return hieu;
}
PhanSo tich(PhanSo ps1, PhanSo ps2) {
	PhanSo tich;
	tich.tu = ps1.tu * ps2.tu;
	tich.mau = ps1.mau * ps2.mau;
	rutgon(tich.tu, tich.mau);
	return tich;
}
PhanSo thuong(PhanSo ps1, PhanSo ps2) {
	PhanSo thuong;
	thuong.tu = ps1.tu * ps2.mau;
	thuong.mau = ps1.mau * ps2.tu;
	rutgon(thuong.tu, thuong.mau);
	return thuong;
}
void sosanh(PhanSo ps1, PhanSo ps2) {
	double pso1 = ps1.tu / double(ps1.mau);
	double pso2 = ps2.tu / double(ps2.mau);
	if (pso1 > pso2)
	{
		cout << "Phan so thu 1 lon hon\n";
	}
	else if (pso1 < pso2)
	{
		cout << "Phan so thu hai lon hon\n";
	}
	else
	{
		cout << "Hai phan so bang nhau";
	}
}
void main() {
	PhanSo ps1, ps2;
	cout << "Nhap Phan so thu 1:\n";
	input(ps1);
	cout << "Nhap Phan so thu 2:\n";
	input(ps2);
	cout << "Phan so thu 1: ";
	output(ps1);
	cout << "Phan so thu 2: ";
	output(ps2);
	cout << "Hieu hai phan so: ";
	output(hieu(ps1, ps2));
	cout << "Tich hai phan so: ";
	output(tich(ps1, ps2));
	cout << "Thuong hai phan so: ";
	output(thuong(ps1, ps2));
	cout << "so sanh hai phan so : \n";
	sosanh(ps1, ps2);
}