#include<iostream>
#include"PhanSo.h"
using namespace std;

void main() {
	PhanSo x;
	cin >> x;
	cout << x;
	PhanSo y;
	cin >> y;
	cout << y;
	cout << x + y;
	cout << x - y;
	cout << x * y;
	cout << x / y;
	cout << "x > y: " << (x > y ? "Dung" : "Sai") << endl;
	cout << "x >= y: " << (x >= y ? "Dung" : "Sai") << endl;
	cout << "x < y: " << (x < y ? "Dung" : "Sai") << endl;
	cout << "x <= y: " << (x <= y ? "Dung" : "Sai") << endl;
	cout << "x == y: " << (x == y ? "Dung" : "Sai") << endl;
}