#include "player.hpp"

Player::Player():firstName(string()), secondName(string()), points(0){};

Player::Player(string nume, string prenume, int puncte)
{
	firstName = nume;
	secondName = prenume;
	points = puncte;
}

Player& Player::operator =(const Player &p)
{
	if(this != &p)
	{
		firstName = p.firstName;
		secondName = p.secondName;
		points = p.points;
	}
	return *this;
}

void Player::set_fname(string n)
{
	firstName = n;
}

void Player::set_sname(string p)
{
	secondName = p;
}

void Player::set_points(int p)
{
	points = p;
}


string& Player::get_fname()
{
	return firstName;
}

string& Player::get_sname()
{
	return secondName;
}

int& Player::get_points()
{
	return points;
}
