using JogoDeCartas;

namespace JogosDeCartas;

public class Partida
{
    public Guid IdPartida { get; private set; } // Um ID único para a partida
    public DateTime DataHoraInicio { get; private set; }
    public List<Jogador> Jogadores { get; set; } = new List<Jogador>();
    public Baralho BaralhoDaPartida { get; set; }
    public List<Rodada> HistoricoRodadas { get; set; } = new List<Rodada>();

    public Partida()
    {
        IdPartida = Guid.NewGuid();
        DataHoraInicio = DateTime.Now;
        BaralhoDaPartida = new Baralho();
        BaralhoDaPartida.Embaralhar(); // Já começa com o baralho pronto
    }

    public void AdicionarJogador(Jogador jogador)
    {
        Jogadores.Add(jogador);
    }

    public void SalvarRodadaNoHistorico(Rodada rodada)
    {
        HistoricoRodadas.Add(rodada);
    }

    // Método auxiliar para exibir o histórico no console
    public void ExibirHistorico()
    {
        Console.WriteLine($"\n--- Histórico da Partida ({DataHoraInicio}) ---");
        foreach (var rodada in HistoricoRodadas)
        {
            Console.WriteLine($"Rodada {rodada.Numero}:");
            foreach (var jogada in rodada.Jogadas)
            {
                Console.WriteLine($"  {jogada.Key.Nome} jogou {jogada.Value}");
            }
        }
    }
}