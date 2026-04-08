
// Crie um programa para calcular o volume de um Cilindro

namespace Exercicio03.ConsoleApp;

class TesteCilindro
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o raio do cilindro: ");
        int raio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a altura do cilindro: ");
        int altura = Convert.ToInt32(Console.ReadLine());

        Cilindro cilindro = new Cilindro(raio, altura);
        Console.WriteLine($"O volume do cilindro é: {cilindro.ObterVolume():F}");

        Console.ReadLine();
    }
}
