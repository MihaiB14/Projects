import org.mariuszgromada.math.mxparser.*;
public class Ex13 {
    public static void main(String args[])
    {
        Function f = new Function("f(x, y) = sqrt(sin(x))^2 + cos(y)^2");
        mXparser.consolePrintln("Rezultatul functiei f(x, y) = sqrt(sin(x))^2 + cos(y)^2 pentru f(1,2) - 10 este: " + (f.calculate(1,2)-10) + "\n");
    }
}
