#include <iostream>
#include <string>
using namespace std;

int main() {

    string *text = new string("Trebuiesc inlocuite spatiile din textul asta cu '%20'.");
    string *textToReplace = new string("%20");
    
    while(true) {
        int found = text->find(' ');
        if(found != string::npos) {
            text->erase(found, 1);
            text->insert(found, *textToReplace);
        }
        else {
            break;
        }
    }
    cout << *text << "\n";

    delete text;
    delete textToReplace;

    return 0;
}