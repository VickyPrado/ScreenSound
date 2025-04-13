using ScreenSound.Modelos;
using System.Text.Json;
using ScreenSound.Filtros;


using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");        
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Skillet");        
        LinqFilter.FiltrarMusicasPorAno(musicas, 2012);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}