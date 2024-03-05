//1. Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta,
//saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.

class Titular
{
    public string Nome {  get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }
}
class Conta
{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public string informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular {this.Titular.Nome},  Limite {Limite} - Saldo: {Saldo}";
}

//2. Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.


Titular t = new();
Conta c = new();

t.Nome = "Nix Vallery";
t.Cpf = "000.000.000-00";
t.Endereco = "Dawson,224 - Austin, California";

c.Titular = t;
c.Agencia=001;
c.NumeroDaConta = 44572;
c.Saldo = 150000.0;
c.Limite = 100000.0;

Console.WriteLine("Informações do Titular: ");
Console.WriteLine($"{c.Titular.Nome}");
Console.WriteLine($"{c.Titular.Cpf}");
Console.WriteLine($"{c.Titular.Endereco}");


//3. Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos,
//e exibir todos os produtos no estoque.



//4. Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe
//Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.



//5. Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser
//reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.