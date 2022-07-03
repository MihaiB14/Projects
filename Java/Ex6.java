public class Ex6 {
    public static void main(String args[])
    {
        int[] array = {1, -6, 78, 45, 10, 99};
        int suma = 0;
        int i = 0;
        do{
            if(array[i] %2 == 1)
            {
                suma += array[i];
            }
            i++;
        }while(i < array.length);
        System.out.println("Suma elementelor impare din vector este: " + suma + "\n");
    }
    
}
