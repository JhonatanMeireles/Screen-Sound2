namespace Forma;

internal class Retangulo : IForma
{
    public Retangulo(double comprimento, double largura)
    {
        Comprimento = comprimento;
        Largura = largura;
    }
    private double Comprimento {  get; }

    private double Largura {  get; }
    public void Calcular()
    {
        double a = Comprimento * Largura;
        Console.WriteLine($"A area do retangulo é {a}.");
    }
}
