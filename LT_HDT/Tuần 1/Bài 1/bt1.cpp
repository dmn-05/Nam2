#include<iostream>
using namespace std;
void nhap(int & a, int & b, int & c) {
	cout << "Nhap a: ";
	cin >> a;
	cout << "Nhap b: ";
	cin >> b;
	cout << "Nhap c: ";
	cin >> c;
}
int search(int a, int b, int c) {
	int min = 0;
	if (a <= b && a <= c)
	{
		return a;
	}
	else if (a >= b && b <= c)
	{
		return b;
	}
	else
	{
		return c;
	}
}
void main() {
	int a, b, c;
	nhap(a, b, c);
	cout << "so nho nhat la: " << search(a, b, c);
}