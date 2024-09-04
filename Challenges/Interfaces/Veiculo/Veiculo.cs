namespace DesafiosInterface.Veiculo;

internal class Veiculo : IVoavel, IPilotavel
{
    public void Voar()
    {
        Console.WriteLine("O veículo está voando");
    }

    public void Pilotar()
    {
        Console.WriteLine("O veículo está sendo pilotado");
    }

}
