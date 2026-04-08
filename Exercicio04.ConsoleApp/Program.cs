
// Calcular o consumo de combustível por Km

namespace Exercicio04.ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o KM inicial: ");
        decimal kmInicialUsuario = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite o KM final: ");
        decimal kmFinalUsuario = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite o consumo de combustível: ");
        decimal combustivelUsuario = Convert.ToDecimal(Console.ReadLine());

        Percurso combustivelPorKM = new Percurso(kmInicialUsuario, kmFinalUsuario, combustivelUsuario);
        Console.WriteLine($"O gasto de combustível foi de {combustivelPorKM.CalcularGasto():F}.");

        Console.ReadLine();
    }
}