using Xunit;

public class TesteNumeroPrimo
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
    public void VerificaSeEhPrimo_DeveRetornarResultadoCorreto(int numero, bool esperado)
    {
        bool resultado = EhPrimo(numero);

        Assert.Equal(esperado, resultado);
    }

    private bool EhPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        for (int i = 3; i * i <= numero; i += 2)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }
}
