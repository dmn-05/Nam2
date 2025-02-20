#include<iostream>
#include<string>
#include"accountbank.h"

using namespace std;

//AccountBank::AccountBank(string name, string number, double balance) {
//	accountName = name;
//	accountNumber = number;
//	accountBalance = balance;
//}
string AccountBank::getAccountName() {
	return accountName;
}
string AccountBank::getAccountNumber() {
	return accountNumber;
}

double AccountBank::getAccountBalance() {
	return accountBalance;
}
void AccountBank::setAccountName(string name) {
	accountName = name;
}
void AccountBank::setAccountNumber(string number) {
	accountNumber = number;
}
void AccountBank::setAccountBalance(double balance) {
	accountBalance = balance;
}
istream& operator>>(istream& is, AccountBank& x) {
	cout << "Nhap accountName: ";
	is >> x.accountName;
	cout << "Nhap accountNumber: ";
	is >> x.accountNumber;
	cout << "Nhap accountBalance: ";
	is >> x.accountBalance;
	return is;
}
ostream& operator<<(ostream& os, AccountBank x) {
	os << "accountName: " << x.accountName << endl;
	os << "accountNumber: " << x.accountNumber << endl;
	os << "accountBalance: " << x.accountBalance << endl;
	return os;
}
bool AccountBank::deposit() {
	double money;
	cout << "Nhap so tien: ";
	cin >> money;
	if (money > 0)
	{
		this->accountBalance += money;
		return 1;
	}
	return 0;
}
bool AccountBank::withDraw() {
	double money;
	cout << "Nhap so tien: ";
	cin >> money;
	if (money > 0 && money <= accountBalance)
	{
		this->accountBalance -= money;
		return 1;
	}
	return 0;
}