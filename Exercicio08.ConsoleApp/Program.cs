
// Crie um programa para calcular o volume de uma lata de óleo

namespace Exercicio08.ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual o valor do raio? ");
        int raio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qual o valor da altura? ");
        int altura = Convert.ToInt32(Console.ReadLine());

        LataOleo volumeLata = new LataOleo (raio, altura);
        Console.WriteLine($"O volume da lata de óleo é de: {volumeLata.ObterVolume():F}");
        
        Console.ReadLine();
    }
}
