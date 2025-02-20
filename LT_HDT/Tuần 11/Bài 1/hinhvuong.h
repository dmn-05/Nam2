#ifndef _HINHVUONG_
#define _HINHVUONG_
#include<iostream>
#include"hinhchunhat.h"
using namespace std;

class HINHVUONG : public HINHCHUNHAT
{
public:
	HINHVUONG();
	~HINHVUONG();
	virtual void nhap();
};
#endif // !_HINHVUONG_

