
namespace DesafiosHeranca.Produtos;

internal class Eletronicos
{
    public string? Modelo { get; set; }
    public double Preco { get; set; }

    public virtual string Informacoes()
    {
        return $"Modelo: {Modelo}\nPreco: {Preco:C}\n";
    }
}
