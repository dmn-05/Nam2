#include<iostream>
using namespace std;
#include"arrayps.h"
#include<algorithm>

PhanSo::PhanSo() {
	tu = 0;
	mau = 1;
}
PhanSo::PhanSo(int tu, int mau) {
	this->tu = tu;
	this->mau = mau;
}
PhanSo::PhanSo(const PhanSo& ps) {
	tu = ps.tu;
	mau = ps.mau;
}
istream& operator>>(istream& is, PhanSo& x) {
	cout << "Nhap tu: ";
	is >> x.tu;
	cout << "Nhap mau: ";
	is >> x.mau;
	return is;
}
ostream& operator<<(ostream& os, PhanSo x) {
	os << x.tu << "/" << x.mau << endl;
	return os;
}
bool PhanSo::operator>(PhanSo a) {
	int dau = (tu * a.mau - a.tu * mau) * (mau * a.mau);
	if (dau > 0) return 1;
	return 0;
}
bool PhanSo::operator==(PhanSo a) {
	int dau = (tu * a.mau - a.tu * mau) * (mau * a.mau);
	if (dau == 0) return 1;
	return 0;
}
PhanSo::~PhanSo() {

}
//Mang PS
Array::Array() {
	sl = 0;
	Arr = NULL;
}
Array::Array(const Array& arr) {
	sl = arr.sl;
	Arr = new PhanSo[sl];
	for (int i = 0; i < sl; i++)
	{
		Arr[i] = arr.Arr[i];
	}
}
istream& operator>>(istream& is, Array& x) {
	cout << "Nhap sl: ";
	is >> x.sl;
	x.Arr = new PhanSo[x.sl];
	for (int i = 0; i < x.sl; i++)
	{
		cout << "Nhap Phan So Thu " << i + 1 << ":\n";
		is >> x.Arr[i];
	}
	return is;
}
ostream& operator<<(ostream& os, Array x) {
	for (int i = 0; i < x.sl; i++)
	{
		os << "Phan So Thu " << i << ": " << x.Arr[i] << endl;
	}
	return os;
}
PhanSo Array::operator[](int index) {
	return Arr[index];
}
int Array::Find_first(PhanSo ps) {
	for (int i = 0; i < sl; i++)
	{
		if (Arr[i]==ps)
		{
			return i;
		}
	}
	return -1;
}
int Array::GetLength() {
	return sl;
}

int Array::Max() {
	int max = 0;
	for (int i = 0; i < sl; i++)
	{
		if (Arr[i] > Arr[max]) {
			max = i;
		}
	}
	return max;
}
int Array::Min() {
	int min = 0;
	for (int i = 0; i < sl; i++)
	{
		if (Arr[min] > Arr[i]) {
			min = i;
		}
	}
	return min;
}
void Array::Add() {
	int soluong = sl + 1;
	PhanSo* temp = new PhanSo[soluong];
	PhanSo a;
	cout << "Nhap Phan So Can Them \n";
	cin >> a;
	temp[0] = a;
	for (int i = 0; i < sl; i++)
	{
		temp[i + 1] = Arr[i];
	}
}
void Array::Insert(int index) {
	int soluong = sl + 1;
	PhanSo* temp = new PhanSo[soluong];
	PhanSo a;
	cout << "Nhap Phan So Can Them \n";
	cin >> a;
	for (int i = 0; i < index; i++)
	{
		temp[i] = Arr[i];
	}
	temp[index] = a;
	for (; index < sl; index++)
	{
		temp[index + 1] = Arr[index];
	}
}
void Array::Remove(int index) {
	int soluong = sl - 1;
	PhanSo* temp = new PhanSo[soluong];
	for (int i = 0; i < index; i++)
	{
		temp[i] = Arr[i];
	}
	for (; index < sl - 1; index++)
	{
		temp[index] = Arr[index + 1];
	}
}
void Array::RemoveAll() {
	delete Arr;
	Arr = NULL;
	sl = 0;
}
void Array::InterchangeSort() {
	for (int i = 0; i < sl - 1; i++)
	{
		for (int j = i+1; j < sl; j++)
		{
			if (Arr[i] > Arr[j])
			{
				swap(Arr[i], Arr[j]);
			}
		}
	}
}
Array::~Array() {

}