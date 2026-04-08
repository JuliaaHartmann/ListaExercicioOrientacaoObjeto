// Crie um programa para calcular o volume de um Cilindro

namespace Exercicio03.ConsoleApp;

class Cilindro
{
    public int raio;
    public int altura;

    public Cilindro(int _raio, int _altura)
    {
        raio = _raio;
        altura = _altura;
    }

    public double ObterVolume()
    {
        double areab = (Math.PI * raio * raio);

        double volume = (areab * altura);

        return volume;
    }
}
