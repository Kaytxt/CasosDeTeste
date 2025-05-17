using Xunit;

public class NumeroPrimoTest
{
    [Theory]
    [InlineData(2, true)]     
    [InlineData(3, true)]     
    [InlineData(4, false)]    
    [InlineData(5, true)]     
    [InlineData(9, false)]    
    [InlineData(13, true)]    
    [InlineData(15, false)]   
    [InlineData(1, false)]    
    public void IsPrime_Number_ReturnsCorrectResult(int number, bool expected)
    {
        bool result = IsPrime(number);

        Assert.Equal(expected, result);
    }

    private bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}