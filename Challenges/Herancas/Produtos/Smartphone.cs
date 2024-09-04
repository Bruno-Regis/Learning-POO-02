namespace DesafiosHeranca.Produtos;

internal class Smartphone: Eletronicos
{
    public string? Tela { get; set; }

    public override string Informacoes()
    {
        return $"{base.Informacoes()}Tela: {Tela}\nModelo:{Modelo}";
    }
}
