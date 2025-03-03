#include<iostream>
using namespace std;
void nhap(int& n) {
	do
	{
		cout << "Nhap so n co 4 chu so: ";
		cin >> n;
	} while (n < 999 || n>10000);
}
int search(int n) {
	int a;
	int min1 = 10, min2 = 10;
	while(n != 0)
	{
		a = n % 10;
		if (a < min1)
		{
			min2 = min1;
			min1 = a;
		}
		else if (a < min2 && a != min1)
		{
			min2 = a;
		}
		n /= 10;
	}
	return min2;
}

void main() {
	int n;
	nhap(n);
	if (search(n) == 10)
	{
		cout << "Khong co so nho nhi!";
	}
	else
	{
		cout << "so nho nhi la: " << search(n);
	}
}