// 3. Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca. Utilize herança e o conceito de métodos virtuais para implementar um método CalcularSaldo que retorne o saldo atual da conta.

/*
class ContaBancaria
{
    protected double Saldo;

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        Saldo -= valor;
    }

    public virtual double CalcularSaldo()
    {
        return Saldo;
    }
}

class ContaCorrente : ContaBancaria
{
    private double Taxa;

    public override void Sacar(double valor)  
    {
        base.Sacar(valor + Taxa);
    }
}

class ContaPoupanca : ContaBancaria
{
    private double Rendimento;

    public override double CalcularSaldo()
    {
        return base.CalcularSaldo() * (1 + Rendimento);
    }

}
*/