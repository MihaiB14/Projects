#include "avl.h"

AVL::AVL():height(1), ech(NULL), left_AVL(NULL), right_AVL(NULL){};

AVL::AVL(Echipa *e)
{

	if(e != NULL)
	{
		ech = new Echipa(*e,NULL);
	}
	else
	{
		ech = NULL;
	}
	
	left_AVL = NULL;
	right_AVL = NULL;
	height = 1;
}

AVL::~AVL()
{
	if(ech != NULL)
		delete ech;
	ech = NULL;
	left_AVL = NULL;
	right_AVL = NULL;
}

int max_nr(int a, int b)
{
	return ((a>b)?a:b);
}

int AVL::nodeHeight(AVL *root)
{
	if(root == NULL)
		return 0;
	else
		return root->height;
}

AVL* AVL::RightRotation(AVL *z)
{
	//cout << "rotatie!\n";
	AVL *y = z->left_AVL;
	AVL *T3 = y->right_AVL;
	
	y->right_AVL = z;
	z->left_AVL = T3;
	
	z->height = max_nr(nodeHeight(z->left_AVL),nodeHeight(z->right_AVL))+1;
	y->height = max_nr(nodeHeight(y->left_AVL),nodeHeight(y->right_AVL))+1;
	
	return y; 
}

AVL* AVL::LeftRotation(AVL *z)
{
	//cout << "rotatie!\n";
	AVL *y = z->right_AVL;
	AVL *T2 = y->left_AVL;
	
	y->left_AVL = z;
	z->right_AVL = T2;

	z->height = max_nr(nodeHeight(z->left_AVL),nodeHeight(z->right_AVL)) + 1;
	y->height = max_nr(nodeHeight(y->left_AVL),nodeHeight(y->right_AVL)) + 1;
	
	return y;
}

AVL* AVL::LRRotation(AVL *Z)
{
	//cout << "rotatie LR\n";
	//AVL *ecp = Z->left_AVL;
	Z->left_AVL = LeftRotation(Z->left_AVL);
	//cout << "a trecut\n";
	return RightRotation(Z);
}

AVL* AVL::RLRotation(AVL *Z)
{
	//cout << "rotatie RL\n";
	//cout << Z->ech->get_name() << endl;
	Z->right_AVL = RightRotation(Z->right_AVL);
	//cout << "a trecut!\n";
	return LeftRotation(Z);
}

AVL* AVL::insert(AVL *node, Echipa *e)
{
	//cout << "aici baaaaaaaa!\n";
	//cout << "insert: " << node->ech->get_name() << endl;
	if(node == NULL)
	{
		node = new AVL(e);
		
		//cout << "e gol\n";
		return node;	
	}
	
	if(e->get_experienta() < node->ech->get_experienta())
	{
		//cout << "merge la stanga!\n";
		node->left_AVL = insert(node->left_AVL,e);
	}
	else
	{
		if(e->get_experienta() > node->ech->get_experienta())
		{
			//cout << "merge la dreapa!\n";
			node->right_AVL = insert(node->right_AVL,e);
		}
		else
		{
			if(e->get_experienta() == node->ech->get_experienta())
			{
				if(e->get_name().compare(node->ech->get_name()) < 0)
				{
					node->left_AVL = insert(node->left_AVL,e);
				}
				else
				{
					node->right_AVL = insert(node->right_AVL,e);
				}
			}
		}
	}
	
	
	
	node->height = 1 + max_nr(nodeHeight(node->left_AVL),nodeHeight(node->right_AVL));
	int k = 0;
	if(node != NULL)
	{
		k = nodeHeight(node->left_AVL) - nodeHeight(node->right_AVL);
	}

	AVL *ecp;
	//cout << "aici1\n";
	ecp = node->left_AVL;
	if(k > 1 && e->get_experienta() < ecp->ech->get_experienta())
	{
		//cout << "Primul if\n";
		return RightRotation(node);
	}

	ecp = node->right_AVL;
	if(k < -1 && e->get_experienta() > ecp->ech->get_experienta())
	{	//cout << "Al doilea if!\n";
		return LeftRotation(node);
	}
	
	ecp = node->left_AVL;
	//cout << ecp->ech->get_name() << endl;	
	if(k > 1 && e->get_experienta() > ecp->ech->get_experienta())
	{
		//cout << "Al treilea if!\n";
		return LRRotation(node);
	}
	//cout << "aici4\n";
	ecp = node->right_AVL;
	if(k < -1 && e->get_experienta() < ecp->ech->get_experienta())
	{
		//cout << "Al patrulea if\n";
		return RLRotation(node);
	}
	//cout << node->ech->get_name()  << " - "<< node->height << endl;
	//cout << "Si aici\n";
	//cout << node->ech->get_name() << endl;
	//cout << "final!\n";
	return node;
}

void AVL::inorder(AVL *root, char *argv[])
{
	if(root == NULL)
	{
		return;
	}
	else
	{
		inorder(root->right_AVL,argv);
		//if(root->height == 2)
		//{
			ofstream rezultate(argv[3], ios::app);
			if(!rezultate)
			{
				cout << "Nu s-a putut deschide fisierul r.out!\n";
				exit(1);
			}
			rezultate << root->ech->get_name() << " " << root->height << endl;
		//}
		//cout << root->ech->get_name() << " - " << root->ech->get_experienta() << " - " << root->height << endl;
		inorder(root->left_AVL,argv);
	}
}
