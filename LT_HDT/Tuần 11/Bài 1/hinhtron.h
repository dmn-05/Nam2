#ifndef _HINHTRON_
#define _HINHTRON_
#include<iostream>
#include"hinhellipse.h"
using namespace std;

class HINHTRON : public ELLIPSE
{
public:
	HINHTRON();
	~HINHTRON();
	virtual void nhap();
};
#endif // !_HINHTRON_

