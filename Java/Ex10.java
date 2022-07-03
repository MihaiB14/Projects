import java.util.Scanner;
public class Ex10 {
    public static void main(String args[])
    {
        Scanner scan = new Scanner(System.in);
        char sir_caractere[];
        System.out.print("Numarul de elemente ale sirului de caractere: ");
        int n = scan.nextInt();

        sir_caractere = new char[n];
        for(int i = 0; i < sir_caractere.length; i++)
        {
            System.out.print("elementul de pe pozitie " + i + " : ");
            sir_caractere[i] = scan.next().charAt(0);
        }
        System.out.print("Sirul citit este: ");
        for(int i = 0; i < sir_caractere.length; i++)
            System.out.print(Character.toString(sir_caractere[i]));
        System.out.println("\n");
    }
}
