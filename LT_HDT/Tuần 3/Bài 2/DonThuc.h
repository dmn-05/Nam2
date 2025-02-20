#ifndef _DonThuc_
#define _DonThuc_
class DonThuc
{
private:
	int a;
	int b;
public:
	void Nhap();
	void Xuat();
	DonThuc Tong(DonThuc B);
	DonThuc Hieu(DonThuc B);
	double Fx();
};
#endif

