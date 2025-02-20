#include<iostream>
#include<cmath>

using namespace std;


void input(double& x,double& y,double& z) {
	cout << "Nhap x: ";
	cin >> x;
	cout << "Nhap y: ";
	cin >> y;
	cout << "Nhap z: ";
	cin >> z;
}
double TinhDoLonVector(double x, double y = 0, double z = 0) {
	double V = sqrt(pow(x, 2) + pow(y, 2) + pow(z, 2));
	return V;
}

void main() {
	double x, y, z;
	input(x, y, z);
	cout << TinhDoLonVector(x) << endl;
	cout << TinhDoLonVector(x, y) << endl;
	cout << TinhDoLonVector(z, y, z) << endl;
}