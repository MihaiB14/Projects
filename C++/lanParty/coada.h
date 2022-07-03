#include "meci.h"

class Coada
{
	Meci *front;
	Meci *rear;
	public:
		Coada(){front = NULL; rear = NULL;};
		~Coada(){front = NULL; rear = NULL;};
		Meci* get_front(){return front;};
		void enQueue(Meci*);
		void deQueue();
		bool isEmpty();
};
