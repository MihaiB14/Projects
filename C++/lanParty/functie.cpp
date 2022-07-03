#include "functie.h"

void citire_afisare(Node **first, int &nr_team, char *argv[])
{
	ifstream date(argv[2]);
	if(!date)
	{
		cout << "NU s-a putut deschide fisierul d.in!\n";
		exit(1);
	}
	
	date >> nr_team;
	int nr, pct;
	string S,s,name;
	Player *vector;
	
	date >> nr;
	getline(date,name);
	if(name[name.length()-1] == ' ')
	{
		name = name.substr(0,name.length()-1);
	}
	name = name.substr(1,name.length());
	vector = new Player[nr];
	for(int i = 0; i < nr; i++)
	{
		date >> S >> s >> pct;
		vector[i].set_fname(S);
		vector[i].set_sname(s);
		vector[i].set_points(pct);
	}
	
	Echipa *e = new Echipa(nr,name,vector,NULL);
	Node *newNode = new Node;
	newNode->set_head(e);
	*first = newNode;
	
	for(int i = 1; i < nr_team; i++)
	{
		date >> nr;
		getline(date,name);
		if(name[name.length()-1] == ' ')
		{
			name = name.substr(0,name.length()-1);
		}
		name = name.substr(1,name.length());
		vector = new Player[nr];
		for(int i = 0; i < nr; i++)
		{
			date >> S >> s >> pct;
			vector[i].set_fname(S);
			vector[i].set_sname(s);
			vector[i].set_points(pct);
		}
		Echipa *ech = new Echipa(nr,name,vector,newNode->get_head());
		newNode->set_head(ech);
	}
	*first = newNode;
	
	ofstream rezultate(argv[3]);
	if(!rezultate)
	{
		cout << "Nu s-a putut deschide fisierul r.out!\n";
		exit(1);
	}
	
	Echipa *p = newNode->get_head();
	while(p != NULL)
	{
		rezultate << p->get_name() << endl;
		p = p->get_next();
	}
	rezultate.close();
	date.close();
}

int speciala(int nr_team)
{
	int numar = 1;
	while(numar <= nr_team)
	{
		numar *= 2;	
	}
	return numar/2;
}

Echipa* minim(Node *n)
{
	Echipa *poz = n->get_head(), *asta;
	double min = 100.0;
	while(poz != NULL)
	{
		if(poz->get_experienta() < min)
		{
			min = poz->get_experienta();
			asta = poz;
		}		
		poz = poz->get_next();
	}

	return asta;
}

void stergere(Node **first, int &nr_team, char *argv[])
{
	Node *newNode = *first;
	Echipa *min;
	int special = speciala(nr_team);
	
	while(nr_team > special)
	{
		min = minim(*first);
		if(min == newNode->get_head())
		{
			Echipa *p = newNode->get_head()->get_next();
			delete newNode->get_head();
			newNode->set_head(p);
			
		}

		else
		{
			Echipa *pcl = newNode->get_head(), *qcl = newNode->get_head()->get_next();
			while(pcl->get_next() != NULL)
			{
				if(qcl == min)
				{
					pcl->set_next(qcl->get_next());
					delete qcl;
					break;
				}
				else
				{
					pcl = qcl;
					qcl = qcl->get_next();
				}
				
			}
		}
		nr_team--;
	}
	
	ofstream rezultate(argv[3]);
	if(!rezultate)
	{
		cout << "Nu s-a putut deschide fisierul r.out!\n";
		exit(1);
	}
	
	Echipa *p = newNode->get_head();
	while(p != NULL)
	{
		rezultate << p->get_name() << endl;
		p = p->get_next();
	}
	rezultate.close();
}	

void creare_coada(Coada **c, Echipa **cap)
{
	*c = new Coada;
	while(*cap != NULL)
	{
		Meci *m = new Meci(*cap,(*cap)->get_next(),NULL);
		(*c)->enQueue(m);
		Echipa *p = (*cap)->get_next();
		delete *cap;
		*cap = p;
		p = p->get_next();
		delete *cap;
		*cap = p;
	}
}

void afis_coada_creare_stive(Coada *c, Stiva **w, Stiva **w_cpy, Stiva **l, int contor, char *argv[])
{
	ofstream rezultate(argv[3], ios::app);
	if(!rezultate)
	{
		cout << "Nu s-a putut deschide fisierul r.out!\n";
		exit(1);
	}
	
	*w = new Stiva;
	*w_cpy = new Stiva;
	*l = new Stiva;
	
	rezultate << endl << "--- ROUND NO:" << contor << endl;
	while(!c->isEmpty())
	{
		rezultate << left << setw(33);
		rezultate << c->get_front()->get_ecp1()->get_name() << "-";
		rezultate << right << setw(33);
		rezultate << c->get_front()->get_ecp2()->get_name() << "\n";
		
		if(c->get_front()->get_ecp1()->get_experienta() > c->get_front()->get_ecp2()->get_experienta())
		{
			c->get_front()->get_ecp1()->add_points();
			(*w)->push(c->get_front()->get_ecp1());
			(*w_cpy)->push(c->get_front()->get_ecp1());
			(*l)->push(c->get_front()->get_ecp2());
		}
		else
		{
			c->get_front()->get_ecp2()->add_points();
			(*w)->push(c->get_front()->get_ecp2());
			(*w_cpy)->push(c->get_front()->get_ecp2());
			(*l)->push(c->get_front()->get_ecp1());
		}
		c->deQueue();
	}
	delete c;
	rezultate.close();
}

void afisare_castigatori(Stiva *w, int contor, char *argv[])
{
	ofstream rezultate(argv[3],ios::app);
	if(!rezultate)
	{
		cout << "Nu s-a putut deschide fisierul r.out!\n";
		exit(1);
	}
	rezultate << "\nWINNERS OF ROUND NO:" << contor << "\n";
	while(!w->isEmpty())
	{
		rezultate << left << setw(34);
		rezultate << w->get_top()->get_name() << "-";
		rezultate << fixed << setprecision(2) << "  " <<  w->get_top()->get_experienta() << "\n";
		w->pop();
	}
	delete w;
	rezultate.close();
}

void stergere_invinsi(Stiva *l)
{
	while(!l->isEmpty())
	{
		l->pop();
	}
	delete l;
}

void creare_cap(Echipa **cap, Stiva *w_cpy)
{
	Echipa *p = new Echipa(*w_cpy->get_top(),NULL);
	*cap = p;
	w_cpy->pop();
	while(!w_cpy->isEmpty())
	{
		Echipa *q = new Echipa(*w_cpy->get_top(),NULL);
		p->set_next(q);
		p = q;
		w_cpy->pop();
	}
}

void creare_arbori(Echipa *cap, Node **arbori)
{
	*arbori = new Node();
	Echipa *p = new Echipa(*cap,NULL);
	(*arbori)->set_head(p);
	cap = cap->get_next();
	
	while(cap != NULL)
	{
		Echipa *q = new Echipa(*cap,NULL);
		p->set_next(q);
		p = q;
		cap = cap->get_next();
	}
}

void creare_coada_stive(Node *first, Node **arbori, int nr_team, char *argv[])
{
	Echipa *cap = first->get_head();
	Coada *c;
	Stiva *w, *l, *w_cpy;
	int contor = 0;
	
	while(nr_team != 1)
	{
		contor++;
		creare_coada(&c,&cap);
		afis_coada_creare_stive(c,&w,&w_cpy,&l,contor,argv);
		creare_cap(&cap,w_cpy);
		if(nr_team/2 == 8)
		{
			creare_arbori(cap,arbori);
		}
		afisare_castigatori(w,contor,argv);
		stergere_invinsi(l);
		nr_team/=2;
	}
}

void BST_function(Node *arbori, BST **root,  char *argv[])
{
	BST *b = new BST;
	*root = NULL;
	Echipa *p = arbori->get_head();
	while(p != NULL)
	{
		*root = b->insert(*root,p);
		Echipa *q = p->get_next();
		delete p;
		p = q;
	}
	
	delete arbori;
	
	ofstream rezultate(argv[3], ios::app);
	if(!rezultate)
	{
		cout << "NU s-a putut deschide fisierul r.out!\n";
		exit(1);
	}
	rezultate << "\nTOP 8 TEAMS:\n";
	rezultate.close();
	b->inorder(*root,argv);	
	delete b;
} 

void creare_stiva(BST *root, Stiva *stiva_ech)
{
	if(!root)
	{
		return;
	}
	creare_stiva(root->get_right_BST(),stiva_ech);
	stiva_ech->push(root->get_ech());
	creare_stiva(root->get_left_BST(),stiva_ech);
}

void AVL_function(BST *root, char *argv[])
{
	AVL *a = new AVL;
	AVL *root_avl = NULL;

	Stiva *stiva_ech = new Stiva;
	creare_stiva(root,stiva_ech);
	//int i = 0;
	while(!stiva_ech->isEmpty())
	{
		//cout << stiva_ech->get_top()->get_name() <<" - "<< stiva_ech->get_top()->get_experienta() << endl;
		Echipa *e = new Echipa(*stiva_ech->get_top(),NULL);
		root_avl = a->insert(root_avl,e);
		stiva_ech->pop();
	}
	ofstream rezultate(argv[3], ios::app);
	if(!rezultate)
	{
		cout << "NU s-a putut deschide fisierul r.out!\n";
		exit(1);
	}
	rezultate << "\nTHE LEVEL 2 TEAMS ARE: \n";
	rezultate.close();
	//cout << "---------------\n";
	//cout << "root e:" << root_avl->get_ech()->get_name() << " - " << root_avl->get_height() << endl;
	//cout << "dreapta e: " << root_avl->get_right_AVL()->get_ech()->get_name() << " - " << root_avl->get_height() << endl;
	a->inorder(root_avl,argv);
	delete root;
	delete root_avl;
	delete a;
}

void Eliberare_memorie(Node **first)
{
	Echipa *e = (*first)->get_head();
	while(e != NULL)
	{
		Echipa *p = e->get_next();
		delete e;
		e = p;
	}
	
	delete *first;
}

