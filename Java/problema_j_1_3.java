//Doi jucatori dau cu 2 zaruri. Castiga jucatorul care da o dubla in cele mai putine aruncari. Aruncarea zarurilor se va realiza folosind clasa random si se contorizeaza nmumarul de aruncari pana la realizarea unei duble.
//Optional, daca se ating numaurul de aruncari ale primului jucator si jucatorul 2 nu a dat dubla, jocul se termina.
//Exemplu:
//-Jucatorul 1, aruncare 1: [3, 5]
//-Jucatorul 1, aruncare 2: [4, 6]
//-Jucatorul 1, aruncare 3: [2, 4]
//-Jucatorul 1, aruncare 4: [1, 6]
//-Jucatorul 1, aruncare 5: [5, 5]
//-Jucatorul 1 a dat o dubla din 5 aruncari.
//-Jucatorul 2, aruncare 1: [1, 5]
//-Jucatorul 2, aruncare 2: [2, 2]
//-Jucatorul 2 a dat o dubla din 2 aruncari.
//-Jucatorul 2 a castigat
//GAME OVER
public class problema_j_1_3
{
    public static void main(String args[])
    {
        int[] zaruri = new int[2];
        zaruri[0] = (int)Math.floor(Math.random()*(6 - 1 + 1) + 1);
        zaruri[1] = (int)Math.floor(Math.random()*(6 - 1 + 1) + 1);
        int aj1 = 1, aj2 = 1;
        System.out.println("- Jucatorul 1, aruncarea " + aj1 + " : [" + zaruri[0] + ", " + zaruri[1] + "]");
        while(zaruri[0] != zaruri[1])
        {
            zaruri[0] = (int)Math.floor(Math.random()*(6 - 1 + 1) + 1);
            zaruri[1] = (int)Math.floor(Math.random()*(6 - 1 + 1) + 1);
             aj1++;
            System.out.println("- Jucatorul 1, aruncarea " + aj1 + " : [" + zaruri[0] + ", " + zaruri[1] + "]");
        }
        System.out.print("- Jucatorul 1 a dat o dubla din ");
        if(aj1 > 1)
        {
            System.out.print(aj1 + " aruncari.\n");
        }
        else
        {
            System.out.print("o aruncare.\n");
        }
        //-------------------------------------------------------------------------------------------------------------------//
        zaruri[0] = (int)Math.floor(Math.random()*(6 - 1 + 1) + 1);
        zaruri[1] = (int)Math.floor(Math.random()*(6 - 1 + 1) + 1);
        System.out.println("- Jucatorul 2, aruncarea " + aj2 + " : [" + zaruri[0] + ", " + zaruri[1] + "]");
        while(zaruri[0] != zaruri[1])
        {
            //optional//
            
            if(aj2 == aj1)
            {
                System.out.println("- Jucatorul 1 a castigat.\nGAME OVER");
                return;
            }
            
            zaruri[0] = (int)Math.floor(Math.random()*(6 - 1 + 1) + 1);
            zaruri[1] = (int)Math.floor(Math.random()*(6 - 1 + 1) + 1);
             aj2++;
            System.out.println("- Jucatorul 2, aruncarea " + aj2 + " : [" + zaruri[0] + ", " + zaruri[1] + "]");
            
        }
        System.out.print("- Jucatorul 2 a dat o dubla din ");
        if(aj2 > 1)
        {
            System.out.print(aj2 + " aruncari.\n");
        }
        else
        {
            System.out.print("o aruncare.\n");
        }

        if(aj2 < aj1)
        {
            System.out.println("- Jucatorul 2 a castigat.");
        }
        else
        {
            System.out.println("- Cei 2 jucatori sunt la egalitate.");
        }
    
        System.out.println("GAME OVER");
    }
}
