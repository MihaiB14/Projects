#include "echipa.h"

class Node
{
	Echipa *head;
	public:
		Node():head(NULL){};
		~Node(){head = NULL;};
		void set_head(Echipa *e){head = e;};
		Echipa* get_head(){return head;}
};
