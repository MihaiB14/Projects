#include "node.h"

class Meci
{
	Echipa *ecp1;
	Echipa *ecp2;
	Meci *next_m;
	public:
		Meci(){ecp1 = NULL; ecp2 = NULL;};
		Meci(Echipa*,Echipa*,Meci*);
		~Meci();
		void set_next_m(Meci *next){next_m = next;};
		Meci* get_next_m(){return next_m;};
		Echipa* get_ecp1();
		Echipa* get_ecp2();
};
