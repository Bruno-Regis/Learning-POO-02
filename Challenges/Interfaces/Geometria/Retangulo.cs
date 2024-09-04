
namespace DesafiosInterface;

internal class Retangulo : IForma
{
    public double Comprimento { get; set; }
    public double Largura { get; set; }

    public Retangulo(double lado, double largura)
    {
        Comprimento = lado;
        Largura = largura;
    }

    public double CalcularArea()
    {
        double area = Comprimento * Largura;
        return area;
    }

    public double CalcularPerimetro()
    {
        double perimetro = 2 * (Comprimento+Largura);
        return perimetro;
    }
}
