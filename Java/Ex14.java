import org.mariuszgromada.math.mxparser.*;
public class Ex14 {
    public static void main(String args[])
    {
        Expression e = new Expression("mean(1, 3, 5, 7, 9, 11, 13, 15, 17, 19)");
        mXparser.consolePrintln("Media este: " + e.calculate());

        Expression e1 = new Expression("std(1, 3, 5, 7, 9, 11, 13, 15, 17, 19)");
        mXparser.consolePrintln("Deviatia standard: " + e1.calculate() + "\n");
    }
}
