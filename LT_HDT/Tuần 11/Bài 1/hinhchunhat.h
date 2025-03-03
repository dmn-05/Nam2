#ifndef _HINHCHUNHAT_
#define _HINHCHUNHAT_
#include<iostream>
#include"hinh.h"
using namespace std;

class HINHCHUNHAT : public HINH
{
public:
	HINHCHUNHAT();
	HINHCHUNHAT(double dai, double rong);
	~HINHCHUNHAT();
	virtual void nhap();
	virtual double dienTich();
protected:
	double dai, rong;
};
#endif // !_HINHCHUNHAT_

