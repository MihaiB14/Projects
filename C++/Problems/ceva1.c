#include <stdio.h>
#include <stdlib.h>
 
int main(void)
{
    int v[] = {5,3,5,3,2,3,5};
    int rez = 0;
    
    for(int i = 0; i < 7; i++) {
        rez = rez ^ v[i];
        printf("%d ", v[i]);
    }

    printf("\n%d\n", rez);

    return 0;
}