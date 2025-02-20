#include<iostream>
using namespace std;
void nhap(double& n) {
	do
	{
		cout << "Nhap so N: ";
		cin >> n;
	} while (n<=0);
}
double S(double n) {
	double s = 0;
	for (int i = 1; i <= n; i++)
	{
		if (i % 2 == 0)
		{
			s -= 1 / double(i);
		}
		else
		{
			s += 1 / double(i);
		}
	}
	return s;
}
void main() {
	double n;
	nhap(n);
	cout << "S(n): " << S(n);
}