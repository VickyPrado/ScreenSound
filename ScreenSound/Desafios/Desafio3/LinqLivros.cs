//2. Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.

/*
class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
}

List<Livro> livros = new List<Livro>
{
    new Livro { Titulo = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien", AnoPublicacao = 1954 },
    new Livro { Titulo = "Harry Potter e a Pedra Filosofal", Autor = "J.K. Rowling", AnoPublicacao = 1997 },
    new Livro { Titulo = "A Guerra dos Tronos", Autor = "George R.R. Martin", AnoPublicacao = 1996 },
    new Livro { Titulo = "O Código Da Vinci", Autor = "Dan Brown", AnoPublicacao = 2003 },
    new Livro { Titulo = "A Menina que Roubava Livros", Autor = "Markus Zusak", AnoPublicacao = 2005 }
};

var titulosLivros = livros
    .Where(l => l.AnoPublicacao > 2000)
    .OrderBy(l => l.Titulo)
    .Select(l => l.Titulo);

Console.WriteLine("Títulos de livros publicados após 2000, ordenados alfabeticamente:");
foreach (var titulo in titulosLivros)
{
    Console.WriteLine(titulo);
}
*/