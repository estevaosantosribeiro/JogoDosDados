# Jogo dos Dados

![](https://i.imgur.com/utTyWqe.gif)

## Sobre o projeto

O **Jogo dos Dados** é um jogo simples de corrida onde o jogador e o computador disputam para ver quem alcança a linha de chegada primeiro. Cada rodada, um dado é rolado para determinar o avanço de cada competidor.

## Funcionalidades

- **Rodadas Alternadas**: O jogador e o computador se revezam para jogar o dado e avançar no percurso.
- **Eventos Especiais**:
  - Avanço extra de 3 casas em certas posições.
  - Recuo de 2 casas em determinadas posições.
- **Condições de Vitória e Derrota**:
  - O primeiro a cruzar a linha de chegada vence.
  - O jogo termina e o jogador decide se deseja jogar novamente.

## Como Jogar

1. O jogo iniciará com o jogador e o computador na posição 0.
2. O jogador deve pressionar ENTER para rolar o dado.
3. A nova posição será exibida, e eventos especiais podem ocorrer.
6. O jogador pode optar por reiniciar o jogo após o término.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

## Como usar

1. Clone o repositório:

```sh
git clone https://github.com/usuario/jogo-dos-dados.git
```

2. Navegue até a pasta raiz do projeto:

```sh
cd JogoDosDados
```

3. Restaure as dependências:

```sh
dotnet restore
```

4. Compile o projeto:

```sh
dotnet build
```

5. Execute o jogo:

```sh
dotnet run
```

