# 🃏 Jogo de Cartas Genérico (Class Library)

Este projeto consiste em uma biblioteca de classes (Class Library) desenvolvida em **C#** para o 5º período de Engenharia de Software. O objetivo é fornecer uma estrutura base robusta e reutilizável para a criação de diversos jogos de cartas.

## 🚀 Funcionalidades Implementadas

A biblioteca está dividida em três componentes principais, focando em organização e encapsulamento:

### 1. Naipes (`Naipe.cs`)
Utilização de uma **Enumeração (Enum)** para definir os quatro naipes padrão. Isso garante a integridade dos dados, impedindo que valores inválidos sejam atribuídos às cartas.
* `Copas`, `Ouros`, `Espadas` e `Paus`.

### 2. Modelo de Carta (`Carta.cs`)
Classe que representa a unidade básica do jogo.
* **Propriedades:** `Valor` (string) e `Naipe` (do tipo Enum).
* **Construtor:** Inicializa a carta com seus atributos obrigatórios.
* **Override ToString:** Customizado para exibir a carta de forma legível (ex: "Ás de Espadas").

### 3. Gerenciamento do Baralho (`Baralho.cs`)
Classe responsável por manipular o conjunto de cartas.
* **Criação Automática:** No construtor, o sistema utiliza laços de repetição (`foreach`) para gerar automaticamente as 52 cartas combinando todos os valores e naipes.
* **Algoritmo de Embaralhamento:** Implementação do método `Embaralhar()`, que utiliza a classe `Random` para bagunçar a ordem das cartas de forma eficiente.

## 🛠️ Tecnologias e Conceitos
* **Linguagem:** C# (.NET)
* **IDE:** Visual Studio 2022
* **Conceitos:** Orientação a Objetos (POO), Encapsulamento, Coleções Dinâmicas (`List<T>`) e Algoritmos de Ordenação Aleatória.

## 📂 Estrutura de Arquivos
```text
JogoDeCartas/
├── Naipe.cs    # Definição dos tipos de naipes
├── Carta.cs    # Modelo do objeto Carta
├── Baralho.cs  # Lógica de criação e embaralhamento
└── README.md   # Documentação do processo
```

### Nome e RM dos integrantes do grupo:
* Maria Alice Freitas Araújo RM557516
* João Victor Soave RM557595
* Ianny Raquel Ferreira de Souza RM559096
  
