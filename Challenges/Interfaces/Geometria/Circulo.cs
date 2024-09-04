
namespace DesafiosInterface;

internal class Circulo : IForma
{
    public double Raio {  get; set; }
    public Circulo(double raio)
    {
        Raio = raio;
    }

    public double CalcularArea()
    {
        double area = Math.PI * Raio * Raio;
        return area;
    }

    public double CalcularPerimetro()
    {
        double perimetro = 2* Math.PI* Raio;
        return perimetro;
    }
}
