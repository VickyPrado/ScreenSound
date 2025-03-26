// 5. Criar uma interface chamada IArmazenavel com métodos Salvar e Recuperar. Implemente essa interface em duas classes, Arquivo e BancoDeDados. Os métodos Salvar e Recuperar devem exibir mensagens simulando a ação de salvar e recuperar dados.

/*
internal interface IArmazenavel
{
    void Salvar();
    void Recuperar();
}

public class Arquivo : IArmazenavel
{
    public string NomeArquivo {  get; set; }

    public void Salvar()
    {
        Console.WriteLine($"Salvando dados no arquivo {NomeArquivo}");
    }

    public void Recuperar()
    {
        Console.WriteLine($"Recuperando dados do arquivo {NomeArquivo}");
    }
}

public class BancoDeDados : IArmazenavel
{
    public string NomeBanco { get; set; }

    public void Salvar()
    {
        Console.WriteLine($"Salvando dados no banco {NomeBanco}");
    }

    public void Recuperar()
    {
        Console.WriteLine($"Recuperando dados do banco {NomeBanco}");
    }
}
*/