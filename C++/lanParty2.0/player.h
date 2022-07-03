#include <iostream>
#include <fstream>
#include <string>
#include <string.h>
#include <cstdlib>
#include <iomanip>
using namespace std;

class Player
{
private:
    string firstName;
    string secondName;
    int points;
    
public:
	Player();
	Player(string, string, int);
	Player& operator = (const Player&);
	void set_fname(string);
	void set_sname(string);
	void set_points(int);
	string& get_fname();
	string& get_sname();
	int& get_points();
};
