#include "Functii.h"

int main()
{
    Lista_circulara l1;
    cout << "Optiuni:\n-citire lista = 1\n-afisare lista prin eliminare = 2\n-afisare lista = 3\n-adaugare element = 4\n-eliminare element = 5\n-inversare legaturi lista = 6\n-adunare 2 liste = 7\n-iesite = 8\nCe doriti? ";
    int task;
    cin >> task;
    while(task != 8)
    {
        switch (task)
        {
            case 1:
            {
                cin >> l1;
                l1.afisare_k(0);
                break;
            }

            case 2:
            {
                cout << "Pozitia din care doriti sa se faca stergere: ";
                int poz;
                cin >> poz;
                if(poz >= 0 && poz < l1.get_nr())
                    l1.afisare_stergere(poz);
                else    
                    cout << "Pozitia este gresita!\n";
                break;
            }

            case 3:
            {
                l1.afisare_k(0);
                break;
            }

            case 4:
            {
                cout << "Valoare elementului pe care doriti sa-l adaugati: ";
                int val, poz;
                cin >> val;
                cout << "Pozitia: ";
                cin >> poz;
                if(poz >= 0 && poz < l1.get_nr())
                {
                    Nod *elem = new Nod(val);
                    l1.add(poz,elem);
                    l1.afisare_k(0);
                }
                else
                    cout << "Pozitia este gresita!\n";
                break;
            }

            case 5:
            {
                cout << "Pozitia elementului pe care dotiti sa-l stergeti: ";
                int poz;
                cin >> poz;
                if(poz >= 0 && poz < l1.get_nr())
                {
                    l1.delete_function(poz);
                    l1.afisare_k(0);
                }
                else
                    cout << "Pozitia este gresita!\n";
                break;
            }

            case 6:
            {
                l1.inversare();
                l1.afisare_k(0);
                break;
            }

            case 7:
            {
                if(l1.get_nr() == 0)
                    cout << "Prima lista este goala!\n";
                else
                {
                    cout << "Lista pe care doriti sa o adunati cu prima citita:\n";
                    Lista_circulara l2;
                    cin >> l2;
                    (l1 + l2).afisare_k(0);
                }
                break;
            }

            
            default:
                break;
        }
        cout << "\n";
        cout << "Optiuni:\n-citire lista = 1\n-afisare lista prin eliminare = 2\n-afisare lista = 3\n-adaugare element = 4\n-eliminare element = 5\n-inversare legaturi lista = 6\n-adunare 2 liste = 7\n-iesite = 8\nCe doriti? ";
        cin >> task;
    }

    cout << "\nO zi buna!\n";

    return 0;
}