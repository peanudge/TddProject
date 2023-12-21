namespace Uqs.Arithmetic.Tests.Unit;

public class DivisionTests
{
    [Fact]
    public void Divide_DivisibleIntegers_WholeNumber()
    {
        int dividend = 10;
        int divisor = 5;

        decimal expectedQuoteint = 2;

        decimal actualQuotient = Division.Divide(dividend, divisor);

        Assert.Equal(expectedQuoteint, actualQuotient);
    }
}
