#ifndef _accountbank_
#define _accountbank_
#include<iostream>
#include<string>
using namespace std;
class AccountBank
{
private:
	string accountName;
	string accountNumber;
	double accountBalance;
public:
	AccountBank()
	{
		accountName = ""; accountNumber = ""; accountBalance = 0;
	}
	/*AccountBank(string name, string number, double balance);*/
	string getAccountName();
	string getAccountNumber();
	double getAccountBalance();
	void setAccountName(string name);
	void setAccountNumber(string number);
	void setAccountBalance(double balance);
	friend istream& operator>>(istream& is, AccountBank& x);
	friend ostream& operator<<(ostream& os, AccountBank x);
	bool deposit();
	bool withDraw();


};
#endif // !_accountbank_


