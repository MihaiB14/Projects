//#include "SleepingBarber.c"
#include <stdio.h>
#include <stdlib.h>
//#include <time.h>
#include "queue.c"

// char* RandomName() {
//     srand(time(NULL));
//     int lineNumber = rand() % 11;
//     int count = 0;
    
//     FILE *file = fopen("nume.txt", "r");
//     if(!file) {
//         printf("Eroare deschidere fisier!\n");
//     }
//     char *line = (char*)malloc(10*sizeof(char));
//     while(fgets(line, 10, file) != NULL) {
//        if(lineNumber == count) {
//            fclose(file);
//            return line;
//        }
//        count ++;
//     }

//     return line;
// }

int main() {

    Queue *q = createQueue(5);
    int number;
    //printf("%s\n", RandomName(5));
    while(number != 4) 
    {
        printf("\nAdaugare - 1\nStergere - 2\nAfisare - 3\nIesire - 4\nNumarul: ");
        scanf("%d", &number);
        switch(number)
        {
            case 1: {
                if(isFull(q)) {
                    printf("Coada este plina!\n");
                    break;
                }
                printf("Valoare element de inserare: ");
                int val;
                scanf("%d", &val);
                push(q, val);
                printf("Valoare insearata cu succes!\n");
                break;
            }

            case 2: {
                printf("Valoarea eliminata este %d\n", pop(q));
                break;
            }

            case 3: {
                if(q->front == NULL) {
                    printf("Coada este goala!\n");
                    break;
                }
                Node *iter = q->front;
                printf("Coada are urmatoarele valori: ");
                while(iter != NULL) {
                    printf("%d ", iter->data);
                    iter = iter->next;
                }
                printf("\n");
                break;
            }

            default: {
                printf("O zi buna!\n");
                break;
            }
        }
    }
    return 0;
}