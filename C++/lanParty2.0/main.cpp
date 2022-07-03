#include "functie.h"

int main(int argc, char *argv[])
 {
 	Node *first, *arbori;
 	int nr_team;
 	BST *root;
	
	ifstream cerinte(argv[1]);
	if(!cerinte)
	{
		cout << "Nu s-a putut deschide fisierul c.in!\n";
		exit(1);
	}
	
	for (int i = 0; i < 5; i++) {
		int task;
		cerinte >> task;
		switch (i) {
			case 0: {
				if (task == 1)
					citire_afisare(&first,nr_team,argv);
				break;
			}
			case 1: {
				if (task == 1)
					stergere(&first,nr_team,argv);
				break;
			}
			case 2: {
				if (task == 1)
					creare_coada_stive(first,&arbori,nr_team,argv);	
				break;
			}
			case 3: {
				if(task == 1)
					BST_function(arbori,&root,argv);
				break;
			}
			case 4: {
				if(task == 1)
					AVL_function(root,argv);
				break;
			}
			default: {
				cout << "Error! " << endl;
				break;
			}
		}
	}
	
	Eliberare_memorie(&first);
	
	cerinte.close();
	
	return 0;
}
