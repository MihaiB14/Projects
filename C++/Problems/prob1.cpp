#include <iostream>
#include <fstream>
#include <string.h>
#include <vector>
using namespace std;

typedef struct list {
    char *mounth;
    int numberOfTemperatures;
    double *temperatures;
    struct list *next, *prev;
} list;

void readDate(list **head) {
    ifstream f;
    f.open("date.txt");
    list *prev;

    char *mounth = new char;
    f >> mounth;
    while(!f.eof()) { // cat timp nu am ajuns la finalul fisierului
        int numberTemperatures;
        f >> numberTemperatures;
        if(!*head) {
            *head = new list;
            (*head)->mounth = new char;
            strcpy((*head)->mounth, mounth);
            (*head)->numberOfTemperatures = numberTemperatures;
            (*head)->next = (*head)->prev = NULL;
            (*head)->temperatures = new double[numberTemperatures];
            for(int i = 0; i < numberTemperatures; i++) {
                f >> (*head)->temperatures[i];
            }
            prev = *head;
        }
        else {
            list *newItem = new list;
            newItem->mounth = new char;
            strcpy(newItem->mounth, mounth);
            newItem->numberOfTemperatures = numberTemperatures;
            newItem->temperatures = new double[numberTemperatures];
            for(int i = 0; i < numberTemperatures; i++) {
                f >> newItem->temperatures[i];
            }
            (*head)->prev = newItem;
            newItem->next = *head;
            newItem->prev = NULL;
            *head = newItem;
        }
        f >> mounth;
    }
    f.close();
}

void write(list *head) {
    list *it = head;
    while(it) {
        cout << " Luna: " << it->mounth << "\n Temperaturi: ";
        for(int i = 0; i < it->numberOfTemperatures; i++) {
            cout << it->temperatures[i] << " ";
        }
        cout << ";\n\n";
        it = it->next;
    }
}

bool chechTemperatures(double *temperature, int numberOfTeperatures,double minValue, double maxValue) {
    for(int i = 0; i < numberOfTeperatures; i++) {
        if(temperature[i] < minValue || temperature[i] > maxValue)
            return false;
    }
    return true;
}

void sort(vector<char*> *mounths) {
    int nrp = 1, ok;
    do
    {
        ok = 0;
        for(int i = 0; i < (*mounths).size() - nrp; i++) {
            if(strcmp((*mounths)[i], (*mounths)[i + 1]) > 0) {
                char *aux = new char;
                strcpy(aux, (*mounths)[i]);
                strcpy((*mounths)[i], (*mounths)[i + 1]);
                strcpy((*mounths)[i + 1], aux);
                ok = 1;
            }
        }
        nrp++;
    } while (ok);
    
}

void filterMounth(list *head, double minValue, double maxValue) {
    vector<char*> mounths;
    list *it = head;
    while(it) {
        if(chechTemperatures(it->temperatures, it->numberOfTemperatures, minValue, maxValue)) {
            mounths.push_back(it->mounth);
        }
        it = it->next;
    }

    cout << "Lunile care au temperaturi inregistrate in intervalul " << minValue << " - " << maxValue << ": ";
    if(mounths.empty()) {
        cout << "Nu exista :(\n";
    }
    else {
        sort(&mounths);
        for(auto it = mounths.begin(); it != mounths.end(); it++) {
            cout << *it << " ";
        }
        cout << ";\n";
    }
    
}

int main() {
    
    list *head = NULL;
    double minValue, maxValue;

    readDate(&head);
    write(head);

    cout << "Dati intervalul de temperaturi: ";
    cin >> minValue >> maxValue;

    filterMounth(head, minValue, maxValue);

    return 0;
}