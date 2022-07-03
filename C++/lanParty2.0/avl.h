#include "bst.h"

class AVL
{
	map<float,Echipa*> team;
	int height;
	AVL *left_AVL, *right_AVL;
	public:
		AVL();
		AVL(Echipa*);
		~AVL();
		int nodeHeight(AVL*);
		AVL* RightRotation(AVL*);
		AVL* LeftRotation(AVL*);
		AVL* LRRotation(AVL*);
		AVL* RLRotation(AVL*);
		AVL* insert(AVL*, Echipa*);
		void inorder(AVL*, char *argv[]);
		int get_height(){return height;};
		map<float,Echipa*> get_ech(){return team;};
		AVL* get_right_AVL(){return right_AVL;};
		AVL* get_left_AVL(){return left_AVL;};
		void modif_inaltime(AVL*,int);
};
