#include "utils.h"
#include "counting.h"

//----- Counting Sort -----

/**
 * //TODO: Implementarea algoritmului counting sort
 * Restrictii: 0 <= arr[i] < 50
 * Dimensiunea vectorului de frecventa va fi 50
 * @param arr - vectorul care trebuie sortat
 * @param dim - dimensiunea vectorului
 * @return vectorul de frecventa utilizat in algoritm
 */
int* countingSort(int *arr, int dim)
{
    int *answer = (int*)malloc(50*sizeof(int));
    for(int i = 0; i < 50; i++) {
        answer[i] = 0;
    }

    for(int i = 0; i < dim; i++) {
        answer[arr[i]]++;
    }

    int k = 0;
    for(int i = 0; i < 50; i++) {
        if(answer[i]) {
            while(answer[i]) {
                arr[k] = i;
                k++;
                answer[i]--;
            }
        }
    }
    return arr;
}

/**
 * //TODO: Care este complexitatea spatiala si cea temporala?
 * De ce nu este mai folosit?
 */