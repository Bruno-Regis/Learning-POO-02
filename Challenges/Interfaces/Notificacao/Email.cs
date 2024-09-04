namespace DesafiosInterface.Notificacao;

internal class Email
{
    public string? EnderecoEmail { get; set; }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Enviando e-mail para {EnderecoEmail}: Notificação importante!");
    }
}
