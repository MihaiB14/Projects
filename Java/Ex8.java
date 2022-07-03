public class Ex8 {

    public static class Bicycle
    {
        int cadence = 0;
        int speed = 0;
        int gear = 1;

        public void changeCadence(int newValue)
        {
            cadence = newValue;
        }
        public void changeGear(int newValue)
        {
            gear = newValue;
        }
        public void speedUp(int increment)
        {
            speed += increment;
        }
        public void applyBrackes(int decrement)
        {
            speed -= decrement;
        }
        public void printStates()
        {
            System.out.println("cadence: " + cadence + "\nspeed: " + speed + "\ngear: " + gear);
        }
    }

    public static class MountainBike extends Bicycle
    {
        String Firma= "";
        int Marime = 0;
        int Garantie = 0;

        public void set_firma(String newFirma)
        {
            Firma = newFirma;
        }

        public void set_marima(int newMarima)
        {
            Marime = newMarima;
        }

        public void set_Garantie(int newGarantie)
        {
            Garantie = newGarantie;
        }

        public void printStates()
        {
            super.printStates();
            System.out.println("Frima: " + Firma + "\nMarimea: " + Marime + "\nGarantie: " + Garantie + "\n");
        }
    }

    public static void main(String args[])
    {
        Bicycle b1 = new Bicycle();
        MountainBike b2 = new MountainBike();

        b1.changeCadence(14);
        b1.changeGear(5);
        b1.speedUp(6);
        b1.applyBrackes(2);
        b1.printStates();

        System.out.println();

        b2.changeCadence(20);
        b2.changeGear(3);
        b2.speedUp(7);
        b2.applyBrackes(4);
        b2.set_firma("Cube");
        b2.set_marima(42);
        b2.set_Garantie(3);
        b2.printStates();

    }
}
