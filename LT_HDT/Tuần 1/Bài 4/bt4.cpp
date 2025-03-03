#include<iostream>
using namespace std;
void nhap(int& day, int& month, int& year) {
	cout << "Nhap Ngay: ";
	cin >> day;
	do
	{
		cout << "Nhap Thang: ";
		cin >> month;
	} while (month < 1 || month>12);
	do
	{
		cout << "Nhap nam: ";
		cin >> year;
	} while (year < 1);
}
int dayofmonth(int month, int year) {
	switch (month)
	{
	case 1:
	case 3:
	case 5:
	case 7:
	case 8:
	case 10:
	case 12:
		return 31;
	case 4:
	case 6:
	case 9:
	case 11:
		return 30;
	case 2:
		if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
		{
			return 29;
		}
		else
		{
			return 28;
		}
	default: return 0;
	}
}
void nextday(int day, int month, int year, int dayOfMonth) {
	if (day < dayOfMonth)
	{
		day++;
	}
	else if (month < 12)
	{
		day = 1;
		month++;
	}
	else
	{
		day = 1;
		month = 1;
		year++;
	}
	cout << "Ngay tiep theo la: " << day << "/" << month << "/" << year;

}
void main() {
	int day, month, year, dayOfMonth;
	nhap(day, month, year);
	dayOfMonth = dayofmonth(month, year);
	while (day>dayOfMonth)
	{
		cout << "Nhap lai ngay: ";
		cin >> day;
	}
	nextday(day, month, year, dayOfMonth);
}