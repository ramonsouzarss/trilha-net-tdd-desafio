using Calculadora.Services;

namespace calculadoratestes;

public class CalculadoraTests
{
    
    public CalculadoraImp construiClasse()
    {
        string data = "19/10/2023";
        CalculadoraImp calc = new CalculadoraImp("19/10/2023");

        return calc;
    }
    
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSomar(int num1, int num2, int resultado)
    {
        CalculadoraImp calc = construiClasse();
        // Act
        int resultadoCalculadora = calc.Somar(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (3, 2, 1)]
    [InlineData (9, 5, 4)]
    public void TestSubtrair(int num1, int num2, int resultado)
    {
        CalculadoraImp calc = construiClasse();
        // Act
        int resultadoCalculadora = calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TestMultiplicar(int num1, int num2, int resultado)
    {
        CalculadoraImp calc = construiClasse();
        // Act
        int resultadoCalculadora = calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
    public void TestDividir(int num1, int num2, int resultado)
    {
        CalculadoraImp calc = construiClasse();
        // Act
        int resultadoCalculadora = calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        CalculadoraImp calc = construiClasse();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {
        CalculadoraImp calc = construiClasse();

        calc.Somar(1, 2);
        calc.Somar(3, 5);
        calc.Somar(8, 4);
        calc.Somar(9, 6);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}
