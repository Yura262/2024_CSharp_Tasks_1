public delegate double CalcDelegate(double num1, double num2, char op);

public class CalcProgram
{
    public static double Calc(double num1, double num2, char op)
    {
        switch (op)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                return num2 != 0 ? num1 / num2 : 0;
            default:
                throw new ArgumentException("Invalid operator");
        }
    }

    public static CalcDelegate funcCalc = Calc;
}
