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
void giatripbiet(int a[], int n) {
	int dem = 0;
	for (int i = 0; i < n; i++)
	{
		bool gtripbiet = false;
		for (int j = 0; j < i; j++)
		{
			if (a[i] == a[j])
			{
				gtripbiet = true;
			}
		}
		if (!gtripbiet)
		{
			dem++;
		}
	}
	cout << "so gia tri phan biet trong mang la: " << dem;
}
void main() {
	int a[100], n;
	nhap(a, n);
	giatripbiet(a, n);
}