#include "meci.h"

Meci::Meci(Echipa *e1, Echipa *e2, Meci *next):next_m(next)
{
	if(e1 != NULL)
	{
		ecp1 = new Echipa(*e1,NULL);
	}
	else
	{
		ecp1 = NULL;
	}
	
	if(e2 != NULL)
	{
		ecp2 = new Echipa(*e2,NULL);
	}
	else
	{
		ecp2 = NULL;
	}
}

Meci::~Meci()
{
	if(ecp1 != NULL)
	{
		delete ecp1;
	}
	ecp1 = NULL;
	
	if(ecp2 != NULL)
	{
		delete ecp2;
	}
	
	ecp2 = NULL;
}

Echipa* Meci::get_ecp1()
{
	return ecp1;
}

Echipa* Meci::get_ecp2()
{
	return ecp2;
}
