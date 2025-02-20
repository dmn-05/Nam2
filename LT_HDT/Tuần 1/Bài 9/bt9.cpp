#include<iostream>
using namespace std;
void nhaptuoi(int& tuoicha, int& tuoicon) {
	do
	{
		cout << "Nhap tuoi cha:(tuoicha > 2 * tuoicon)\n";
		cin >> tuoicha;
		cout << "Nhap tuoi con:(tuoicha > 2 * tuoicon)\n";
		cin >> tuoicon;
	} while (tuoicha <= tuoicon * 2);
}
int tinh(int tuoicha, int tuoicon) {
	int year = 0;
	while (tuoicha > 2 * tuoicon)
	{
		year++;
		tuoicha++;
		tuoicon++;
	}
	return year;
}
void main()
{
	int tuoicha, tuoicon;
	nhaptuoi(tuoicha, tuoicon);
	cout << "sau " << tinh(tuoicha, tuoicon) << " nam tuoi cha da gap 2 tuoi con";
}