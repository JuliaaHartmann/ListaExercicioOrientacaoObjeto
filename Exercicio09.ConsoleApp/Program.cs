
/*Crie um programa para calcular a média harmônica das notas de um aluno
 MediaHarmonica = (4 / ((1 / nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4)));
*/

namespace Exercicio09.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a primeira nota do aluno: ");
        decimal nota1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota do aluno: ");
        decimal nota2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota do aluno: ");
        decimal nota3 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota do aluno: ");
        decimal nota4 = Convert.ToDecimal(Console.ReadLine());

        MediaHarmonica notaFinal = new MediaHarmonica(nota1, nota2, nota3, nota4);
        Console.WriteLine($"A média harmonica do aluno é: {notaFinal.CalcularMedia():F}");  

        Console.ReadLine();
    }
}