#include "persons.h"

Persons::Persons(string name, string lastName, string date) {
    this->name = name;
    this->lastName = lastName;
    this->date = date;
}

string& Persons::getName() {
    return name;
}

string& Persons::getLastName() {
    return lastName;
}

string& Persons::getDate() {
    return date;
}