namespace Exercicio08.ConsoleApp;

class LataOleo
{
    int raio;
    int altura;

    public LataOleo(int _raio, int _altura)
    {
        raio = _raio;
        altura = _altura;
    }

    public double ObterVolume()
    {
        double volume = (Math.PI * raio) - (2 * altura);

        return volume;
    }
}
