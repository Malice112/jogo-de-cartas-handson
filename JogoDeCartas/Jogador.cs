namespace JogosDeCartas;

public class Jogador
{
    public string Nome { get; set; }
    public List<Carta> Mao { get; set; } = new List<Carta>();
    public int Pontuacao { get; set; }

    public Jogador(string nome)
    {
        Nome = nome;
        Pontuacao = 0;
    }

    // Método para o jogador receber uma carta do baralho
    public void ReceberCarta(Carta carta)
    {
        Mao.Add(carta);
    }

    // Método simulando o jogador escolhendo uma carta da mão para jogar
    public Carta JogarCarta(int indiceDaCarta)
    {
        if (indiceDaCarta >= 0 && indiceDaCarta < Mao.Count)
        {
            Carta cartaEscolhida = Mao[indiceDaCarta];
            Mao.RemoveAt(indiceDaCarta);
            return cartaEscolhida;
        }
        throw new ArgumentOutOfRangeException("Índice de carta inválido.");
    }
}