import java.util.Scanner; 

public class Ex7 {

    static class Automobil
    {
        Scanner scan = new Scanner(System.in);
        String tipMotor;
        String tractiune; 
        int putere;

        public Automobil()
        {
            tipMotor = "";
            tractiune = ""; 
            putere = 0;
        }

        void change_tipMotor(String newtipMotor)
        {
            tipMotor = newtipMotor;
        }

        void change_tractiune(String newtractiune)
        {
            tractiune = newtractiune;
        }

        void change_putere(int newputere)
        {
            putere = newputere;
        }

        void read_tipMotor()
        {
            System.out.print("Tip motor: ");
            tipMotor = scan.nextLine();
        }

        void read_tractiune()
        {
            System.out.print("Tractiune: ");
            tractiune = scan.nextLine();
        }

        void read_putere()
        {
            System.out.print("Putere: ");
            putere = scan.nextInt();
        }

        void afisare()
        {
            System.out.println("TipMotor: " + tipMotor + "\nTractiune: " + tractiune + "\nPutere: " + putere + "\n");
        }
    }

    public static void main(String args[])
    {
        Automobil a1 = new Automobil();
        Automobil a2 = new Automobil();
        a1.change_tipMotor("Diesel");
        a1.change_tractiune("Fata");
        a1.change_putere(136);
        System.out.println("Datele primului element de tip automobil:");
        a1.afisare();

        a2.read_tipMotor();
        a2.read_tractiune();
        a2.read_putere();
        System.out.println("\nDatele celui de al doilea element de tip automobil:");
        a2.afisare();
    }
}
