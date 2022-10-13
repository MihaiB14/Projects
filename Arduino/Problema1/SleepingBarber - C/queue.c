#include "queue.h"

int isEmpty(Queue* q)
{
    return (q->count==0);
} 

Queue* createQueue(int size)
{
    Queue *q = (Queue*)malloc(sizeof(Queue));
    if(q == NULL)
    {
        printf("Eroare alocare!\n");
        return NULL;
    }

    q->front = NULL;
    q->rear = NULL;
    q->dim = size;
    if(size == 0) {
        printf("Dimensiune 0 !!.\n");
    }
    q->count = 0;

    return q;
}

void push(Queue *q, int value)
{
    if(q->dim > q->count) {
        q->count++;
        Node *newNode = malloc(sizeof(Node));
        newNode->data = value;
        newNode->next = NULL;

        if(q->front == NULL)
        {
            q->front = newNode;
            q->rear = newNode;
        }
        else
        {
            (q->rear)->next = newNode;
            (q->rear) = newNode;
        }

        // if(q->front == NULL)
        // {
        //     q->front = q->rear;
        // }
    }
    else 
    {
        printf("Dimensiune maxima atinsa.\n");
    }
}

int pop(Queue *q)
{
    int data = INT_ERROR;
    if(q->count > 1) {
        q->count--;
        Node *aux;

        aux = q->front;
        data = aux->data;
        q->front = aux->next;
        aux->next = NULL;
        free(aux);
        aux = NULL;
    }
    else if(q->count == 1) 
    {
        q->count = 0;
        data = q->front->data;
        free(q->rear);
        q->front = q->rear = NULL;
    }
    else
    {
        printf("Coada este goala!\n");
    }
    return data;
}

void deleteQueue(Queue *q)
{
    while(!isEmpty(q))
    {
        pop(q);
    }
    free(q);
    q = NULL;
}

int isFull(Queue* q) {
    return (q->dim == q->count);
}