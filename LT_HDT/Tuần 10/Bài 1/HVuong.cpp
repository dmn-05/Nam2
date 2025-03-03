#include<iostream>
#include"HVuong.h"
using namespace std;

HV::HV()
{
	dai = rong = 0;
}
void HV::nhap (){
	float canh;
	cout << "Nhap chieu dai canh: ";
	cin >> canh;
	dai = rong = canh;
}
HV::~HV()
{

}