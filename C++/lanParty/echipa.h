#include "player.hpp"

class Echipa
{
	private: 
		int nr_players;
		string name;
		Player *vector;
		Echipa *next; 
	
	public:
		Echipa();
		Echipa(int, string, Player*,Echipa*);
		Echipa(const Echipa&,Echipa*);
		Echipa& operator = (const Echipa&);
		~Echipa();
		string get_name();
		int get_nr_players();
		double get_suma_puncte();
		void set_nrplayers(int);
		void set_name(const string&);
		void set_vector(string, string, int, int);
		double get_experienta();
		void add_points();
		void set_next(Echipa*);
		Echipa* get_next();
};
