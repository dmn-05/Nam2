#ifndef _bank_
#define _bank_
#include<iostream>
#include<string>
#include"accountbank.h"
using namespace std;
class Bank
{
public:
	Bank();
	friend istream& operator>>(istream& is, Bank& x);
	friend ostream& operator<<(ostream& os, Bank x);
	bool add();
	bool depositList();
	bool withDrawList();
	int search(string number);
	bool remove();
	bool removeAll();
	

private:
	AccountBank* listBank;
	int soluong;
};
#endif // !_bank_


