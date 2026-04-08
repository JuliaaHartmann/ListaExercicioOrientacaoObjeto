// Crie um programa para calcular o volume de uma caixa retangular

namespace Exercicio01.ConsoleApp;

class CaixaRetangular
{
    decimal comprimento;
    decimal largura;
    decimal altura;

    public CaixaRetangular(decimal _comprimento, decimal _largura, decimal _altura)
    {
        comprimento = _comprimento;
        largura = _largura;
        altura = _altura;
    }
    public decimal CalcularVolume()
    {
        decimal volumeCaixa = comprimento * largura * altura;

        return volumeCaixa;
    }
}
