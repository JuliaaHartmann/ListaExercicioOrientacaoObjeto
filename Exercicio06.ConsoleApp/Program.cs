
// Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

namespace Exercicio06.ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual a temperatura em celsius? ");
        decimal celsius = Convert.ToDecimal(Console.ReadLine());

        ConverterParaF temperaturaConvertida = new ConverterParaF(celsius);
        Console.WriteLine($"A temperatura {celsius} em Celsius, convertida em Fahrenheit é: {temperaturaConvertida.ConversorCelsiusParaF()}");

        Console.ReadLine();
    }
}
