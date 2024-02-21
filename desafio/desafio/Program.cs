//1. Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.

class ContaBancaria
{
    public int idConta;
    public string titular;
    public float saldo;
    public int senha;
}



//2. Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.

ContaBancaria conta = new ContaBancaria();
conta.titular = "Alice";
conta.idConta = 0001;
conta.saldo = 150.00;
conta.senha = 1234;

Console.WriteLine("Dados da conta:");
Console.WriteLine($"\nTitular: {conta.titular}");
Console.WriteLine($"Saldo atual: {conta.saldo}");




//3. Desenvolver um método da classe Conta que exibe suas informações.
public void ExibirInformações()
{
    Console.WriteLine("Dados da conta:");
    Console.WriteLine($"\nTitular: {this.titular}");
    Console.WriteLine($"Saldo atual: {this.saldo}");
}




//4. Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar

class Carro
{
    public string fabricante;
    public string modelo;
    public int ano;
    public int quantidadePortas;
    public int velocidade = 0;

    public void exibirInformacoes()
    {
        Console.WriteLine($"Infrmações do carro: {this.fabricante}, {this.modelo}, {this.quantidadePortas} portas, {this.ano}");
    }

    public acelerar()
    {
        Console.WriteLine("Acelerando...");
        if (velocidade < 100)
        {
            velocidade += 5;    
        }
    }

    public frear()
    {
        Console.WriteLine("Freando...");
        if (velocidade > 0)
        {
            velocidade -= 5;
        }
    }

    public buzinar()
    {
        Console.WriteLine("Bi Bi");
    }
}