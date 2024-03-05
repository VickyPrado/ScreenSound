Banda queen = new Banda();
queen.Nome = "Quenn";

Album albumDoQuenn = new Album();
albumDoQuenn.Nome = "A night at the opera";

Musica musica1 = new Musica(queen);
musica1.Nome = "Love of my life";
musica1.Duracao = 213;

Musica musica2 = new Musica(queen);
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoQuenn.AdcionarMusica(musica1);
albumDoQuenn.AdcionarMusica(musica2);

albumDoQuenn.ExibirMusicasDoAlbum();

queen.AdicionarAlbum(albumDoQuenn);
queen.ExibirDiscografia();