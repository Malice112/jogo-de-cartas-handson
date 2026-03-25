namespace JogosDeCartas;

class Program
{
    static void Main(string[] args)
    {
        // 1. Criar a Partida e os Jogadores
        Partida partida = new Partida();
        Jogador j1 = new Jogador("Alice");
        Jogador j2 = new Jogador("Bob");

        partida.AdicionarJogador(j1);
        partida.AdicionarJogador(j2);

        // 2. Distribuir cartas (exemplo: 2 cartas para cada)
        j1.ReceberCarta(partida.BaralhoDaPartida.Cartas[0]);
        j1.ReceberCarta(partida.BaralhoDaPartida.Cartas[1]);
        j2.ReceberCarta(partida.BaralhoDaPartida.Cartas[2]);
        j2.ReceberCarta(partida.BaralhoDaPartida.Cartas[3]);

        // 3. Simular uma Rodada
        Rodada rodada1 = new Rodada(1);

        // Alice e Bob jogam a primeira carta de suas mãos (índice 0)
        Carta cartaAlice = j1.JogarCarta(0);
        Carta cartaBob = j2.JogarCarta(0);

        rodada1.RegistrarJogada(j1, cartaAlice);
        rodada1.RegistrarJogada(j2, cartaBob);

        // 4. Salvar no histórico da partida
        partida.SalvarRodadaNoHistorico(rodada1);

        // Exibir o resultado
        partida.ExibirHistorico();
    }
}