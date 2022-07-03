#include "tree.h"
#include "stack.h"
/**
 * CERINTA 1
* TODO: Implementarea functiei createBalanced descrisa in curs.
* @param N - numarul de noduri din arbore
* @param f - fisierul din care se vor citi valorile pentru nodurile arborelui
* Valorile sunt stocate in fisier sub forma: 1 2 3 4(pe un rand separate de un spatiu) 
*/
TreeNode* createBalanced(int N, FILE *f) {
    // TODO
    if(N > 0) {
        TreeNode *root = (TreeNode*)malloc(sizeof(TreeNode));
        fscanf(f, "%d", &root->val);

        root->left = createBalanced(N/2, f);
        root->right = createBalanced(N - 1 - N/2, f);
        return root;
    }
    else {
        return NULL;
    }
}

/**
 * CERINTA 2
 * TODO: implementarea ITERATIVA functiei de parcurgere SRD(inordine) a unui arbore binar.
 * Stiva este implementata folosind un vector(vezi stack.h). In functia inorderIterative, se transmite
 * radacina arborelui si un vector in care sa stocati valorile obtinute in urma parcurgerii precum si numarul
 * de elemente din arbore presupus cunoscut(cel de la cerinta 1).
 * @param root - nodul radacina al arborelui creat la cerinta anterioara cu functia createBalanced
 * @param arr - vector in care trebuie sa adaugati nodurile arborelui pe masura ce il parcurgeti
 * @param size - numarul de noduri din arbore.
 * HINT: Pentru implementare folositi-va de implementarea stivei, vedeti fisierul stack.h
 * OBSERVATIE: Odata parcurs un nod, acesta trebuie adaugat in vectorul arr. Trebuie adaugat tot nodul, NU valoarea.
 */
void inorderIterative(TreeNode* root, TreeNode **arr, int size) {
  // TODO
    *arr = (TreeNode*)malloc(size*sizeof(TreeNode));
    int poz = 0;
    Stack *S = createStack(size);
    while(1) {
        while(root) {
            push(S, root);
            root = root->left;
        }

        if(isEmpty(S))
            break;

        arr[poz] = peek(S);
        root = pop(S);
        root = root->right;
        poz++;
    }
}

/**
 * CERINTA 3
 * TODO: Implementarea functiei pentru eliberarea spatiului ocupat de un arbore.
 * @param root - radacina arborelui ce trebuie eliberat.
 */
void deleteTree(TreeNode* root) {
    // TODO
    // Metoda recursiva
    if(root) {
        deleteTree(root->left);
        deleteTree(root->right);
        free(root);
        root = NULL;    
    }
}

/**
 * CERINTA 4
 * TODO: Implementarea functiei pentru gasirea celui mai apropiat stramos comun(LCA) a doua noduri date(LCA)
 *  pentru doua noduri n1 si n2. LCA este cel mai adanc(de jos nod) care ii are pe n1 si n2 ca descendenti
 * @param root - nodul radacina al arborelui
 * @param n1 - nodul 1 pentru cautare LCA
 * @param n2 - nodul 2 pentru cautare LCA
 */ 
TreeNode* LCA(TreeNode* root, TreeNode* n1, TreeNode* n2) {
    // TODO 
    // Metoda iterativa:
    Stack *S1 = createStack(10);
    Stack *S2 = createStack(10);
    Stack *S1Results = createStack(10);
    Stack *S2Results = createStack(10);


    TreeNode *rootCopy = root;
    int ok = 1;
    while(1) {
        while(rootCopy) {
            if(rootCopy->val != n1->val) {
                push(S1, rootCopy);
                rootCopy = rootCopy->left;
            }
            else {
                ok = 0;
                break;
            }
        }
        if(!ok)
            break;
        rootCopy = pop(S1);
        if(!rootCopy->right) {
            if(peek(S1)->right == rootCopy) {
                pop(S1);
            }
            rootCopy = peek(S1);
            rootCopy = rootCopy->right;
        }
        else {
            rootCopy = rootCopy->right;
        }
    }

    ok = 1;
    rootCopy = root;
     while(1) {
        while(rootCopy) {
            if(rootCopy->val != n2->val) {
                push(S2, rootCopy);
                rootCopy = rootCopy->left;
            }
            else {
                ok = 0;
                break;
            }
        }
        if(!ok)
            break;
        rootCopy = pop(S2);
        if(!rootCopy->right) {
            if(peek(S2)->right == rootCopy) {
                pop(S2);
            }
            rootCopy = peek(S2);
            rootCopy = rootCopy->right;
        }
        else {
            rootCopy = rootCopy->right;
        }
    }
    
    while(!isEmpty(S1)) {
        push(S1Results, pop(S1));
    }

    while(!isEmpty(S2)) {
        push(S2Results, pop(S2));
    }
    
    while(!isEmpty(S1Results) && !isEmpty(S2Results)) {
        if(peek(S1Results)->val == peek(S2Results)->val) {
            rootCopy = pop(S1Results);
            pop(S2Results);
        }
        else {
            return rootCopy;
        }
    }

    return rootCopy;
}