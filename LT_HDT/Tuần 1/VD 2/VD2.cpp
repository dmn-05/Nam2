#include<iostream>
using namespace std;
void nhap(int a[], int n) {
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap phan tu a[" << i << "]: ";
		cin >> a[i];
	}
}
int search(int a[], int n) {
	int max = 0;
	for (int i =1; i < n; i++)
	{
		if (a[max] < a[i])
		{
			max = i;
		}
	}
	return a[max];
}
void main() {
	int a[100];
	int n;
	cout << "Nhap so luong phan tu mang a: ";
	cin >> n;
	nhap(a, n);
	cout<<"so lon nhat trong mang la: "<<search(a, n);
}