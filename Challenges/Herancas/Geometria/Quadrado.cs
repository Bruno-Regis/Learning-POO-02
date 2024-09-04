
namespace DesafiosHeranca.Geometria;

internal class Quadrado : FormaGeometrica
{
    public double Lado { get; set; }

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override void CalculaArea()
    {
        base.CalculaArea();
        double area = Lado * Lado;
        Console.WriteLine($"A área do quadrado é: {area}");
    }

    public override void CalculaPerimetro()
    {
        base.CalculaPerimetro();
        double perimetro = 4 * Lado;
        Console.WriteLine($"O perímetro do quadrado é: {perimetro}");
    }
}
