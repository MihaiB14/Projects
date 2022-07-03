#include "coada.h"

bool Coada::isEmpty()
{
	if(front == NULL && rear == NULL)
		return true;
	else
		return false;
}

void Coada::enQueue(Meci *m)
{
	if(isEmpty())
	{
		Meci *mech = new Meci(m->get_ecp1(),m->get_ecp2(),NULL);
		front = rear = mech;
	}
	else
	{
		Meci *mech = new Meci(m->get_ecp1(),m->get_ecp2(),NULL);
		rear->set_next_m(mech);
		rear = mech;
	}
}

void Coada::deQueue()
{
	if(isEmpty())
	{
		cout << "Nu se poate extrage niciun element din coada!\n";
		exit(1);
	}
	else
	{
		if(front == rear)
		{
			delete front;
			front = rear = NULL;
		}
		else
		{
			Meci *p = front->get_next_m();
			delete front;
			front = p;
		}
	}
}

