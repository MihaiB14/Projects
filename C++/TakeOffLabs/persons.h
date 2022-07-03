#include <iostream>
#include <string>
#include <fstream>
#include <map>
#include <vector>
#include <bits/stdc++.h>
using namespace std;

// This class hold family name, last name and birthday date for a person
class Persons
{
    private:
        string name, lastName, date;
    public:
        // Just a constructor with parameters and 3 geters
        Persons(string, string, string);
        string& getName();
        string& getLastName();
        string& getDate();
};
