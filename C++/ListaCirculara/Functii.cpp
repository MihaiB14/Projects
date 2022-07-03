#include <iostream>
using namespace std;

class Nod
{
    private:
        int info;
        Nod *next;

    public:
        Nod();
        Nod(int);
        ~Nod();
        int get_info();
        Nod* get_next();
        void set_next(Nod*);
        void set_info(int);
};

Nod::Nod()
{
    info = 0;
    next = NULL;
}

Nod::Nod(int infor)
{
    info = infor;
    next = NULL;
}

Nod::~Nod()
{
    next = NULL;
}

int Nod::get_info()
{
    return info;
}

Nod* Nod::get_next()
{
    return next;
}

void Nod::set_info(int info)
{
    info = info;
}

void Nod::set_next(Nod* urm)
{
    next = urm;
}
//-------------------------------------------------------------------------///
class Lista_circulara
{
    private:
        Nod *prim;
        int nr;
    public:
        Lista_circulara();
        Lista_circulara(Nod*, int);
        Lista_circulara(const Lista_circulara&);
        ~Lista_circulara();
        void set_prim(Nod*);
        void set_nr(int);
        Nod* get_prim()const;
        int get_nr()const;
        void add(int, Nod*);
        friend istream& operator>>(istream&, Lista_circulara&);
        void afisare_k(int);
        void delete_function(int);
        void afisare_stergere(int);
        void inversare();
        Lista_circulara operator+(const Lista_circulara &);
};

Lista_circulara::Lista_circulara()
{
    prim = NULL;
    nr = 0;
}

Lista_circulara::Lista_circulara(Nod *p, int n)
{
    prim = p;
    nr = n;
}

Lista_circulara::Lista_circulara(const Lista_circulara &l)
{
    nr = l.nr;
    prim = l.prim;
}

Lista_circulara::~Lista_circulara()
{
    Nod *p = prim, *q;
    while(nr)
    {
        q = p;
        p = p->get_next();
        delete q;
        nr--;
    }
    prim = NULL;
}

void Lista_circulara::set_prim(Nod *p)
{
    prim = p;
}

void Lista_circulara::set_nr(int n)
{
    nr = n;
}

Nod* Lista_circulara::get_prim()const
{
    return prim;
}

int Lista_circulara::get_nr()const
{
    return nr;
}

void Lista_circulara::add(int poz, Nod *el)
{
    if(nr == 0)
    {
        prim = el;
        prim->set_next(prim);
        nr++;
    }
    else
        if(poz == 0)
        {
            Nod *i = prim;
            int j = 0;
            while(j != nr - 1)
            {
                j++;
                i = i->get_next();
            }
            i->set_next(el);
            el->set_next(prim);
            prim = el;
            nr++;
        }
        else
        {
            Nod *i = prim;
            int j = 0;
            while(j != poz - 1)
            {
                j++;
                i = i->get_next();
            }            

            el->set_next(i->get_next());
            i->set_next(el);
            nr++;
        }
}

istream& operator>>(istream &dev, Lista_circulara &l)
{
    cout << "Numar elemente: ";
    int numar;
    dev >> numar;

    for(int i = 0; i < numar; i++)
    {
        cout << "Element pozitie " << i << ": ";
        int val;
        dev >> val;
        Nod *el = new Nod(val);
        //Nod *el = new Nod;
        //el->set_info(val);
        l.add(i,el);            
    }
    return dev;
}

void Lista_circulara::afisare_k(int k)
{
    if(nr)
    {
        int i = 0;
        Nod *inc = prim;
        while(i != k)
        {
            i++;
            inc = inc->get_next();
        }
                
        i = nr + 1;
        cout << "Lista este: ";
        while(i != 0)
        {
            cout << inc->get_info() << " ";
            inc = inc->get_next();
            i--;
        }
        cout << "\n";
    }
    else
        cout << "Lista este goala!\n";
}

void Lista_circulara::delete_function(int poz)
{
    if(nr == 0)
    {
        cout << "Lista este goala si nu se pot extrage elemente!\n";
    }
    else
        if(nr == 1)
        {
            prim = NULL;
            nr = 0;
        }
        else
            if(poz == 0)
            {
                Nod *i = prim;
                int j = 0;
                while(j != nr - 1)
                {
                    i = i->get_next();
                    j++;
                }
                i->set_next(prim->get_next());
                prim->set_next(NULL);
                prim = i->get_next();
                nr--;
            }
            else
            {
                Nod *i = prim, *k;
                int j = 0;
                while(j != poz - 1)
                {
                    i = i->get_next();
                    j++;
                }
                k = i->get_next();
                i->set_next(k->get_next());
                k->set_next(NULL);
                nr--;
            }
}

void Lista_circulara::afisare_stergere(int k)
{
    if(nr)
    {
        int i = 0;
        Nod *inc = prim;
        while(i != k)
        {
            i++;
            inc = inc->get_next();
        }
                
        cout << "Lista este: ";
        int val = inc->get_info();
        while(nr != 0)
        {
            cout << inc->get_info() << " ";
            inc = inc->get_next();
            if(i == nr - 1 && nr != 1)
            {
                delete_function(i);
                i = 0;
            }
            else
                delete_function(i);
        }
        cout << val << "\n";
    }
    else
        cout << "Lista este goala!\n";
}

void Lista_circulara::inversare()
{
    if(nr == 0)
    {
        cout << "Lista este goala!\n";
    }
    else
    {
        int i = nr;
        Nod *current = prim, *prev = NULL, *next = NULL, *primul = NULL;

        next = current->get_next();
        current->set_next(prev);
        prev = current;
        current = next;
        primul = prev;
        i--;
        
        while(i)
        {
            next = current->get_next();
            current->set_next(prev);
            prev = current;
            current = next;
            i--;
        }
        primul->set_next(prev);
        prim = prev;
    }
}

Lista_circulara Lista_circulara::operator+(const Lista_circulara &l2)
{
    Nod *primul, *p = prim, *element_p = new Nod(prim->get_info()), *q;
    primul = element_p;
    q = primul;
    p = p->get_next();

    for(int i = 1; i < nr; i++)
    {
        Nod *el = new Nod(p->get_info());
        q->set_next(el);
        q = q->get_next();
        p = p->get_next();
    }

    p = l2.prim;
    for(int i = 0; i < l2.nr; i++)
    {
        Nod *el = new Nod(p->get_info());
        q->set_next(el);
        q = q->get_next();
        p = p->get_next();
    }
    q->set_next(primul);
    return Lista_circulara(primul,nr + l2.nr);
}
