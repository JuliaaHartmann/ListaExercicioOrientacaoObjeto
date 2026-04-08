
// Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

namespace Exercicio10.ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a primeira nota: ");
        decimal nota1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o peso da primeira nota: ");
        decimal peso1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        decimal nota2 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o peso da segundaa nota: ");
        decimal peso2 = Convert.ToDecimal(Console.ReadLine());

        MediaFinal notaGeralAluno = new MediaFinal(nota1, peso1, nota2, peso2);
        Console.WriteLine($"A média ponderada do aluno é: {notaGeralAluno.ObterMediaFinal():F}");
        
        Console.ReadLine();
    }
}
