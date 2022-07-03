public class Ex3 {
    public static void main(String args[])
    {
        int[] array = {1, -6, 78, 45, 10, 99};
        int min = array[0], max = array[0], poz_min = 0, poz_max = 0;
        for(int i = 1; i < array.length; i++)
        {
            if(array[i] > max)
            {
                max = array[i];
                poz_max = i;
            }
            else
                if(array[i] < min)
                {
                    min = array[i];
                    poz_min = i;
                }
        }
        System.out.print("Pozitia pe care se afla elementul minim este " + poz_min + " iar pozitia pe care se afla elementul maxim este " + poz_max + ".\n");
    }
}
