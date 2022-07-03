public class Ex4 {
    public static void main(String args[])
    {
        int[] array = {1, -6, 78, 45, 10, 99};
        System.out.print("\nElementele pare din vector sunt: ");
        for(int i = 0; i < array.length; i++)
        {
            if(array[i] % 2 == 0)
                System.out.print(array[i] + " ");
        }
        System.out.println("\n");
    }
}
