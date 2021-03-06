#include "functions.h"
#include "utils.h"

/**
 * @brief Functie ce testeaza daca cuvantul primit ca parametru este "stop"
 * 
 *  * Hint:
 *          * puteti folosi functia strcmp(...) pentru comparare de siruri de caractere
 * 
 * @param word cuvantul ce trebuie testat
 * @return true/false in functie de rezultatul comparatiei cu "stop" 
 */
bool isNotStop(const char *word)
{
    // Nice to have
    if(!strcmp(word, "stop"))
        return true;
    return false;
}

/**
 * @brief Functie ce citeste cuvant cu cuvant din fisierul primit ca parametru, adauga fiecare cuvant citit in coada
 *        pana la intalnirea cuvantului "stop"
 * 
 * * Hint:
 *      * se vor implementa mai intai functiile asociate stivei si cozi
 * 
 * @param queue - coada ce trebuie populata cu cuvinte
 * @param file - fisierul din care se face citirea
 */
void readInputIn(Queue *queue, FILE *file)
{
    // TODO3.1: Aceasta functie face parte din implementarea propriu zisa a cerintei
    char word[20];
    //createQueue(&queue);
    fscanf(file, "%s", word);
    while(!isNotStop(word)) {
        en(queue, word);
        fscanf(file, "%s", word);
    }
}

/**
 * @brief Functie ce parcurge coada de cuvinte, populeaza o stiva pentru inversarea cuvantului,
 *        dupa inversarea cuvantului continutul stivei este transferat in stiva results cu ajutorul
 *        operatiilor pop/push
 * * Hint:
 *      * se vor implementa mai intai functiile asociate stivei si cozi
 *      * detaliile de functioare se gasesc si in sectiunea HINTURI din README
 * 
 * @param queue - coada de cuvinte ce trebuie procesata
 * @param results - stiva ce contine rezultatul final al inversarii oridini cuvintelor
 */
void processInput(Queue *queue, Stack *results)
{
    // TODO3.2: Aceasta functie face parte din implementarea propriu zisa a cerintei.
    //createStack(&results);
    while(!isEmptyQueue(queue)) {
        char word[20];
        strcpy(word, de(queue)); 
        Stack *letters;
        createStack(&letters);
        for(int i = 0; i < strlen(word); i++) {
            push(letters, word[i]);
        }
        while(!isEmptyStack(letters)) {
            push(results, pop(letters));
        }
    }
}
