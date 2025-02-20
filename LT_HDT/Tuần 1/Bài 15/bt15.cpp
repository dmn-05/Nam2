#include<iostream>
using namespace std;

void nhap(int a[], int& n) {
	cout << "Nhap so luong phan tu: ";
	cin >> n;
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap phan tu a[" << i << "]: ";
		cin >> a[i];
	}
}
bool snt(int a) {
	if (a < 2)
	{
		return 0;
	}
	for (int i = 2; i < a; i++)
	{
		if (a % i == 0)
		{
			return 0;
		}
	}
	return 1;
}
void xuat(int a[], int n) {
	int tong = 0;
	for (int i = 0; i < n; i++)
	{
		if (snt(a[i]))
		{
			tong += a[i];
		}
	}
	cout << "tong: " << tong;
}
void main() {
	int a[100], n;
	nhap(a, n);
	xuat(a, n);
}