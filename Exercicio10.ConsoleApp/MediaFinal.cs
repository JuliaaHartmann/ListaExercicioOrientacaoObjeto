namespace Exercicio10.ConsoleApp;

class MediaFinal
{
    decimal nota1;
    decimal peso1;
    decimal nota2;
    decimal peso2;

    public MediaFinal(decimal _nota1, decimal _peso1, decimal _nota2, decimal _peso2)
    {
        nota1 = _nota1;
        peso1 = _peso1;
        nota2 = _nota2;
        peso2 = _peso2;
    }

    public decimal ObterMediaFinal()
    {
        decimal mediaFinal = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
        
        return mediaFinal;
    }
}