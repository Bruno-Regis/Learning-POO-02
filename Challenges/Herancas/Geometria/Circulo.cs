
namespace DesafiosHeranca.Geometria;

internal class Circulo : FormaGeometrica
{
    public double Raio {  get; set; }
    public string Nome { get; }
    public Circulo(double raio)
    {
        Raio = raio;
        Nome = "Circulo";
    }

    public override void CalculaArea()
    {
        base.CalculaArea();
        double area = Math.PI * Raio * Raio;
        Console.WriteLine($"A área do {this.Nome} é: {area}");
    }

    public override void CalculaPerimetro()
    {
        base.CalculaPerimetro();
        double perimetro = 2* Math.PI* Raio;
        Console.WriteLine($"O perímetro do {this.Nome} é: {perimetro}");
    }
}
