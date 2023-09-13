Musica musica1 = new Musica();
musica1.Nome = "Pais e Filhos";
musica1.Artista = "Legião Urbana";
musica1.Duracao = 304;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Dai a Cesar o que é de Cesar";
musica2.Artista = "Cesar MC";
musica2.Duracao = 306;
musica2.Disponivel = false;

musica1.ExibirFixaTecnica();
musica2.ExibirFixaTecnica();