namespace JogosDeCartas;

public class Rodada
{
    public int Numero { get; set; }
    // Dicionário para mapear qual carta cada jogador jogou nesta rodada
    public Dictionary<Jogador, Carta> Jogadas { get; set; } = new Dictionary<Jogador, Carta>();
    public Jogador VencedorDaRodada { get; set; }

    public Rodada(int numero)
    {
        Numero = numero;
    }

    public void RegistrarJogada(Jogador jogador, Carta carta)
    {
        Jogadas.Add(jogador, carta);
    }
}