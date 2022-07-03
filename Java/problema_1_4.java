//Se citeste de la tastatura un numar n (cel putin egal cu 1000) si se afiseaza ce fatori primi are in descompunere, care apar la putere mai mare decat 1. Se afiseaza apoi numarul liber
//de patrate rezultat, adica compus din factorii primi ai lui n, fiecare la puterea 1.
//Exemplu: 1000 -> se afiseaza: 1000 are factorul 2 la puterea 3 si factorul 5 la puterea 3. Numarul liber de patrate rezultat este 2 * 5 * 7 = 70.
import java.util.*;
public class problema_1_4 
{
    public static void main(String args[])
    {
        Scanner scan = new Scanner(System.in);
        System.out.print("Numarul > 1000: ");
        int n = scan.nextInt();
        int m = n;

        int i = 2, index = 0;
        List<Integer> P = new ArrayList<>();
        List<Integer> p = new ArrayList<>();
        while(n != 1)
        {
            int nr = 0;
            while(n%i == 0)
            {
                n = n/i;
                nr++;
            }
            if(nr != 0)
            {
                P.add(i);
                p.add(nr);
                index++;
            }
            i++;
        }

       System.out.print(m + " are factorul ");
       for(int j = 0; j < P.size(); j++)
       {
           if(p.get(j) > 1)
           {
                if(j == 0)
                    System.out.print(P.get(j) + " la puterea " + p.get(j));
                else
                    System.out.print(" si " + P.get(j) + " la puterea " + p.get(j));
       
            }
        }
        System.out.print(". Numarul liber de patrate rezultat este ");
        int prod = 1;
        for(int j = 0; j < P.size(); j++)
        {
            prod *= P.get(j);
            if(j != P.size() - 1)
                System.out.print(P.get(j) + " * ");
            else    
                System.out.print(P.get(j) + " = ");
        }

        System.out.print(prod + ".\n");
    }
}
