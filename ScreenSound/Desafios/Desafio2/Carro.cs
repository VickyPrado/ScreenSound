//3. Modelar e desserializar a classe Carro, que pode ser encontrada no endpoint disponibilizado https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json

/*
using System.Text.Json.Serialization;
namespace Carros;

internal class Carro
{
    [JsonPropertyName("marca")]
    public string? Marca { get; set; }

    [JsonPropertyName("modelo")]
    public string? Modelo { get; set; }

    [JsonPropertyName("ano")]
    public int? Ano { get; set; }

    [JsonPropertyName("tipo")]
    public string? Tipo { get; set; }

    public string FichaTecnica => $"\n\nCarro {Marca} {Modelo} {Ano} {Tipo}\n\n";
}
*/


//Program.cs
/*
using Carros;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        
        var carros = JsonSerializer.Deserialize<List<Carro>>(resposta);
        foreach(var carro in carros)
        {
            Console.WriteLine(carro.FichaTecnica);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
*/