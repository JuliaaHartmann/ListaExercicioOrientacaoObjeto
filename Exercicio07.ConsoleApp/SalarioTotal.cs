namespace Exercicio07.ConsoleApp;

class SalarioTotal
{
    decimal salarioBase;
    decimal totalVendas;
    decimal percentualComissao;

    public SalarioTotal(decimal _salarioBase, decimal _totalVendas, decimal _percentualComissao)
    {
        salarioBase = _salarioBase;
        totalVendas = _totalVendas;
        percentualComissao = _percentualComissao;
    }

    public decimal CalcularSalarioTotal()
    {
        decimal comissao = totalVendas * (percentualComissao / 100);
        decimal salarioTotal = salarioBase + comissao;

        return salarioTotal;
    }


}
