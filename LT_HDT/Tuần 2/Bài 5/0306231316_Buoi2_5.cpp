#include<iostream>
#include<string>
using namespace std;

template <class T>
void input(T a[], int n) {
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap a[" << i << "]: ";
		cin >> a[i];
	}
}
template <class T>
void inputstr(T a[], int n) {
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap a[" << i << "]: ";
		getline(cin, a[i]);
	}
}
template <class T>
T TimMin(T a[], int n) {
	T Min = a[0];
	for (int i = 1; i < n; i++)
	{
		if (Min > a[i])
		{
			Min = a[i];
		}
	}
	return Min;
}

void main() {
	int n = 4;
	int a[100];
	cout << "Nhap du lieu kieu int\n";
	input(a, n);
	cout << "Min: " << TimMin(a, n) << endl;


	long b[100];
	cout << "Nhap du lieu kieu long\n";
	input(b, n);
	cout << "Min: " << TimMin(b, n) << endl;


	float c[100];
	cout << "Nhap du lieu kieu float\n";
	input(c, n);
	cout << "Min: " << TimMin(c, n) << endl;


	double d[100];
	cout << "Nhap du lieu kieu double\n";
	input(d, n);
	cout << "Min: " << TimMin(d, n) << endl;


	char e[100];
	cout << "Nhap du lieu kieu char\n";
	input(e, n);
	cout << "Min: " << TimMin(e, n) << endl;

	cin.ignore();

	string f[100];
	cout << "Nhap du lieu kieu string\n";
	inputstr(f, n);
	cout << "Min: " << TimMin(f, n) << endl;

}