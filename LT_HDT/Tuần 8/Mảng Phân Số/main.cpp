#include<iostream>
#include"arrayps.h"
using namespace std;

void main() {
	/*PhanSo ps;
	cin >> ps;
	cout << ps;*/
	Array Arr;
	cin >> Arr;
	cout << Arr;
	/*cout << Arr[2];
	cout << Arr.Find_first();
	cout << Arr.GetLength();*/
	cout << Arr.Max() << endl;
	Arr.InterchangeSort();
	cout << Arr;
}