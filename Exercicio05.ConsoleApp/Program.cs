
//Crie um programa para calcular o volume de uma esfera

namespace Exercicio05.ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual o tamanho do raio? ");
        double raio = Convert.ToDouble(Console.ReadLine());

        Esfera novaEsfera = new Esfera(raio);
        Console.WriteLine($"O volume da esfera é: {novaEsfera.VolumeEsfera():F}");

        Console.ReadLine();
    }
}
