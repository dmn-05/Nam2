#include<iostream>

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
	input(a,b);
	cout << "Truoc Khi Hoan Vi" << a << " " << b;
	HoanVi(a, b);
	cout << "Sau Khi Hoan Vi" << a << " " << b;

	long a, b;
	cout << "Nhap du lieu kieu long\n";
	input(a, b);
	cout << "Truoc Khi Hoan Vi" << a << " " << b << endl;
	HoanVi(a, b);
	cout << "Sau Khi Hoan Vi" << a << " " << b << endl;

	float a, b;
	cout << "Nhap du lieu kieu float\n";
	input(a, b);
	cout << "Truoc Khi Hoan Vi" << a << " " << b << endl;
	HoanVi(a, b);
	cout << "Sau Khi Hoan Vi" << a << " " << b << endl;

	double a, b;
	cout << "Nhap du lieu kieu double\n";
	input(a, b);
	cout << "Truoc Khi Hoan Vi" << a << " " << b << endl;
	HoanVi(a, b);
	cout << "Sau Khi Hoan Vi" << a << " " << b << endl;
}