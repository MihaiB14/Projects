import org.mariuszgromada.math.mxparser.*;
public class Ex15 {
    public static void main(String args[])
    {
        Expression e2 = new Expression("lcm(3, 9, 12, 2, 8, 6, 18)");
        mXparser.consolePrintln("CMMMC este: " + e2.calculate() + "\n");
    }
}
