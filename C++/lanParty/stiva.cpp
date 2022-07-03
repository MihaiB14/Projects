#include "stiva.h"

bool Stiva::isEmpty()
{
	if(!size)
		return true;
	else
		return false;
}

void Stiva::push(Echipa *e)
{
	if(isEmpty())
	{
		top = new Echipa(*e,NULL);
		size++;
	}
	else
	{
		Echipa *ech = new Echipa(*e,top);
		top = ech;
		size++;
	}
}

void Stiva::pop()
{
	if(isEmpty())
	{
		cout << "Stiva este goala, nu se mai pot extrage elemente!\n";
		exit(1);
	}
	else
	{
		if(top->get_next() == NULL)
		{
			delete top;
			size--;
			
		}
		else
		{
			Echipa *p = top->get_next();
			delete top;
			top = p;
			size--;
		}
	}
}
