
/*
Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de vendas. 
A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.
*/

namespace Exercicio07.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o salário base: ");
        decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o total de vendas: ");
        decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o percentual da comissão(%): ");
        decimal percentualComissao = Convert.ToDecimal(Console.ReadLine());

        SalarioTotal salarioReceber = new SalarioTotal(salarioBase, totalVendas, percentualComissao);
        Console.WriteLine($"O salário total do vendedor é: R$ {salarioReceber.CalcularSalarioTotal():F2}");

        Console.ReadLine();
    }
}
