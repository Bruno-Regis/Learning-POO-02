
namespace DesafiosInterface.Notificacao;

internal class Sms: Inotificavel
{
    public string? NumeroTelefone { get; set; }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Enviando SMS para {NumeroTelefone}: Notificação importante!");
    }
}
