#include "libs/list.h"
#include "libs/utils.h"


int main()
{
    FILE *f = fopen("data1.txt", "r");
    node *listCap = makeList(f);
    print(listCap);
}
