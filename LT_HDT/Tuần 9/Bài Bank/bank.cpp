#include<iostream>
#include<string>
#include"bank.h"

using namespace std;

Bank::Bank()
{
	soluong = 0;
	listBank = NULL;
}
istream& operator>>(istream& is, Bank& x) {
	string name, number;
	double balance;
	cout << "Nhap so luong : ";
	is >> x.soluong;
	x.listBank = new AccountBank[x.soluong];
	for (int i = 0; i < x.soluong; i++)
	{
		cout << "Nhap tai khoan bank " << i << ":\n";
		cout << "Nhap accountName: ";
		is >> name;
		cout << "Nhap accountNumber: ";
		is >> number;
		cout << "Nhap accountBalance: ";
		is >> balance;
		x.listBank[i].setAccountName(name);
		x.listBank[i].setAccountNumber(number);
		x.listBank[i].setAccountBalance(balance);
	}
	return is;
}
ostream& operator<<(ostream& os, Bank x) {
	for (int i = 0; i < x.soluong; i++)
	{
		os << "tai khoan " << i + 1 << ":\n";
		os << x.listBank[i].getAccountName() << endl;
		os << x.listBank[i].getAccountNumber() << endl;
		os << x.listBank[i].getAccountBalance() << endl;
	}
	return os;
}
bool Bank::add() {
	Bank temp;
	bool kq = 0;
	temp.soluong = this->soluong;
	temp.listBank = new AccountBank[temp.soluong + 1];
	int i = 0;
	for (; i < this->soluong; i++)
	{
		temp.listBank[i] = this->listBank[i];
	}
	cout << "Them tai khoan:\n";
	cin >> temp.listBank[i];
	for (int j = 0; j < i; j++)
	{
		if (temp.listBank[j].getAccountNumber() == temp.listBank[i].getAccountNumber())
		{
			return kq;
		}
	}
	
	delete[]this->listBank;
	this->soluong++;
	this->listBank = new AccountBank[this->soluong];
	if (this->listBank != NULL)
	{
		for (int i = 0; i < this->soluong; i++)
		{
			this->listBank[i].setAccountName(temp.listBank[i].getAccountName());
			this->listBank[i].setAccountNumber(temp.listBank[i].getAccountNumber());
			this->listBank[i].setAccountBalance(temp.listBank[i].getAccountBalance());
		}
		kq = true;
	}
	return kq;
}
bool Bank::depositList() {
	string add;
	bool kq = 0;
	cout << "Nhap So Tai Khoan can nap tien:\n";
	cin.ignore();
	getline(cin, add);
	for (int i = 0; i < this->soluong; i++)
	{
		if (this->listBank[i].getAccountNumber() == add)
		{
			if (this->listBank[i].deposit())
			{
				kq = 1;
			}
		}
	}
	return kq;
}
bool Bank::withDrawList() {
	string rut;
	bool kq = 0;
	cout << "Nhap So Tai Khoan can rut tien:\n";
	cin.ignore();
	getline(cin, rut);
	for (int i = 0; i < this->soluong; i++)
	{
		if (this->listBank[i].getAccountNumber() == rut)
		{
			if (this->listBank[i].withDraw())
			{
				kq = 1;
			}
		}
	}
	return kq;
}
int Bank::search(string number) {
	int kq = -1;
	for (int i = 0; i < this->soluong; i++)
	{
		if (this->listBank[i].getAccountNumber() == number)
		{
			kq = i;
		}
	}
	return kq;
}
bool Bank::remove() {
	Bank temp;
	bool kq = 0;
	string remove;
	temp.soluong = this->soluong;
	temp.listBank = new AccountBank[temp.soluong - 1];
	cout << "Xoa tai khoan:\n";
	cin.ignore();
	getline(cin, remove);
	int index = this->search(remove);
	if (index == -1)
	{
		return kq;
	}
	for (int i = 0; i < index; i++)
	{
		temp.listBank[i] = this->listBank[i];
	}
	
	for (int i = index; i < this->soluong - 1; i++)
	{
		temp.listBank[i] = this->listBank[i + 1];
	}

	delete[]this->listBank;
	this->soluong--;
	this->listBank = new AccountBank[this->soluong];
	if (this->listBank != NULL)
	{
		for (int i = 0; i < this->soluong; i++)
		{
			this->listBank[i].setAccountName(temp.listBank[i].getAccountName());
			this->listBank[i].setAccountNumber(temp.listBank[i].getAccountNumber());
			this->listBank[i].setAccountBalance(temp.listBank[i].getAccountBalance());
		}
		kq = true;
	}
	return kq;
}
bool Bank::removeAll() {
	bool kq = 0;
	if (this->soluong > 0)
	{
		this->soluong = 0;
		delete[]this->listBank;
		this->listBank = NULL;
		kq = 1;
	}
	return kq;
}
