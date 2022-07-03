#ifndef functie
	#define functie
	#include <iostream>
	#include <fstream>
	#include <algorithm>
	#include "avl.h"
	using namespace std;

	void citire_afisare(Node**, int&, char *argv[]);
	void stergere(Node**, int&, char *argv[]);
	void creare_coada_stive(Node*, Node** ,int, char *argv[]);
	void BST_function(Node*,BST **, char *argv[]); 
	void AVL_function(BST*, char *argv[]);
	void Eliberare_memorie(Node**);
#endif
