namespace Exercicio06.ConsoleApp;

class ConverterParaF
{
    decimal celsius;

    public ConverterParaF(decimal _celsius)
    {
        celsius = _celsius;
    }

    public decimal ConversorCelsiusParaF()
    {
        decimal fahrenheit = celsius * 1.8m + 32;
        
        return fahrenheit;
    }
}
