namespace DesafiosInterface.Armazenamento;

internal class Arquivo
{
    public string? NomeArquivo { get; set; }

    public void Salvar()
    {
        Console.WriteLine($"Salvando dados no arquivo {NomeArquivo}.");
    }

    public void Recuperar()
    {
        Console.WriteLine($"Recuperando dados do arquivo {NomeArquivo}.");
    }
}
