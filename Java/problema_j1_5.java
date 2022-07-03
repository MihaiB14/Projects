//Cititi de la tastatura n si afisati primele n sume ale lui Gauss, cu tot cu valoarea lor. 
//Exemplu: n = 4
//1 = 1
//1 + 2 = 3
//1 + 2 + 3 = 6
//1 + 2 + 3 + 4 = 10
import java.util.Scanner;
public class problema_j1_5
{
    public static void main(String args[])
    {
        Scanner scan = new Scanner(System.in);
        System.out.print("Valoarea: ");
        int n = scan.nextInt();

        int i = 1;
        while(i <= n)
        {
            int suma = 0;
            for(int j = 1; j <= i; j++)
            {
                suma += j;
                System.out.print(j);
                if(j < i)
                    System.out.print(" + ");
                else   
                    System.out.print(" = ");
            }
            System.out.print(suma + "\n");
            i++;
        }
    }
}
