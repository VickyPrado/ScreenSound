using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var TodosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in TodosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
}
