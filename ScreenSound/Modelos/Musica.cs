using System.Text.Json.Serialization;

namespace ScreenSound.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? AnoString { get; set; }

    [JsonPropertyName("key")]
    public int? Chave { get; set; }

    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }

    public string? ChaveMusical => Chave?.ToString();

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Ano de lançamento: {Ano}");
        Console.WriteLine($"Chave: {Chave}");

        switch (Chave)
        {
            case 0:
                Console.WriteLine("Chave musical: C");
                break;
            case 1:
                Console.WriteLine("Chave musical: C#");
                break;
            case 2:
                Console.WriteLine("Chave musical: D");
                break;
            case 3:
                Console.WriteLine("Chave musical: D#");
                break;
            case 4:
                Console.WriteLine("Chave musical: E");
                break;
            case 5:
                Console.WriteLine("Chave musical: F");
                break;
            case 6:
                Console.WriteLine("Chave musical: F#");
                break;
            case 7:
                Console.WriteLine("Chave musical: G");
                break;
            case 8:
                Console.WriteLine("Chave musical: G#");
                break;
            case 9:
                Console.WriteLine("Chave musical: A");
                break;
            case 10:
                Console.WriteLine("Chave musical: A#)");
                break;
            case 11:
                Console.WriteLine("Chave musical: B");
                break;
            default:
                Console.WriteLine("Chave desconhecida");
                break;
        }        
    }
}

