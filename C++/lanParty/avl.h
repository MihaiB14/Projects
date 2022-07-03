#include "bst.h"

class AVL
{
	int height;
	Echipa *ech;
	AVL *left_AVL;
	AVL *right_AVL;
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
		Echipa* get_ech(){return ech;};
		AVL* get_right_AVL(){return right_AVL;};
		AVL* get_left_AVL(){return left_AVL;};
};

