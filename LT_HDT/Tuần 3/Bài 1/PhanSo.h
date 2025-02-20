#ifndef _PhanSo_
#define _PhanSo_
class PhanSo
{
private:
	int tu;
	int mau;
public:
	void Nhap();
	void Xuat();
	void RutGon();
	PhanSo Tong(PhanSo b);
	PhanSo Hieu(PhanSo b);
	PhanSo Tich(PhanSo b);
	PhanSo Thuong(PhanSo b);
	void SoSanh(PhanSo b);
};
#endif
