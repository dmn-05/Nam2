#include<iostream>
#include"hinhtron.h"
#include<cmath>
using namespace std;
HTron::HTron()
{
	dknho = dklon = 0;
}
void HTron::nhap() {
	cout << "Nhap duong kinh\n";
	cin >> dklon;
	dknho = dklon;
}
float HTron::dientich() {
	return p * pow(dklon,2);
}
float HTron::chuvi() {
	return 2 * p * (dklon / 2);
}
HTron::~HTron()
{
}