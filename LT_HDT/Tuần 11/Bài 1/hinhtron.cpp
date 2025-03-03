#include<iostream>
#include"hinhtron.h"
using namespace std;

HINHTRON::HINHTRON() {
	Ra = Rb = 0;
}
HINHTRON::~HINHTRON() {

}
void HINHTRON::nhap() {
	double R;
	cout << "Nhap hinh tron:\n";
	cout << "Nhap ban kinh: ";
	cin >> R;
	Ra = Rb = R;
}