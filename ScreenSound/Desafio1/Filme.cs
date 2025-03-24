// 1.Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.

/*
using Alura.Filmes;

namespace Alura.Filmes
{
    class Filme
    {
        private List<string> Elenco { get; set; }
        public string Titulo { get; set; }
        public int Duracao { get; set; }

        public Filme(string titulo, int duracao, List<string>? elenco)
        {
            if (elenco == null)
            {
                Elenco = new List<string>();
            }
            else
            {
                Elenco = elenco;
            }

            Titulo = titulo;
            Duracao = duracao;
        }

        public void AdicionarElenco(string ator)
        {
            Elenco.Add(ator);
            Console.WriteLine($"{ator} adicionado/a ao elenco.");
        }

        public void ListarElenco()
        {
            if (Elenco.Count == 0)
            {
                Console.WriteLine("Elenco vazio.");
            }
            else
            {
                Console.WriteLine("Elenco... ");
                foreach (var ator in Elenco)
                {
                    Console.WriteLine(ator);
                }
            }
        }
    }
} 
*/



// 4. Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.

/*
class Filme
{
    public List<Artista> Elenco { get; set; }
    public string Titulo { get; set; }
    public int Duracao { get; set; }

    public Filme(string titulo, int duracao, List<Artista> elenco)
    {
        if (elenco == null)
        {
            Elenco = new List<Artista>();
        }
        else
        {
            Elenco = elenco;
            foreach (var artista in Elenco)
            {
                artista.AdicionarFilme(this);
            }
        }

        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarElenco(Artista artista)
    {
        Elenco.Add(artista);
        if (!artista.FilmesAtuados.Contains(this))
        {
            artista.AdicionarFilme(this);
        }
        Console.WriteLine($"{artista} adicionado/a ao elenco.");
    }

    public void ListarElenco()
    {
        if (Elenco.Count == 0)
        {
            Console.WriteLine("Elenco vazio.");
        }
        else
        {
            Console.WriteLine("Elenco... ");
            foreach (var artista in Elenco)
            {
                Console.WriteLine(artista.Nome);
            }
        }
    }
}
*/