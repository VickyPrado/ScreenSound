//2. Modelar e desserializar a classe Pais, que pode ser encontrada no endpoint disponibilizado https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json

/*
using System.Text.Json.Serialization;
namespace Paises;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }

    [JsonPropertyName("capital")]
    public string? Capital { get; set; }

    [JsonPropertyName("populacao")]
    public int? Populacao { get; set; }

    [JsonPropertyName("continente")]
    public string? Continente { get; set; }

    [JsonPropertyName("idioma")]
    public string? Idioma { get; set; }

    public string FichaTecnica => $"\n\nPais: {Nome}\nCapital: {Capital}\nPopulacao: {Populacao}\nContinente: {Continente}\nIdioma: {Idioma}\n\n";
}
*/


//Program.cs
/*
using Paises;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        
        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta);
        foreach (var pais in paises)
        {
            Console.WriteLine(pais.FichaTecnica);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
*/
