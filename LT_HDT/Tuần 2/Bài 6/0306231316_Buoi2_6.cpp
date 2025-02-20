#include<iostream>
#include<string>
using namespace std;

template <class T>
void input(T a[], int& n) {
	cout << "Nhap so luong phan tu: ";
	cin >> n;
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap a[" << i << "]: ";
		cin >> a[i];
	}
}
template <class T>
void output(T a[], int n) {
	for (int i = 0; i < n; i++)
	{
		cout << "a[" << i << "]: " << a[i] << endl;
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

template <class T>
T SumArr(T a[], int n) {
	T Sum = a[0];
	for (int i = 1; i < n; i++)
	{
		Sum += a[i];
	}
	return Sum;
}

template <class T>
T Count(T a[], int n) {
	T count = 0;
	for (int i = 0; i < n; i++)
	{
		if (a[i] > 0) {
			count++;
		}
	}
	return count;
}
template <class T>
void selectionsort(T a[], int n) {
	
	for (int i = 0; i < n - 1; i++)
	{
		int MIN = i;
		for (int j = i+1; j < n; j++)
		{
			if (a[MIN] > a [j])
			{
				MIN = j;
			}
		}
		swap(a[MIN], a[i]);
	}
}

void main() {
	int n;
	//int a[100];
	//cout << "Nhap du lieu kieu int\n";
	//input(a, n);
	//output(a, n);
	//cout << "Sum: " << SumArr(a, n) << endl;  
	//cout << "Max: " << TimMax(a, n) << endl;
	//cout << "Quantity: " << Count(a, n) << endl; 
	//selectionsort(a, n);
	//output(a, n);/*a.*/


	//long b[100];
	//cout << "Nhap du lieu kieu long\n";
	//input(b, n);
	//output(b, n);
	//cout << "Max: " << TimMax(b, n) << endl;
	//cout << "Sum: " << SumArr(b, n) << endl;  
	//cout << "Quantity: " << Count(b, n) << endl;
	//selectionsort(b, n);
	//output(b, n);/*a.*/


	//float c[100];
	//cout << "Nhap du lieu kieu float\n";
	//input(c, n);
	//output(c, n);
	//cout << "Max: " << TimMax(c, n) << endl;
	//cout << "Sum: " << SumArr(c, n) << endl;  
	//cout << "Quantity: " << Count(c, n) << endl; 
	//selectionsort(c, n);
	//output(c, n);/*a.*/


	//double d[100];
	//cout << "Nhap du lieu kieu double\n";
	//input(d, n);
	//output(d, n);
	//cout << "Max: " << TimMax(d, n) << endl;
	//cout << "Sum: " << SumArr(d, n) << endl;  
	//cout << "Quantity: " << Count(d, n) << endl; 
	//selectionsort(d, n);
	//output(d, n);/*a.*/


	char e[100];
	cout << "Nhap du lieu kieu char\n";
	input(e, n);
	output(e, n);
	cout << "Max: " << TimMax(e, n) << endl;
	cout << "Sum: " << SumArr(e, n) << endl;  
	selectionsort(e, n);
	output(e, n);/*a.*/
	
	cin.ignore();

	string f[100];
	cout << "Nhap du lieu kieu string\n";
	inputstr(f, n);
	output(f, n);
	cout << "Max: " << TimMax(f, n) << endl;
	cout << "Sum: " << SumArr(f, n) << endl;
	selectionsort(f, n);
	output(f, n);/*a.*/

}