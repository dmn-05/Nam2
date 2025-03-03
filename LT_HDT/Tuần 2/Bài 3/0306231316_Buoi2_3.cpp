#include<iostream>
#include<string>
using namespace std;

template <class T>
void input(T& a, T& b) {
	cout << "Nhap x: ";
	cin >> a;
	cout << "Nhap y: ";
	cin >> b;
}
template <class T>
void HoanVi(T& a, T& b) {
	T temp = a;
	a = b;
	b = temp;
}

void main() {
	int a, b;
	cout << "Nhap du lieu kieu int\n";
	input(a, b);
	cout << "Truoc Khi Hoan Vi: " << a << " " << b << endl;
	HoanVi(a, b);
	cout << "Sau Khi Hoan Vi: " << a << " " << b << endl;

	long c, d;
	cout << "Nhap du lieu kieu long\n";
	input(c, d);
	cout << "Truoc Khi Hoan Vi: " << c << " " << d << endl;
	HoanVi(c, d);
	cout << "Sau Khi Hoan Vi: " << c << " " << d << endl;

	float e, f;
	cout << "Nhap du lieu kieu float\n";
	input(e, f);
	cout << "Truoc Khi Hoan Vi: " << e << " " << f << endl;
	HoanVi(e, f);
	cout << "Sau Khi Hoan Vi: " << e << " " << f << endl;

	double g, h;
	cout << "Nhap du lieu kieu double\n";
	input(g, h);
	cout << "Truoc Khi Hoan Vi: " << g << " " << h << endl;
	HoanVi(g, h);
	cout << "Sau Khi Hoan Vi: " << g << " " << h << endl;

	char i, k;
	cout << "Nhap du lieu kieu char\n";
	input(i, k);
	cout << "Truoc Khi Hoan Vi: " << i << " " << k << endl;
	HoanVi(i, k);
	cout << "Sau Khi Hoan Vi: " << i << " " << k << endl;

	cin.ignore();

	string l, m;
	cout << "Nhap du lieu kieu string\n";
	getline(cin, l);
	getline(cin, m);
	cout << "Truoc Khi Hoan Vi: " << l << " " << m << endl;
	HoanVi(l, m);
	cout << "Sau Khi Hoan Vi: " << l << " " << m << endl;
}