
namespace DesafiosHeranca.Geometria;

internal class Triangulo : FormaGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public string Nome { get; }

    public Triangulo(double @base, double altura)
    {
        Base = @base;
        Altura = altura;
        Nome = "Triangulo genérico";
    }

    public override void CalculaArea()
    {
        base.CalculaArea();
        double area = 0.5 * Base * Altura;
        Console.WriteLine($"A área do quadrado é: {area}");
    }

    public override void CalculaPerimetro()
    {
        base.CalculaPerimetro();
        // Considerando um triângulo genérico
        double perimetro =  Base + Altura + Math.Sqrt(Base * Base + Altura * Altura);
        Console.WriteLine($"O perímetro do quadrado é: {perimetro}");
    }
}
