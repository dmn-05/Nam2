#include<iostream>
#include"blt.h"
using namespace std;

void main() {
	MangSN a;
	a.Nhap();
	a.Xuat();
	cout << "Cac so chan trong mang la: ";
	a.lkesochan();
	cout << " tong gia tri trong mang la: " << a.sum() << endl;
	cout << "tong cac gia tri cuc dai trong mang la: " << a.summax() << endl;
	cout << "So luong so le trong mang la:" << a.slsole() << endl;
	cout << "So luong gia tri x trong mang la: " << a.demslx() << endl;
	cout << "Mang co so 0: ";
	if (a.kiemtraso0()) {
		cout << "YES\n";
	}
	else
	{
		cout << "NO\n";
	}
	cout << "Mang toan chan: ";
	if (a.mangtoanchan()) {
		cout << "YES\n";
	}
	else
	{
		cout << "NO\n";
	}
	a.interchangesort();
	a.Xuat();
}
