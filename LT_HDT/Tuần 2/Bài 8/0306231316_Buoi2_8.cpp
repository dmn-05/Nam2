#include<iostream>

using namespace std;

struct DonThuc
{
	double a, b;
};

void Nhap(DonThuc& A) {
	cout << "Nhap gia tri a: ";
	cin >> A.a;
	cout << "Nhap gia tri b: ";
	cin >> A.b;
}
void Xuat(DonThuc A) {
	if (A.b > 0)
	{
		cout << "f(x) = " << A.a << "x +" << A.b << endl;
	}
	else
	{
		cout << "f(x) = " << A.a << "x " << A.b << endl;
	}
}
DonThuc Tong(DonThuc A, DonThuc B) {
	DonThuc tong;
	tong.a = A.a + B.a;
	tong.b = A.b + B.b;
	return tong;
}
DonThuc Hieu(DonThuc A, DonThuc B) {
	DonThuc hieu;
	hieu.a = A.a - B.a;
	hieu.b = A.b - B.b;
	return hieu;
}
double GiaiDonThuc(DonThuc A) {
	return -A.b / A.a;
}
void main() {
	DonThuc A, B;
	Nhap(A);
	Nhap(B);
	Xuat(A);
	Xuat(B);
	Xuat(Tong(A, B));
	Xuat(Hieu(A, B));
	cout << GiaiDonThuc(A) << endl;
	cout << GiaiDonThuc(B) << endl;
}