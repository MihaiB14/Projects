#include "bst.h"
#include <iomanip>

BST::BST():ech(NULL), left_BST(NULL), right_BST(NULL){};

BST::BST(Echipa *e)
{
	if(e != NULL)
	{
		ech = new Echipa(*e,NULL);
	}
	else
	{
		ech = NULL;
	}
	left_BST = right_BST = NULL;
}

BST::~BST()
{
	if(ech != NULL)
	{
		delete ech;
	}
	ech = NULL;
	left_BST = NULL;
	right_BST = NULL;
}

BST* BST::insert(BST *root, Echipa *e)
{
	if(!root)
	{
		BST *b = new BST(e);
		return b;
	}
	
	if(e->get_experienta() > root->ech->get_experienta())
	{
		root->right_BST = insert(root->right_BST, e);
	}
	else
	{
		if(e->get_experienta() < root->ech->get_experienta())
		{
			root->left_BST = insert(root->left_BST, e);
		}
		else
		{
			if(e->get_name().compare(root->ech->get_name()) < 0)
			{
				root->left_BST = insert(root->left_BST, e);
			}
			else
			{
				root->right_BST = insert(root->right_BST, e);
			}
		}
	}
	return root;
}

void BST::inorder(BST *root, char *argv[])
{
	if(!root)
	{
		return;
	}
	inorder(root->right_BST,argv);
	
	ofstream rezultate(argv[3], ios::app);
	if(!rezultate)
	{
		cout << "NU s-a putut deschide fisierul r.out!\n";
		exit(1);
	}
	rezultate << left << setw(34);
	rezultate << root->ech->get_name();
	rezultate << fixed << setprecision(2) << "-  " << root->ech->get_experienta() << endl;
	rezultate.close();
	inorder(root->left_BST,argv);
}
