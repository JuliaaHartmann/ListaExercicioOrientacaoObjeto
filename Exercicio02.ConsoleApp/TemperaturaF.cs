//Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius

namespace ListaExercicioOrientacaoObjeto.ConsoleApp;

class TemperaturaF
{
    public decimal temperaturaFahrenheit;

    public TemperaturaF(decimal fahrenheit)
    {
        temperaturaFahrenheit = fahrenheit;
    }

    public decimal ConverterParaCelsius()
    {
        return (temperaturaFahrenheit - 32) / 1.8m;        
    }
}
