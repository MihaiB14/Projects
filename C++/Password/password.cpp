#include <cstdio>
#include <vector>
#include <algorithm>
#include <cmath>
#include <string.h>
#include <iostream>

using namespace std;

class Policy
{
    protected:
      bool isChecked;
    public:
      virtual void check(const string&) = 0;
      virtual ~Policy(){};
      bool getCheck()const{return isChecked;};
};

class LengthPolicy: public Policy
{
    private:
        unsigned short minLength;
        unsigned short maxLength;
    public:
        ~LengthPolicy(){};
        LengthPolicy(unsigned short minim)
        {
            minLength = minim;
            maxLength = 255;
        }
        LengthPolicy(unsigned short minim, unsigned short maxim)
        {
            minLength = minim;
            maxLength = maxim;
        }
        void check(const string &parola)
        {
            if(parola.size() >= minLength && parola.size() <= maxLength)
                Policy::isChecked = true;
            else
                Policy::isChecked = false;
        }
};

class ClassPolicy: public Policy
{
    private:
        unsigned short minClassCount;
    public:
        ~ClassPolicy(){};
        ClassPolicy(unsigned short element)
        {
            minClassCount = element;
        }
        void check(const string &parola)
        {
           int nr = 0;
           size_t lm = parola.find_first_of("abcdefghijklmnopqrstuvwxyz");
           size_t lM = parola.find_first_of("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
           size_t c = parola.find_first_of("0123456789");
           size_t s = parola.find_first_of("~!@#$%^&*()_+={}[]:"";'<>?,./");
           
           if(lm != string::npos)nr++;
           if(lM != string::npos)nr++;
           if(c != string::npos)nr++;
           if(s != string::npos)nr++;
           
           if(nr >= minClassCount)
                Policy::isChecked = true;
            else
                 Policy::isChecked = false;
        }
};

class IncludePolicy:public Policy
{
    private: 
        char characterType;
    public:
        ~IncludePolicy(){};
        IncludePolicy(char a)
        {
            characterType = a;
        }
        void check(const string &parola)
        {
            int ok = 0;
            if(characterType >= 'a' && characterType <= 'z')
            {
                size_t lm = parola.find_first_of("abcdefghijklmnopqrstuvwxyz");
                if(lm != string::npos)
                    ok++;
            }
            else
                if(characterType >= 'A' && characterType <= 'Z')
                {
                    size_t lM = parola.find_first_of("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                    if(lM != string::npos)
                        ok++;
                }
                else
                    if(characterType >= '0' && characterType <= '9')
                    {
                        size_t c = parola.find_first_of("0123456789");
                        if(c != string::npos)
                            ok++;
                    }
                    else
                    {
                        size_t s = parola.find_first_of("~!@#$%^&*()_+={}[]:"";'<>?,./");
                        if(s != string::npos)
                            ok++;
                    }
            
            if(ok)
                Policy::isChecked = true;
            else
                 Policy::isChecked = false;
        }
};

class NotIncludePolicy:public Policy
{
    private: 
        char characterType;
    public:
        ~NotIncludePolicy(){};
        NotIncludePolicy(char a)
        {
            characterType = a;
        }
        void check(const string &parola)
        {
            int ok = 0;
            if(characterType >= 'a' && characterType <= 'z')
            {
                size_t lm = parola.find_first_of("abcdefghijklmnopqrstuvwxyz");
                if(lm == string::npos)
                    ok++;
            }
            else
                if(characterType >= 'A' && characterType <= 'Z')
                {
                    size_t lM = parola.find_first_of("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                    if(lM == string::npos)
                        ok++;
                }
                else
                    if(characterType >= '0' && characterType <= '9')
                    {
                        size_t c = parola.find_first_of("0123456789");
                        if(c == string::npos)
                            ok++;
                    }
                    else
                    {
                        size_t s = parola.find_first_of("~!@#$%^&*()_+={}[]:"";'<>?,./");
                        if(s == string::npos)
                            ok++;
                    }
            
            if(ok)
                Policy::isChecked = true;
            else
                 Policy::isChecked = false;
        }  
};

class RepetitionPolicy: public Policy
{
    private:
        unsigned short maxCount;
    public:
        ~RepetitionPolicy(){};
        RepetitionPolicy(unsigned short max)
        {
            maxCount = max;
        }
        void check(const string &parola)
        {
            string copie = parola;
            sort(copie.begin(),copie.end());
            int i = 0, nr = 1;
            while( i < copie.size())
            {
                if(copie[i] == copie[i+1])
                    nr++;
                else
                {
                    if(nr > maxCount)
                    {
                        Policy::isChecked = false;
                        break;
                    }
                    nr = 1;
                }
                i++;
            }
            if(nr <= maxCount)
                Policy::isChecked = true;
            else
                 Policy::isChecked = false;
        }
};

class ConsecutivePolicy: public Policy
{
    private:
        unsigned short maxCount;
    public:
        ~ConsecutivePolicy(){};
        ConsecutivePolicy(unsigned short max):maxCount(max){};
        void check(const string &parola)
        {
            int i = 0, nr = 1;
            while(i < parola.size())
            {
                if(parola[i+1] - parola[i] == 1)
                    nr++;
                else
                {
                    if(nr > maxCount)
                    {
                        Policy::isChecked = false;
                        break;
                    }
                    nr = 1;
                }
                i++;
            }
            if(nr <= maxCount)
                Policy::isChecked = true;
            else
                 Policy::isChecked = false;
        }
};

string checkPassword(string parola, vector<Policy*> vec)
{
    string verdict = "OK";
    for(int i = 0; i < vec.size(); i++)
    {
        
        vec[i]->check(parola);
        if(!vec[i]->getCheck())
        {
            verdict = "NOK";
            break;
        }
    }
    return verdict;
}

int main(int argc, char* argv[])
{
    vector<string> parole;
    vector<Policy*> vec;

    int n;
    char s;
    cin >> n;
    s = getchar();

    for(int i = 0; i < n; i++)
    {
        char *conditie = new char;
        cin.getline(conditie,20,'\n');
        string c = (string)conditie;
        
        if(c.find("length") != string::npos)
        {
            string poz, poz1, poz2;
            int min, max = 255;
            poz.append(c,c.find(' ')+1,7);
            if(poz.find(' ') == string::npos)
            {
                cout << "sirul este " << poz << endl;
                min = stoi(poz);
                vec.push_back(new LengthPolicy(min));
            }
            else
            {
                int pozitia = poz.find(' ');
                poz1.append(poz,0,pozitia);
                min = stoi(poz1);
                poz2.append(poz,pozitia+1,4);
                max = stoi(poz2);
                vec.push_back(new LengthPolicy(min,max));
            }
        }
            
        if(c.find("include") != string::npos && c.find("ninclude") == string::npos)
        {
            string poz;
            char caracter = c[c.find(' ')+1];
            vec.push_back(new IncludePolicy(caracter));
        }
        
        if(c.find("ninclude") != string::npos)
        {
            string poz;
            char caracter = c[c.find(' ')+1];
            vec.push_back(new NotIncludePolicy(caracter));
        }
        
        if(c.find("repetition") != string::npos)
        {
            string poz;
            poz.append(c,c.find(' ')+1,1);
            int nr = stoi(poz);
            vec.push_back(new RepetitionPolicy(nr));
        }
        
        if(c.find("consecutive") != string::npos)
        {
            string poz;
            poz.append(c,c.find(' ')+1,1);
            int nr = stoi(poz);
            vec.push_back(new ConsecutivePolicy(nr));
        }
        
        if(c.find("class") != string::npos)
        {
            string poz;
            poz.append(c,c.find(' ')+1,1);
            int nr = stoi(poz);
            vec.push_back(new ClassPolicy(nr)); 
        }
        cin.clear();
        c.clear();
    }
    
    string p;
    
    while(cin >> p)
    {
        string verdict = checkPassword(p,vec);
        cout << verdict << endl;
        cin.clear();
    }
    
    return 0;
}
