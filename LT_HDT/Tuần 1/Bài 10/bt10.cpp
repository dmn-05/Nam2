#include<iostream>
using namespace std;
void nhap(int& n) {
	do
	{
		cout << "Nhap so N: ";
		cin >> n;
	} while (n <= 0);
}
int Fibonaci(int n) {
	int Fn = 0, Fn_1 = 1, Fn_2 = 0;
	for (int i = 2; i <= n; i++)
	{
		Fn = Fn_1 + Fn_2;
		Fn_2 = Fn_1;
		Fn_1 = Fn;
	}
	return Fn;
}
void main() {
	int n;
	nhap(n);
	cout << "Fibonaci(n): " << Fibonaci(n);
}