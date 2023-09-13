Banda racionais = new Banda("Racionais MC's");

Album albumDoRacionais = new Album("Sobrevivendo no Inferno");

Musica musica1 = new Musica(racionais, "Capítulo 4, Versículo 3")
{
    Duracao = 486,
    Disponivel = true,
};

Musica musica2 = new Musica(racionais, "Diário de um Detento")
{
    Duracao = 451,
    Disponivel = false,
};

racionais.AdicionarAlbum(albumDoRacionais);

albumDoRacionais.AdicionarMusica(musica1);
albumDoRacionais.AdicionarMusica(musica2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoRacionais.ExibirMusicasDoAlbum();
racionais.ExibirDiscografia();