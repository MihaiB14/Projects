/**
 * @file SleepingBarber.c
 * @author Spinu Andrei 333AC// Bălan Mihai 333AC// Ciobanu Stefan 333AC
 * @brief date de intrare: numarul de threaduri <T> si dimensiunea cozii de asteptare <Q>
 * @version 0.2
 * @date 2022-05-08
 * 
 * @copyright Copyright (c) 2022
 * 
 */

#include "SleepingBarber.h"

//mutex & semafor
pthread_mutex_t mutex_seats;
pthread_mutex_t mutex_enter;
sem_t sem_customers;
sem_t sem_barber;
struct timeval start, end;
int gata = 0;

void* customer(void *arguments){
    ARGUM argum = *(ARGUM *)arguments;
    struct timeval startCustomer, endCustomer;
    int timeCustomer = rand() % 4;
    gettimeofday(&startCustomer, NULL);
    while (!gata)
    {
        gettimeofday(&endCustomer, NULL);
        if(endCustomer.tv_sec - startCustomer.tv_sec >= timeCustomer) {
            pthread_mutex_lock(&mutex_enter);
            if ( !isFull(argum.Queue) && !gata) {
                printf("Ding! Ding! Clientul %s a intrat in sala. - %d\n", argum.nume, argum.ID);
                push(argum.Queue, argum.ID);
                sleep(2);
                sem_post(&sem_customers);
                pthread_mutex_unlock(&mutex_enter);
                sem_wait(&sem_barber);
            } else if(!gata){
                printf("Sala este plina, clientul %s pleaca. - %d\n", argum.nume, argum.ID);
                sleep(2);
                pthread_mutex_unlock(&mutex_enter);
            }
            else {
                pthread_mutex_unlock(&mutex_enter);
            }
            
            startCustomer = endCustomer;
            timeCustomer = rand() % 4;
        }  
    }
    pthread_exit(NULL);
    return NULL;
}

void* barber(void *arguments){
    ARGUM argum = *(ARGUM *)arguments;
    gettimeofday(&start, NULL);
    while (1)
    {
        sem_wait(&sem_customers);
        pthread_mutex_lock(&mutex_seats);
        sleep(3);
        printf("Barbierul a tuns un client - %d.\n", pop(argum.Queue));
       
        sem_post(&sem_barber);  
        pthread_mutex_unlock(&mutex_seats);
        gettimeofday(&end, NULL);
        if(end.tv_sec - start.tv_sec >= 20 && !gata) {
            gata = 1;
            printf("Programul de lucru s-a terminat, nu mai primim clienti!\n");
        }
        if(gata && isEmpty(argum.Queue)) {
            printf("Salonul s-a inchis, o zi buna!\n");
            break;
        }
    }
    pthread_exit(NULL);
    return NULL;
}


char* RandomName(int NUM_THREAD, int position) {
    srand(time(NULL));
    int lineNumber = (rand() + position) % (NUM_THREAD);
    int count = 0;
    
    FILE *file = fopen("nume.txt", "r");
    if(!file) {
        printf("Eroare deschidere fisier!\n");
    }
    char *line = (char*)malloc(10*sizeof(char));
    strcpy(line, "John");
    while(fscanf(file, "%s", line)) {
       if(lineNumber == count) {
           fclose(file);
           return line;
       }
       count ++;
    }

    return line;
}

int main(int argc, char** argv) {
    //Testare introducere date utilizator
    //Utilizatorul introduce <T> : numarul de threaduri pe care il va folosi programul
    //                           T-1 vor fi customers iar unul barber
    //                       <Q> : dimensiunea cozii de asteptare, echivalent cu
    //                             numarul de scaune din sala de asteptare

    if (argc < 3) {
		fprintf(stderr, "Usage:\n\t./tema1 <T> <Q>\n");
	return 0;
	}

    //citirea numarului de threaduri
    int NUM_THREAD = (int)strtol(argv[1], NULL, 10);
    
    if (NUM_THREAD < 2) {
        printf("Thread num > 2 !\n");
        return 0;
    }

    //citire dimensiunea cozii
    int NUM_QUEUE = (int)strtol(argv[2], NULL, 10);
    
    //Realizarea cozii
    Queue *queue = createQueue(NUM_QUEUE);

    //Initializarea threadueri
    pthread_t threads[NUM_THREAD + 1];
    pthread_mutex_init(&mutex_seats, NULL);
    pthread_mutex_init(&mutex_enter, NULL);
    sem_init(&sem_customers, 0, 0);
    sem_init(&sem_barber, 0, 0);

    //Alocarea argumentelor pentru threaduri
    ARGUM* arguments = (ARGUM*)malloc(sizeof(ARGUM) * (NUM_THREAD + 1));

    //Initializarea argumentelor
    for (int i = 0; i < NUM_THREAD; i++)
    {
        arguments[i].ID = i;
        arguments[i].Queue = queue;
        char *ceva = RandomName(NUM_THREAD, i);
        arguments[i].nume = (char*)malloc((strlen(ceva) + 1)*sizeof(char));
        strcpy(arguments[i].nume, ceva);
    }
    arguments[NUM_THREAD].ID = NUM_THREAD;
    arguments[NUM_THREAD].Queue = queue;
    arguments[NUM_THREAD].nume = (char*)malloc(10*sizeof(char));
    strcpy(arguments[NUM_THREAD].nume, "Cineva");

    //Creearea threadurilor customers
    for (int i = 0; i < NUM_THREAD; i++) {
        if( pthread_create(&threads[i], NULL, customer, (void *)&arguments[i]) != 0 ) {
            perror("Pthread create customers.");
            return EXIT_FAILURE;
        }
    }

    //Creearea threadului barber
    if( pthread_create(&threads[NUM_THREAD], NULL, barber, (void *)&arguments[NUM_THREAD]) != 0 ) {
        perror("Pthread create barber.");
        return EXIT_FAILURE;
    }

    //Unirea threadurilor
    for (int i = 0; i <= NUM_THREAD; i++) {
        if( pthread_join(threads[i], NULL) != 0 ) {
            perror("Pthread join.");
            return EXIT_FAILURE;
        } 
    }

    pthread_mutex_destroy(&mutex_seats);
    sem_destroy(&sem_customers);
    sem_destroy(&sem_barber);
    free(arguments);
    deleteQueue(queue);
    return 0;
}


