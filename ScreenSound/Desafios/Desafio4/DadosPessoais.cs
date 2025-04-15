//1. Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail), serializa essas informações em formato JSON e salva em um arquivo.

/*
namespace ScreenSound.Desafio4;
using System.Text.Json;

public class DadosPessoais
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine()!);
        Console.Write("Digite seu e-mail: ");
        string email = Console.ReadLine()!;
        DadosPessoais dadosPessoais = new DadosPessoais
        {
            Nome = nome,
            Idade = idade,
            Email = email
        };
        string json = JsonSerializer.Serialize(dadosPessoais);
        File.WriteAllText($"dados_pessoais_{nome}.json", json);
        string caminhoArquivo = Path.GetFullPath($"dados_pessoais_{nome}.json");
        Console.WriteLine($"Arquivo JSON criado com sucesso! Caminho: {caminhoArquivo}");
    }
}
*/




//2. Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas informações e exibe na tela.

/*
class Program
{
    static void Main(string[] args)
    {
        string caminhoArquivo = "dados_pessoais.json";

        if (File.Exists(caminhoArquivo))
        {
            string json = File.ReadAllText(caminhoArquivo);
            DadosPessoais dadosPessoais = JsonSerializer.Deserialize<DadosPessoais>(json)!;

            Console.WriteLine($"Nome: {dadosPessoais.Nome}, Idade: {dadosPessoais.Idade}, E-mail: {dadosPessoais.Email}");            
        }
    }
}
*/





//3. Criar um programa que permite ao usuário inserir informações de várias pessoas, armazena essas informações em uma lista, serializa a lista em formato JSON e salva em um arquivo.

/*
class Program
{
    static void Main()
    {        
        List<DadosPessoais> dadosPessoais = new List<DadosPessoais>();
        
        while (true)
        {
            DadosPessoais dadosPessoais = new DadosPessoais();
            Console.Write("Digite o nome (ou 'sair' para encerrar): ");
            string nome = Console.ReadLine();

            if (nome.ToLower() == "sair")
                break;

            dadosPessoais.Nome = nome;

            Console.Write("Digite a idade: ");
            dadosPessoais.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o e-mail: ");
            dadosPessoais.Email = Console.ReadLine();
            
            dadosPessoais.Add(dadosPessoais);
        }
        
        string jsonString = JsonSerializer.Serialize(dadosPessoais);
       
        string fileName = "pessoas.json";
        
        File.WriteAllText(fileName, jsonString);

        Console.WriteLine($"Os dados foram salvos em {fileName}");
    }
}
*/




//4.Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, desserializa essas informações em uma lista e exibe na tela.

/*
class Program
{
    static void Main()
    {        
        string fileName = "pessoas.json";
        
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            List<DadosPessoais> dadosPessoais = JsonSerializer.Deserialize<List<DadosPessoais>>(json)!;
            Console.WriteLine("Exibindo informações pessoais");

            foreach (var dadosPessoais in DadosPessoais)
            {
                Console.WriteLine($"Nome: {dadosPessoais.Nome}, Idade: {dadosPessoais.Idade}, E-mail: {dadosPessoais.Email}");
            }
        }
        else
        {
            Console.WriteLine($"o arquivo {fileName} não encontrado.");
        }
    }
}
*/


//5. Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.

/*
class Program
{
    static void Main()
    {
        string fileName = "pessoas.json";
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);

            List<DadosPessoais> dadosPessoais = JsonSerializer.Deserialize<List<DadosPessoais>>(json)!;

            Console.WriteLine("Digite a idade que deseja filtrar: ");
            int idade = int.Parse(Console.ReadLine()!);

            List<DadosPessoais> pessoasComIdadeEspecifica = dadosPessoais.Where(d => d.Idade == idade).ToList();

            if (pessoasComIdadeEspecifica.Any())
            {
                Console.WriteLine($"Pessoas com {idade} anos:");

                foreach (DadosPessoais dadosPessoais in pessoasComIdadeEspecifica)
                {
                    Console.WriteLine($"Nome: {dadosPessoais.Nome}, Idade: {dadosPessoais.Idade}, E-mail: {dadosPessoais.Email}");
                }
            }
            else
            {
                Console.WriteLine($"Nenhuma pessoa encontrada com {idade} anos.");
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {fileName} não encontrado.");
        }
    }
}
*/