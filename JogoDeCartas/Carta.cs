namespace JogoDeCartas
{
    public class Carta
    {
        public string Valor { get; set; }
        public Naipe Naipe { get; set; }

        public Carta(string valor, Naipe naipe)
        {
            Valor = valor;
            Naipe = naipe;
        }

        public override string ToString() {

            return $"{Valor} de {Naipe}";
        }
    }
}
