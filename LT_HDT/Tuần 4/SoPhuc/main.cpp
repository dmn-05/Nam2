#include<iostream>
#include"SoPhuc.h"
using namespace std;

void main() {
	SoPhuc x;
	cin >> x;
	cout << x;
	SoPhuc y;
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