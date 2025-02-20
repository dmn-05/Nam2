#include<iostream>
#include<cmath>
using namespace std;

void nhap(double& a, double& b, double& c) {
	cout << "Nhap a: ";
	cin >> a;
	cout << "Nhap b: ";
	cin >> b;
	cout << "Nhap c: ";
	cin >> c;
 }
double timx(double a, double b, double c) {
	double x1, x2;
	double delta = b * b - 4 * a * c;
	if (delta == 0)
	{
		x1 = x2 = -b / 2 * a;
		cout << "phuong trinh co nghiem kep: x1 = x2 ="<< x1;
	}
	else if (delta > 0)
	{
		x1 = (-b + sqrt(delta)) / 2 * a;
		x2 = (-b - sqrt(delta)) / 2 * a;
		cout << "Phuong trinh co hai nghiem:\n";
		cout << "x1 = " << x1 << endl;
		cout << "x2 = " << x2 << endl;
	}
	else
	{
		cout << "Phuong tinh vo nghiem\n";
	}
}
void main() {
	double a, b, c;
	nhap(a, b, c);
	timx(a, b, c);
}