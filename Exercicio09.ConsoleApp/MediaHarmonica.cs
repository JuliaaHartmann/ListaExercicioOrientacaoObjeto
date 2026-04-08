namespace Exercicio09.ConsoleApp;

class MediaHarmonica
{
    decimal nota1;
    decimal nota2;
    decimal nota3;
    decimal nota4;

    public MediaHarmonica(decimal _nota1, decimal _nota2, decimal _nota3, decimal _nota4)
    {
        nota1 = _nota1;
        nota2 = _nota2;
        nota3 = _nota3;
        nota4 = _nota4;
    }

    public decimal CalcularMedia()
    {
        decimal mediaHarmonica = 4 / ((1 / nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4));
        
        return  mediaHarmonica;
    }
}
