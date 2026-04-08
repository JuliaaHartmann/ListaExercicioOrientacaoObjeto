namespace Exercicio04.ConsoleApp;

class Percurso
{
    decimal kmInicial;
    decimal kmFinal;
    decimal combustivel;

    public Percurso(decimal _kmInicial, decimal _kmFinal, decimal _combustivel)
    {
        kmInicial = _kmInicial;
        kmFinal = _kmFinal;
        combustivel = _combustivel;
    }
    public decimal CalcularGasto()
    {
        decimal distanciaPercorrida = kmFinal - kmInicial;

        decimal gastoCombustivel = combustivel / distanciaPercorrida;

        return gastoCombustivel;
    }

}
