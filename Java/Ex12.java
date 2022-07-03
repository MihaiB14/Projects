public class Ex12 {
    public static void main(String args[])
    {
        double matrice[][] = new double[4][3];
        int unghi[] = {0, 45, 90, 180};

        for(int i = 0; i < matrice.length; i++)
        {
            matrice[i][0] =  Math.sin(Math.toRadians(unghi[i]));
            matrice[i][1] =  Math.cos(Math.toRadians(unghi[i]));
            matrice[i][2] =  Math.tan(Math.toRadians(unghi[i]));
        }

        System.out.println("Matricea este:");
        for(int j = 0; j < matrice.length; j++)
        {
            for(int k = 0; k < matrice[j].length; k++)
                System.out.print(matrice[j][k] + "\t");
            System.out.print("\n");
        }
        System.out.println("\n");
    }
}
