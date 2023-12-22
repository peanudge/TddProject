namespace Uqs.Arithmetic;

public class Division
{
    public static decimal Divide(int dividend, int divisor)
    {
        decimal quotient = dividend / divisor;
        Console.WriteLine($"{dividend} / {divisor} = {quotient}");
        return quotient;
    }
}
