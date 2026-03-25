using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogosDeCartas;

namespace JogoDeCartas
{
    public class Baralho
    {
        public List<Carta> Cartas { get; set; } = new List<Carta>(); // lista que guarda todas as 52 cartas

        public Baralho()
        {
            string[] valores = { "Ás", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valete", "Dama", "Rei" };

            foreach (Naipe n in Enum.GetValues(typeof(Naipe)))
            {
                foreach (string v in valores)
                {
                    Cartas.Add(new Carta(v, n));
                }
            }
        }

        public void Embaralhar()   // metodo para misturar as cartas
        {

            Random rng = new Random();
            int n = Cartas.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Carta temp = Cartas[k];
                Cartas[k] = Cartas[n];
                Cartas[n] = temp;
            }
        }
    }
}
