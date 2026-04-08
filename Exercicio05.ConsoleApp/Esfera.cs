namespace Exercicio05.ConsoleApp;

class Esfera
{
    double raio;

    public Esfera(double _raio)
    {
        raio = _raio;
    }

    public double VolumeEsfera()
    {
        double volumeEsfera = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
        
        return volumeEsfera;
    }
}