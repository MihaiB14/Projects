#include "persons.cpp"

// The function reads sequentially from the "persons.txt" file and creates an STL vector that contains Persons objects.
void readDate(vector<Persons> *personsVector) {
    ifstream f;
    f.open("persons.txt");
    int numberOfPersons;
    f >> numberOfPersons;
    for(int i = 0; i < numberOfPersons; i++) {
        string lastName, name, date;
        f >> lastName >> name >> date;
        (*personsVector).push_back(Persons(name, lastName, date));
    }
    f.close();
}

// The function writes in file "results.txt" the dates requested
void writeDate(vector<Persons> personsVector, multimap<int, int> mapWithNumerOfConsecutivePersons) {
    ofstream g;
    g.open("results.txt");
    
    // We know that the multimap is sorted ascending depending key, so we go through the map in opposite direction to write  first in file the family with maximum number of members 
    for(auto it = mapWithNumerOfConsecutivePersons.rbegin(); it != mapWithNumerOfConsecutivePersons.rend(); it++) {
        g << personsVector[it->second].getName() << ": ";
        for(int i = it->second; i < it->second + it->first; i++) {
            g << personsVector[i].getLastName() << " ";
        }
        g << endl;
    }

    g.close();
}

// The function return true if the family name of the object Persons p1 is "bigger"(alphabetical) then the family name of the object Persons p2
bool compareName(Persons p1, Persons p2) {
    if(p1.getName().compare(p2.getName()) < 0)
        return true;
    else    
        return false;
}

// This function is similar to function compareName() but compare field date of the objects Persons p1 and p2
bool compareDate(Persons p1, Persons p2) {
    if(p1.getDate().compare(p2.getDate()) < 0)
        return true;
    else    
        return false;
}

// This function create a multimap that has the key number of persons that have the same name, end the value is the position in vector where begin persons with that name
void consecutivePersons(vector<Persons> vectorOfPersons, multimap<int, int> *numberOfConsecutivePersons) {
    int number = 1, positionBegin = 0;
    for(int i = 0; i < vectorOfPersons.size() - 1; i++) {
        if(vectorOfPersons[i].getName() != vectorOfPersons[i + 1].getName()) {
            (*numberOfConsecutivePersons).insert(pair<int, int>(number, positionBegin));
            positionBegin = i + 1;
            number = 1;
        }
        else {
            number++;
        }
    }
    (*numberOfConsecutivePersons).insert(pair<int, int>(number, positionBegin));
}

// This function sort a vector with specified heads in ascending order using function compare Date() only we need to sort more than one element
void sortDate(vector<Persons> *vectorOfPersons, int positionBegin, int positionEnd) {
    if(positionEnd - positionBegin > 1) {
        sort((*vectorOfPersons).begin() + positionBegin, (*vectorOfPersons).begin() + positionEnd, compareDate);
    }
}

int main() {
    vector <Persons> personsVector;
    multimap<int, int> numberOfConsecutivePersons;

    readDate(&personsVector);
    // We sort the vector using function compareName
    sort(personsVector.begin(), personsVector.end(), compareName);
    consecutivePersons(personsVector, &numberOfConsecutivePersons);

    // We sort pieces of vector by field date, the heads are the value and key + value
    for(auto it = numberOfConsecutivePersons.begin(); it != numberOfConsecutivePersons.end(); it++) {
        sortDate(&personsVector, it->second, it->first + it->second);
    }

    writeDate(personsVector, numberOfConsecutivePersons);
    return 0;
}