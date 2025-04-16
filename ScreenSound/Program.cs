using ScreenSound.Modelos;
using System.Text.Json;
using ScreenSound.Filtros;


using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");        
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //foreach (var musica in musicas)
        //{
        //    musica.ExibirFichaTecnica();
        //    Console.WriteLine(); 
        //}
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, 2);


        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "Rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Skillet");        
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2012);

        //var musicasPreferidasDaVicky = new MusicasPreferidas("Vicky");
        //musicasPreferidasDaVicky.AdicionarMusicasFavoritas(musicas[18]);
        //musicasPreferidasDaVicky.AdicionarMusicasFavoritas(musicas[258]);
        //musicasPreferidasDaVicky.AdicionarMusicasFavoritas(musicas[725]);
        //musicasPreferidasDaVicky.AdicionarMusicasFavoritas(musicas[322]);
        //musicasPreferidasDaVicky.AdicionarMusicasFavoritas(musicas[1588]);

        //musicasPreferidasDaVicky.ExibirMusicasFavoritas();
        ////musicasPreferidasDaVicky.GerarArquivoJson();
        //musicasPreferidasDaVicky.GerarArquivoTxt();

        //var musicasPreferidasDoLeo = new MusicasPreferidas("Léo");
        //musicasPreferidasDoLeo.AdicionarMusicasFavoritas(musicas[487]);
        //musicasPreferidasDoLeo.AdicionarMusicasFavoritas(musicas[572]);
        //musicasPreferidasDoLeo.AdicionarMusicasFavoritas(musicas[18]);
        //musicasPreferidasDoLeo.AdicionarMusicasFavoritas(musicas[666]);
        //musicasPreferidasDoLeo.AdicionarMusicasFavoritas(musicas[1119]);

        //musicasPreferidasDoLeo.ExibirMusicasFavoritas();
        ////musicasPreferidasDoLeo.GerarArquivoJson();
        //musicasPreferidasDoLeo.GerarArquivoTxt();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}