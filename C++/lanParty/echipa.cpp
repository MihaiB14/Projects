#include "echipa.h"

Echipa::Echipa():nr_players(0), name(string()), vector(NULL), next(NULL){};

Echipa::Echipa(int nr, string nume, Player *p, Echipa *n):nr_players(nr), name(nume), next(n)
{
	if(p != NULL)
	{
		vector = new Player[nr_players];
		for(int i = 0; i < nr_players; i++)
		{
			vector[i] = p[i];
		}
	}
	else
	{
		vector = NULL;
	}
}

Echipa::Echipa(const Echipa &e,Echipa *n):nr_players(e.nr_players), name(e.name), next(n)
{
	if(e.vector != NULL)
	{
		vector = new Player[nr_players];
		for(int i = 0; i < nr_players; i++)
		{
			vector[i] = e.vector[i];
		}
	}
	else
	{
		vector = NULL;
	}
}

Echipa& Echipa::operator = (const Echipa &e)
{
	if(this != &e)
	{
		nr_players = e.nr_players;
		name = e.name;
		if(vector != NULL)
		{
			delete [] vector;
		}
		if(e.vector != NULL)
		{	
			vector = new Player[nr_players];
			for(int i = 0; i < nr_players; i++)
			{
				vector[i] = e.vector[i];
			}
		}	
		else
		{
			vector = NULL;
		}
	}
	return *this;
}

Echipa::~Echipa()
{
	if(vector != NULL)
	{
		delete [] vector;
	}
	vector = NULL;
	next = NULL;
}

void Echipa::set_nrplayers(int n)
{
	nr_players = n;
	if(vector != NULL)
		delete [] vector;
	vector = new Player[nr_players];
}

void Echipa::set_name(const string &nume)
{
	name = nume;
}

void Echipa::set_vector(string f, string s, int p, int poz)
{
	vector[poz].set_fname(f);
	vector[poz].set_sname(s);
	vector[poz].set_points(p);
}

string Echipa::get_name()
{
	return name;
}

int Echipa::get_nr_players()
{
	return nr_players;
}

double Echipa::get_suma_puncte()
{
	double suma = 0;
	for(int i = 0; i < nr_players; i++)
	{
		suma += vector[i].get_points();
	}
	return suma;
}

double Echipa::get_experienta()
{
	return (double)Echipa::get_suma_puncte()/Echipa::get_nr_players();
}

void Echipa::add_points()
{
	for(int i = 0; i < nr_players; i++)
	{
		vector[i].set_points(vector[i].get_points()+1);
	}
}

void Echipa::set_next(Echipa *e)
{
	next = e;
}

Echipa* Echipa::get_next()
{
	return next;
}
