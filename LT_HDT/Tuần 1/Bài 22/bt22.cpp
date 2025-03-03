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
	for (int i = 0; i < n - 1; i++)
	{
		if (a[i] != a[i + 1])
		{
			cout << "Gia tri trong mang khong bang nhau\n";
			exit(1);
		}
	}
	cout << "Gia tri trong mang bang nhau\n";
}
void main() {
	int a[100], n;
	nhap(a, n);
	xuat(a, n);
}