#include<iostream>
using namespace std;
void nhap(double a[], int n) {
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap phan tu a[" << i << "]: ";
		cin >> a[i];
	}
}
int search(double a[], int n) {
	int min = 0;
	for (int i = 1; i < n; i++)
	{
		if (a[min]<=0 && a[i]>0)
		{
			min = i;
		}
		else if (a[min] > a[i])
		{
			min = i;
		}
	}
	if (a[min] <= 0)
	{
		return -1;
	}
	return min;
}
void main() {
	double a[100];
	int n;
	cout << "Nhap so luong phan tu mang a: ";
	cin >> n;
	nhap(a, n);

	cout << "vi tri nho nhat trong mang la: "<< search(a, n);
}