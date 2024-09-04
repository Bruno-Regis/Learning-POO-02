namespace DesafiosInterface.Armazenamento;

internal class BancoDeDados
{
    public string? NomeBanco { get; set; }

    public void Salvar()
    {
        Console.WriteLine($"Salvando dados no banco de dados {NomeBanco}.");
    }

    public void Recuperar()
    {
        Console.WriteLine($"Recuperando dados do banco de dados {NomeBanco}.");
    }
}
