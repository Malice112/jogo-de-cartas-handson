🃏 Jogo de Cartas Engine - Evolução de Estruturas

Este projeto é uma evolução da biblioteca de cartas desenvolvida para a disciplina de C# Software Development. O objetivo desta etapa foi modelar e implementar estruturas complexas para o gerenciamento de jogadores, partidas e o rastreamento histórico de rodadas, utilizando recursos modernos da linguagem C#.
🚀 Novas Funcionalidades e Melhorias

Além da base de naipes e baralhos, implementamos as seguintes evoluções:
1. Modelo de Carta Imutável (Carta.cs)
- Refatoramos a classe Carta para um Record.
- Por que usamos Record? Para garantir a imutabilidade (uma carta não muda após criada) e facilitar a comparação por valores, seguindo as melhores práticas de C# moderno.

2. Gestão de Jogadores (Jogador.cs)
- Implementação da classe que abstrai o participante do jogo.
- Mão de Cartas: Uso de List<Carta> para gerenciar as cartas que o jogador possui.
- Ações: Métodos para ReceberCarta e JogarCarta, simulando a interação real em uma mesa de jogo.

3. Engine de Partida e Histórico (Partida.cs e Rodada.cs)
- Criação de uma estrutura robusta para persistência de dados em memória durante a execução:
- Classe Rodada: Funciona como um "log" de um turno, utilizando um Dictionary<Jogador, Carta> para mapear quem jogou o quê.
- Classe Partida: Gerenciador central que utiliza Guid para identificação única e armazena uma lista de objetos Rodada, permitindo a consulta completa do histórico ao final do jogo.

🛠️ Tecnologias e Conceitos Aplicados
- Linguagem: C# (.NET 8.0)
- IDE: Visual Studio
- Novos Conceitos: * Records: Para modelos de dados imutáveis.
- Enums: Para tipos fixos (Naipes).
- Dicionários e Coleções: Para mapeamento de jogadas e histórico.
- Abstração: Modelagem de entidades do mundo real (Jogador/Partida).

📂 Estrutura de Arquivos Atualizada
```
JogoDeCartas/
├── Naipe.cs      # Enum: Definição fixa dos naipes
├── Carta.cs      # Record: Modelo imutável da carta
├── Baralho.cs    # Class: Lógica de geração e embaralhamento
├── Jogador.cs    # Class: Entidade com nome, mão e pontuação
├── Rodada.cs     # Class: Estrutura de histórico de um turno
├── Partida.cs    # Class: Engine principal e log de rodadas
└── README.md     # Documentação do projeto
```

Integrantes do Grupo:
- Maria Alice Freitas Araújo - RM557516
- João Victor Soave - RM557595
- Ianny Raquel Ferreira de Souza - RM559096
