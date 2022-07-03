#include "coada.h"

class Stiva
{
	int size;
	Echipa *top;
	public:
		Stiva(){size = 0; top = NULL;};
		~Stiva(){top = NULL;};
		Echipa* get_top(){return top;};
		bool isEmpty();
		int get_size(){return size;};
		void push(Echipa*);
		void pop();
};
