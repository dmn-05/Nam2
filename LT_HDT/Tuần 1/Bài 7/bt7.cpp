#include<iostream>
#include<cmath>
using namespace std;
void nhap(double& n) {
	do
	{
		cout << "Nhap so N: ";
		cin >> n;
	} while (n <= 0);
}
double S(double n) {
	double s = 0;
	for (int i = n; i != 0; i--)
	{
		s = sqrt(double(i) + s);
	}
	return s;
}
void main() {
	double n;
	nhap(n);
	cout << "S(n): " << S(n);
}