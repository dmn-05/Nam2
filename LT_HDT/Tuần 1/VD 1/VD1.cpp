#include<iostream>
using namespace std;
void nhap(int & n) {
	cout << "Nhap so N: ";
	cin >> n;
}
int tong(int n) {
	int tong = 0;
	for (int i = 1; i <= n; i++)
	{
		tong += i;
	}
	return tong;
}
void main() {
	int n;
	nhap(n);
	cout<<"tong cac so tu 1 den n: "<<tong(n);
}