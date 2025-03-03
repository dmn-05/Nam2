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
void itxuathien(int a[], int n) {
	int tan_xuat_it_nhat = n;
	int so_it_xh_nhat;
	for (int i = 0; i < n; i++)
	{
		int dem = 0;
		for (int j = 0; j < n; j++)
		{
			if (a[i] == a[j])
			{
				dem++;
			}
		}
		if (tan_xuat_it_nhat > dem)
		{
			tan_xuat_it_nhat = dem;
			so_it_xh_nhat = a[i];
		} 
	}
	cout << "so it xuat hien trong mang nhat la: " << so_it_xh_nhat;
}
void main() {
	int a[100], n;
	nhap(a, n);
	itxuathien(a, n);
}