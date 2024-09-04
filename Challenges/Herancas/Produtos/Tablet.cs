namespace DesafiosHeranca.Produtos;

internal class Tablet: Eletronicos 
{
    public string? Polegadas { get; set; }

    public override string Informacoes()
    {
        return $"{base.Informacoes()}Modelo: {Modelo}\nPolegadas:{Polegadas}";
    }
}
