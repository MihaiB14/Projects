public class Ex2 {
    public static void main(String args[])
    {
        String[] materii = {"LPAI", "MCS", "PJSM", "MARV", "MSA"};
        for(int i = 0; i < materii.length; i++)
        {
            if(materii[i] == "PJSM")
            {
                System.out.println("Indexum materieri PJSM este " + i + "\n");
                break;
            }
        }
    }
}
