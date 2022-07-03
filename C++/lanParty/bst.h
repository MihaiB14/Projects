#include "stiva.h"

class BST
{
	Echipa *ech;
	BST *left_BST;
	BST *right_BST;
	public:
		BST();
		BST(Echipa*);
		~BST();
		BST* insert(BST*, Echipa*);
		void inorder(BST*, char *argv[]);
		BST* get_right_BST(){return right_BST;};
		BST* get_left_BST(){return left_BST;};
		Echipa* get_ech(){return ech;};
};
