
namespace DesafiosHeranca.Produtos;
internal class Laptop: Eletronicos
{
    public string? Processador { get; set; }
    public string? PlacaDeVideo { get; set; }
    public override string Informacoes()
    {
        return $"{base.Informacoes()}Tela: {Processador}\nPlaca de vídeo:{PlacaDeVideo}\n\nModelo:{Modelo}";
    }
}
