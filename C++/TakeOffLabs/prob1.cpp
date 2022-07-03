#include <iostream>
#include <fstream>
using namespace std;

void createMatrix(int ***matrix, int *n) {
    ifstream f;
    f.open("date.txt");
    f >> *n;
    *matrix = new int*[*n];
    for(int i = 0; i < *n; i++) {
        (*matrix)[i] = new int[*n];
    }

    for(int i = 0; i < *n; i++) {
        for(int j = 0; j < *n; j++) {
            f >> (*matrix)[i][j];
        }
    }
}

void showMatrix(int **matrix, int n) {
    for(int i = 0; i < n; i++) {
        for(int j = 0; j < n; j++) {
            cout << matrix[i][j] << " ";
        }
        cout << "\n";
    }
}

void rotateMatrix(int ***matrix, int n, int direction) {
    int lim1 = n - 1;
    switch(direction) {
        case 0: {
            for(int j = 0; j < n/2; j++) {
                for(int i = j; i < lim1; i++) {
                    int aux = (*matrix)[j][i];
                    (*matrix)[j][i] = (*matrix)[n - 1 - i][j];
                    (*matrix)[n - 1 - i][j] = (*matrix)[n - 1 - j][n - 1 - i];
                    (*matrix)[n - 1 - j][n - 1 - i] = (*matrix)[i][n - 1 - j];
                    (*matrix)[i][n - 1 - j] = aux;
                }
                lim1--;
            }
            break;
        }

        case 1: {
            for(int j = 0; j < n/2; j++) {
                for(int i = j; i < lim1; i++) {
                    int aux = (*matrix)[j][i];
                    (*matrix)[j][i] = (*matrix)[i][n - 1 - j];
                    (*matrix)[i][n - 1 - j] = (*matrix)[n - 1 - j][n - 1 - i];
                    (*matrix)[n - 1 - j][n - 1 - i] = (*matrix)[n - 1 - i][j];
                    (*matrix)[n - 1 - i][j] = aux;
                }
                lim1--;
            }
            break;
        }
    }
}

void eraseMatrix(int ***matrix, int n) {
    for(int i = 0; i < n; i++) {
        delete (*matrix)[i];
        (*matrix)[i] = NULL;
    }
    delete *matrix;
    *matrix = NULL;
}

int main() {
    
    int n, **matrix, direction;

    createMatrix(&matrix, &n);
    cout << "Matricea de rotit este:\n";
    showMatrix(matrix, n);

    cout << "In ce directie doriti sa rotiti matricea?(0 - dreapta, 1 - stanga): ";
    cin >> direction;
    rotateMatrix(&matrix, n, direction);
    
    cout << "Matricea rotita la ";
    if(!direction) {
        cout << "dreapta";
    }
    else {
        cout << "stanga";
    } 
    cout << " 90 de grade:\n";
    showMatrix(matrix, n);
    
    eraseMatrix(&matrix, n);
    
    return 0;
}