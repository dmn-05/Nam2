#ifndef _hinhtron_
#define _hinhtron_
#include <iostream>
#include"ellipse.h"
using namespace std;

class HTron : public Ellipse
{
public:
	HTron();
	void nhap();
	float dientich();
	float chuvi();
	~HTron();
};
#endif // !_hinhtron_

