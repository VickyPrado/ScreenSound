Banda queen = new Banda("Quenn");

Album albumDoQuenn = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQuenn.AdcionarMusica(musica1);
albumDoQuenn.AdcionarMusica(musica2);
queen.AdicionarAlbum(albumDoQuenn);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQuenn.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();