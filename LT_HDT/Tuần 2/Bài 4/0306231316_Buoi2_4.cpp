#include<iostream>
#include<string>
using namespace std;

template <class T>
void input(T a[], int n) {
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap a["<<i<<"]: ";
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
T TimMax(T a[], int n) {
	T Max = a[0];
	for (int i = 1; i < n; i++)
	{
		if (Max < a[i])
		{
			Max = a[i];
		}
	}
	return Max;
}

void main() {
	int n = 3;
	int a[100];
	cout << "Nhap du lieu kieu int\n";
	input(a, n);
	cout << "Max: "<< TimMax(a, n) << endl;
	

	long b[100];
	cout << "Nhap du lieu kieu long\n";
	input(b,n);
	cout << "Max: " << TimMax(b,n) << endl;


	float c[100];
	cout << "Nhap du lieu kieu float\n";
	input(c,n);
	cout << "Max: " << TimMax(c,n) << endl;
	

	double d[100];
	cout << "Nhap du lieu kieu double\n";
	input(d,n);
	cout << "Max: " << TimMax(d,n) << endl;
	

	char e[100];
	cout << "Nhap du lieu kieu char\n";
	input(e,n);
	cout << "Max: " << TimMax(e,n) << endl;
	
	cin.ignore();

	string f[100];
	cout << "Nhap du lieu kieu string\n";
	inputstr(f, n);
	cout << "Max: " << TimMax(f, n) << endl;
	
}