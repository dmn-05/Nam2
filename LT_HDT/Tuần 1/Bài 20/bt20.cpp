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
void xuathiennhieu(int a[], int n) {
	int tan_xuat_nhieu_nhat = 0;
	int b[100];
	for (int i = 0; i < n; i++)
	{
		int dem = 0;
		for (int j = i+1; j < n; j++)
		{
			if (a[i] == a[j])
			{
				dem++;
			}
		}
		b[i] = dem;
		if (tan_xuat_nhieu_nhat < dem)
		{
			tan_xuat_nhieu_nhat = dem;
		}
	}
	for (int i = 0; i < n; i++)
	{
		if (b[i] == tan_xuat_nhieu_nhat)
		{
			cout << a[i] << " ";
		}
	}
}
void main() {
	int a[100], n;
	nhap(a, n);
	xuathiennhieu(a, n);
}