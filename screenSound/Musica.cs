class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";

    public void ExibirFixaTecnica()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no Plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus++");
        }

    }
}