//Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius

namespace ListaExercicioOrientacaoObjeto.ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a temperatura em °F: ");
        decimal temperaturaFahrenheit = Convert.ToDecimal(Console.ReadLine());

        TemperaturaF temperaturaEmF = new TemperaturaF(temperaturaFahrenheit);
        Console.WriteLine($"A temperatura de {temperaturaEmF.temperaturaFahrenheit} °F corresponde a {temperaturaEmF.ConverterParaCelsius():F} °C.");

        Console.ReadLine();
    }
}