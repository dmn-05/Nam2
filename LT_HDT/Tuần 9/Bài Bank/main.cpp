#include<iostream>
#include<string>
#include"bank.h"
using namespace std;

int main() {
	Bank list;
	cin >> list;
	cout << list;
	if (list.add())
	{
		cout << "Them thanh cong!\n";
	}
	else
	{
		cout << "Them that bai!\n";
	}
	cout << list;
	/*if (list.depositList()) {
		cout << "Nap thanh cong!\n";
	}
	else
	{
		cout << "Nap that bai!\n";
	}
	if (list.withDrawList()) {
		cout << "Rut thanh cong!\n";
	}
	else
	{
		cout << "Rut that bai!\n";
	}
	cout << list;*/
	if (list.remove())
	{
		cout << "Xoa thanh cong!\n";
	}
	else
	{
		cout << "Xoa that bai!\n";
	}
	cout << list;
}
