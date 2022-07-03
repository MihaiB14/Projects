#include "list.h"
#include "utils.h"



/**
 * @brief Functie ce creaza un nod prin alocare dinamica 
 * si returneaza pointerul nodului creat. 
 * 
 * @param number - numarul pe care il are copilul
 * @param name - numele copilului
 * @param next  - adresa urmatorului nod
 * @return childNode* - nou nod creat
 */
childNode *makeChildNode(int number, const char *name, childNode *next)
{
    //TODO3.1: primul pas in implementarea cerintei 3
    childNode *node = (childNode*)malloc(sizeof(childNode));
    node->number = number;
    node->next = next;
    node->name = (char*)malloc((strlen(name) + 1)*sizeof(char));
    strcpy(node->name, name);
    return node;
}




/**
 * @brief Functie ce returneaza o lista nou creata cu ajutorul
 * datelor citite din fisier-ul file primit ca parametru
 * 
 * Hint:
 *      * folositi-va de metoda makeChildNode pentru a crea lista
 *      * fscanf returneaza EOF in cazul in care se ajunge la
 *        sfarsitul fisierului => while(fscanf(...)!=EOF) va va 
 *        ajuta sa parcurgeti fisierul
 * 
 * @param file - fisierul ce trebuie citit
 * @return childNode* 
 */
childNode *makeCircularList(FILE *file)
{
    //TODO2.2: al doilea pas in implementarea cerintei 3
    int number;
    char name[20];
    fscanf(file, "%d%s", &number, name);
    childNode *listCap = makeChildNode(number, name, NULL);
    childNode *last = listCap;

    while(fscanf(file, "%d%s", &number, name) != EOF) {
        listCap = makeChildNode(number, name, listCap);
    }

    last->next = listCap;
    return listCap;
}


/**
 * @brief Functie ce 
 * 
 * @param head - capul listei ce reprezinta cercul de copii
 * @param p - pasul ce va fi luat pentru eliminarea copiilor
 * @return childNode* 
 */
childNode *playJosephGame(childNode *head, int p)
{
    // TODO3.3: se va return o lista creata prin adaugarea 
    // cu complexitatea O(1) a copiilor in ordinea in care 
    // sunt eliminati
    childNode *newList = NULL;
    childNode *iter = head;
    while(iter) {
        if(iter->next == iter) {
            newList = makeChildNode(iter->number, iter->name, newList);
            free(iter);
            head = NULL;
            break;
        }
        int number = 1;
        while(number < p - 1) {
            iter = iter->next;
            number++;
        }

        if(!newList) {
            newList = makeChildNode(iter->next->number, iter->next->name, NULL);
        }
        else {
            newList = makeChildNode(iter->next->number, iter->next->name, newList);
        }

        childNode *ceva = iter->next;
        if(ceva->next == head) {
            ceva->next = NULL;
            iter->next = head;
            free(ceva);
        }
        else if(ceva == head) {
            head = ceva->next;
            iter->next = head;
            ceva->next = NULL;
            free(ceva);
            }
            else {
                iter->next = ceva->next;
                ceva->next = NULL;
                free(ceva);
            }
        iter = iter->next;
    }
    
    return newList;
}