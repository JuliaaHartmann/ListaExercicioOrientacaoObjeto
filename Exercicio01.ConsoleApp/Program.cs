
// Crie um programa para calcular o volume de uma caixa retangular

namespace Exercicio01.ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o comprimento da caixa: ");
        decimal comprimento = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a largura da caixa: ");
        decimal largura = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a altura da caixa: ");
        decimal altura = Convert.ToDecimal(Console.ReadLine());

        CaixaRetangular caixa = new CaixaRetangular(comprimento, largura, altura);
        Console.WriteLine($"O volume da caixa é: {caixa.CalcularVolume():F}");

        Console.ReadLine();
    }
}