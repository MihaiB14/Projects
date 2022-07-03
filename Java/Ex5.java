public class Ex5 {
    public static void main(String args[])
    {
        int[] array = {1, -6, 78, 45, 10, 99};
        int suma = 0;
        int i = 0;
        while(i < array.length)
        {
            suma += array[i];
            i++;
        }
        System.out.println("Suma elementelor vectorului este: " + suma + "\n");
    }
}
