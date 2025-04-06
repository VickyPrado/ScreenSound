/* Refatorando uma função:
Nesta API do Game Of Thrones API com recursos dos personagens da série pelo ID, por exemplo o Margaery Tyrell possui o ID 16 :

https://www.anapioficeandfire.com/api/characters/16
Copiar código
Ao realizar uma requisição para este endpoint, temos a seguinte resposta:

{ "url":"https://www.anapioficeandfire.com/api/characters/16","name":"Margaery Tyrell","gender":"Female","culture":"Westeros","born":"In 283 AC, at Highgarden","died":"","titles":["Queen of the Seven Kingdoms"],"aliases":["The Little Queen", "The Little Rose", "Maid Margaery"],"father":"","mother":"","spouse":"https://www.anapioficeandfire.com/api/characters/862","allegiances":["https://www.anapioficeandfire.com/api/houses/398"],"books":["https://www.anapioficeandfire.com/api/books/1", "https://www.anapioficeandfire.com/api/books/2", "https://www.anapioficeandfire.com/api/books/3", "https://www.anapioficeandfire.com/api/books/5", "https://www.anapioficeandfire.com/api/books/8"],"povBooks":[],"tvSeries":["Season 2", "Season 3", "Season 4", "Season 5", "Season 6"],"playedBy":["Natalie Dormer"]}

Crie uma classe e faça a deserialização deste recurso nela, e exibe a classe no console. Sinta-se livre para escolher quais dados você deseja utilizar na classe.
*/

/*
namespace GOT;
class Personagem
{
    public string name { get; set; }
    public List<string>? aliases { get; set; }

    public void ExibirApelidosDaPersonagem()
    {
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine("Apelidos:");
        foreach (string apelido in aliases)
        {
            Console.WriteLine($"- {apelido}");
        }
    }
}
*/

//Program.cs
/*
using GOT;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    string json = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");

    Personagem margaery = JsonSerializer.Deserialize<Personagem>(json)!;
    margaery.ExibirApelidosDaPersonagem();
}
*/