#include<iostream>
#include"ellipse.h"
#include"hinhtron.h"
using namespace std;
void main() {
	Ellipse	E;
	HTron HT;
	cin >> E;
	HT.nhap();
	cout << E;
	cout << HT;
	cout << "chu vi hinh ellipse: " << E.chuvi() << endl;
	cout << "chu vi hinh tron: " << HT.chuvi() << endl;
	cout << "dien tich hinh ellipse: " << E.dientich() << endl;
	cout << "dien tich hinh tron: " << HT.dientich() << endl;
}