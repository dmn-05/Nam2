#include<iostream>
using namespace std;
void nhap(int a[], int& n) {
	cout << "Nhap so luong phan tu trong mang: ";
	cin >> n;
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap a[" << i << "]: ";
		cin >> a[i];
	}
}
int search_min_le(int a[], int n) {
	int min = 0;
	for (int i = 1; i < n; i++)
	{
		if (a[min] % 2 == 0 && a[i] % 2 != 0)
		{
			min = i;
		}
		else if (a[min] > a[i] && a[i] % 2 != 0)
		{
			min = i;
		}
	}
	if (a[min]%2==0)
	{
		return -1;
	}
	return min;
}
int search_max_chan(int a[], int n) {
	int max = 0;
	int min_le = search_min_le(a, n);
	for (int i = 1; i < n; i++)
	{
		if (a[max] % 2 != 0 && a[i] % 2 == 0)
		{
			max = i;
		}
		else if (a[max] < a[i] && a[i] % 2 == 0 && a[i] < a[min_le])
		{
			max = i;
		}
	}
	if (a[max] % 2 != 0 || a[max] > a[min_le])
	{
		return -1;
	}
	return max;
}
void main() {
	int a[100], n;
	nhap(a, n);
	cout << "vi tri chan lon nhat va nho hon le nho nhat la: " << search_max_chan(a, n);
}