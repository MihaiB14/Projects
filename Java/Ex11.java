public class Ex11 {
    public static void main(String args[])
    {
        int[] array = new int[6];
        for(int i = 0; i < array.length; i++)
            array[i] = (int)(Math.random()*100);
    
        for(int i = 0; i < array.length; i++)
            System.out.print(array[i] + " ");

        int min = array[0];
        int max = array[0];

        for(int i = 1; i < array.length; i++)
        {
            if(Math.min(min, array[i]) != min)
            {
                min = array[i];
            }
            else
            {
                if(Math.max(max, array[i]) != max)
                {
                    max = array[i];
                }
            }
        }
        System.out.println("\nValoarea minima este " + min + " iar valoarea maxima este " + max + "\n");
    }
}
