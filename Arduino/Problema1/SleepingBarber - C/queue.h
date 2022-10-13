#ifndef QUEUE_H
#define QUEUE_H

#include"multithreading.h"
#define INT_ERROR -404


typedef struct COZI{
    int data;
    struct COZI *next;
}Node;

typedef struct Q{
    Node *front, *rear;
    int dim;
    int count;
}Queue;

Queue* createQueue(int size);
int pop(Queue *q);
int isEmpty(Queue* q);
int isFull(Queue* q);
void deleteQueue(Queue *q);
void push(Queue *q, int value);

#endif