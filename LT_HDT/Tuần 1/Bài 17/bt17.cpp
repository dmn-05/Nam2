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
void xuat(int a[], int n) {
	int tong = 0, dem = 0;
	for (int i = 0; i < n; i++)
	{
		if (a[i] > 0)
		{
			tong += a[i];
			dem++;
		}
	}
	cout << "trung binh cong: " << tong / double(dem);
}
void main() {
	int a[100], n;
	nhap(a, n);
	xuat(a, n);
}