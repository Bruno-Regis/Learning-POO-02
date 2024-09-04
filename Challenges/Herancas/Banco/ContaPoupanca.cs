namespace DesafiosHeranca.Banco;

internal class ContaPoupanca : ContaBancaria
{
    public double Rendimento { get; set; }

    
    public override double CalcularSaldo()
    {
        return base.CalcularSaldo() * (1 + Rendimento);
    }
}
