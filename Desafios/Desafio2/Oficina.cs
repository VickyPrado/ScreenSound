// 2. Modelar o funcionamento de uma oficina automobilistica.

/*
public class Veiculo
{
    public string Marca { get; set; };
    public string Modelo { get; set; };
    public int Ano { get; set; };
    public string Placa { get; set; };

    public Veiculo (string marca, string modelo, int ano, string placa)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Placa = placa;
    }
}

public class Cliente
{
    public string Nome { get; set; };
    public string Contato { get; set; };

    public Cliente (string nome, string contato)
    {
        Nome = nome;
        Contato = contato;
    }
}

public class Mecanico
{
    public string Nome { get; set; };
    public string Especialidade { get; set; };

    public Mecanico (string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
}

public class Oficina
{
    private List<Veiculo> veiculosNaOficina;

    public Oficina()
    {
        veiculosNaOficina = new List<Veiculo>();
    }

    public void AgendarServico(Veiculo veiculo, Cliente cliente, Mecanico mecanico, string dataAgendamento)
    {
        veiculosNaOficina.Add(veiculo);

        // Lógica para agendar o serviço (pode ser expandida conforme necessário)
        Console.WriteLine($"Serviço agendado para {veiculo.Placa} em {dataAgendamento} com o mecânico {mecanico.Nome}.");
    }

    public void RealizarServico(Veiculo veiculo, Mecanico mecanico)
    {
        if(veiculosNaOficina.Contains(veiculo))
        {
            Console.WriteLine($"Serviço realizado em {veiculo.Placa} pelo mecânico {mecanico.Nome}.");
            veiculosNaOficina.Remove(veiculo);
        }
        else
        {
            Console.Writeline($"O veiculo {veiculo.Placa} não está na oficina para realizar o serviço.");
        }
    }
}


// 3. Criar um programa Program.cs e simular o funcionamento do programa.

class Program
{
    static void Main()
    {
        // Criar instâncias de Veiculo, Cliente, Mecanico e Oficina
        Veiculo meuCarro = new Veiculo("Nissan", "Versa", 2025, "VSAX079");
        Cliente cliente = new Cliente("Dante", "966669999");
        Mecanico mecanico = new Mecanico("Lady", "977774444");
        Oficina oficina = new Oficina();

        // Agendar e realizar um serviço na oficina
        oficina.AgendarServico(meuCarro, cliente, mecanico, "27-03-2025");
        oficina.RealizarServico(meuCarro, mecanico);
    }
}
*/