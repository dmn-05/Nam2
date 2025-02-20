#include<iostream>
#include"blt.h"

using namespace std;

void MangSN::Nhap(){
	
	cout << "Nhap N: ";
	cin >> n;
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap a[" << i << "]: ";
		cin >> a[i];
	}
}
void MangSN::Xuat() {
	for (int i = 0; i < n; i++)
	{
		cout << "a[" << i << "]: " << a[i] << endl;
	}
}
void MangSN::lkesochan() {
	for (int i = 0; i < n; i++)
	{
		if (a[i] % 2 == 0)
		{
			cout << a[i] << " ";
		}
	}
	cout << "\n";
}
int MangSN::sum() {
	int tong = 0;
	for (int i = 0; i < n; i++)
	{
		tong += a[i];
	}
	return tong;
}
int timmax(int a[], int n) {
	int max = a[0];
	for (int i = 1; i < n; i++)
	{
		if (a[i] > max) {
			max = a[i];
		}
	}
	return max;
}
int MangSN::summax() {
	int max = timmax(a, n);
	int tong = 0;
	for (int i = 0; i < n; i++)
	{
		if (a[i] == max) {
			tong += a[i];
		}
	}
	return tong;
}
int MangSN::slsole() {
	int count = 0;
	for (int i = 0; i < n; i++)
	{
		if (a[i] % 2 != 0)
		{
			count++;
		}
	}
	return count;
}
int MangSN::demslx() {
	int x, count = 0;
	cout << "Nhap x: ";
	cin >> x;
	for (int i = 0; i < n; i++)
	{
		if (a[i]==x) {
			count++;
		}
	}
	return count;
}
bool MangSN::kiemtraso0() {
	for (int i = 0; i < n; i++)
	{
		if (a[i] == 0)
		{
			return true;
		}
	}
	return false;
}
bool MangSN::mangtoanchan() {
	for (int i = 0; i < n; i++)
	{
		if (a[i] % 2 != 0)
		{
			return false;
		}
	}
	return true;
}
void MangSN::interchangesort() {
	for (int i = 0; i < n - 1; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (a[j] < a[i])
			{
				swap(a[i], a[j]);
			}
		}
	}
}