#include<iostream>
using namespace std;

void nhap(double a[], int& n) {
	cout << "Nhap so luong phan tu: ";
	cin >> n;
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap phan tu a[" << i << "]: ";
		cin >> a[i];
	}
}
void interchangesort(double a[], int n) {
	for (int i = 0; i < n - 1; i++)
	{
		for (int j = i+1; j < n; j++)
		{
			if (a[i] > a[j])
			{
				swap(a[i], a[j]);
			}
		}
	}
}
void xuat(double a[], int n) {
	for (int i = 0; i < n; i++)
	{
		cout << "a[" << i << "]= " << a[i] << endl;
	}
}
void main() {
	double a[100];
	int n;
	nhap(a, n);
	cout << "Chua sap xep tang dan\n";
	xuat(a, n);
	interchangesort(a, n);
	cout << "Da sap xep tang dan\n";
	xuat(a, n);
}