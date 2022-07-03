#include "list.h"
#include "utils.h"

/**
 * @brief Functie ce elimina elementele cu informatii duplicate
 * Hint:
 *      * parcurgeti lista si modificati nodurile a.i sa elimi-
 *        nati duplicatele
 *      * daca capul listei nu se modifica va trebuii 
 *        sa il returnati
 * 
 * @param list - capul listei ce trebuie sa fie procesata
 * @return node* - returneaza capul listei
 */
node *removeDuplicates(node *list)
{
    //TODO2: metoda ce realizeaza eliminarea de noduri duplicate
    node *iter = list;
    while(iter->next) {
        if(iter->data != iter->next->data) {
            iter = iter->next;
        }
        else {
            node *p = iter->next;
            iter->next = p->next;
            p->next = NULL;
            free(p);
        }
    }
    return list;
}
