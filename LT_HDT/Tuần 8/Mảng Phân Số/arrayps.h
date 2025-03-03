#include <iostream>
using namespace std;

class PhanSo
{
public:
	PhanSo();
	PhanSo(int tu, int mau);
	PhanSo(const PhanSo& ps);
	friend istream& operator>>(istream& is, PhanSo& x);
	friend ostream& operator<<(ostream& os, PhanSo x);
	bool operator>(PhanSo a);
	bool operator==(PhanSo a);
	~PhanSo();
private:
	int tu, mau;
};

//Mang PS
class Array
{
public:
	Array();
	Array(const Array& arr);
	friend istream& operator>>(istream& is, Array& x);
	friend ostream& operator<<(ostream& os, Array x);
	PhanSo operator[](int index);
	int Find_first(PhanSo ps);
	int GetLength();
	int Max();
	int Min();
	void Add();
	void Insert(int index);
	void Remove(int index);
	void RemoveAll();
	void InterchangeSort();
	~Array();

private:
	PhanSo* Arr;
	int sl;
};

