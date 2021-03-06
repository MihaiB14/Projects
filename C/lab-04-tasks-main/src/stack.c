#include "utils.h"
#include "stack.h"
#include "stack_node.h"

/**
 * @brief Functie ce aloca dinamic memorie pentru stiva,
 *        initializand campurile head si size
 * 
 * @param stack - pointerul ce trebuie modificat pentru
 *                a tine adresa nou alocata pentru stiva
 */

void createStack(Stack **stack)
{
    //TODO1.1: functie ce aloca memorie pentru o stiva noua
    (*stack) = (Stack*)malloc(sizeof(Stack));
    (*stack)->head = NULL;
    (*stack)->size = 0;
}

/**
 * @brief Functie ce dealoca memoria pentru stiva
 * 
 * @param stack - stiva a carei elemente trebuie sterse
 */
void deleteStack(Stack *stack)
{
    // Nice to have
    while(!isEmptyStack(stack)) {
        char word = pop(stack);
    }
}

/**
 * @brief Functie ce adauga un nou nod in stiva
 * 
 *  * Hint:
 *          * a se citi cursul :)
 *          * se va modifica pointer-ul head al structurii Stack
 * 
 * @param stack - stiva in care se va adauga un nou nod
 * @param data - informatiile noului nod
 */
void push(Stack *stack, char data)
{
    //TODO1.3: functie ce adauga un nou nod in stiva
    stack_node *nodeToInsert = createStackNode(data);
    nodeToInsert->next = stack->head;
    stack->head = nodeToInsert;
    stack->size++;
}

/**
 * @brief Functie ce elimina urmatorul nod din stiva
 * 
 *  * Hint:
 *          * a se citi cursul :)
 *          * se va modifica pointer-ul head al structurii Stack
 * 
 * @param stack - stiva din care se va elimina nodul
 * @param data - informatiile noului scos
 */
char pop(Stack *stack)
{
    //TODO1.4: functie ce elimina urmatorul nod din stiva
    if(!isEmptyStack(stack)) {
        char data = stack->head->data;
        stack_node *nodeToDelete = stack->head;
        stack->head = stack->head->next;
        stack->size--;
        free(nodeToDelete);
        return data;
    }
    else {
        printf("Nu se mai pot sterge elemente din stiva!\n");
    }
}

/**
 * @brief Functie ce testeaza dimensiune stivei pentru a vedea daca este goala
 * 
 * @param stack - stiva ce va fi testata
 * @return true/false - rezultatul verificarii
 */
bool isEmptyStack(Stack *stack)
{
    //TODO1.5: Needed by the tests
    if(!stack->size)
        return true;
    return false;
}
