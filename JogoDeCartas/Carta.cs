using JogoDeCartas;

namespace JogosDeCartas;

// Record para representar uma carta: imutável e comparada pelo valor dos dados
public record Carta(string Valor, Naipe Naipe)
{
    // Converte o objeto em texto legível, ex: "Ás de Copas"
    public override string ToString() => $"{Valor} de {Naipe}";
}