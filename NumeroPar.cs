using Xunit;

public class TesteNumeroPar
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    [InlineData(0, true)]
    [InlineData(-4, true)]
    public void VerificaSeEPar_RetornaResultadoEsperado(int numero, bool esperado)
    {
        bool resultado = numero % 2 == 0;

        Assert.Equal(esperado, resultado);
    }
}