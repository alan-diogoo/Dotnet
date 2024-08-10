# Jogo de Adivinhação

Este é um simples jogo de adivinhação desenvolvido em C#. O objetivo do jogo é adivinhar um número secreto dentro de um determinado número de tentativas, dependendo do nível de dificuldade escolhido.

## Funcionalidades

- Três níveis de dificuldade: Fácil, Médio e Difícil.
- Cada nível oferece um número diferente de tentativas e um intervalo de números diferentes.
- Feedback sobre cada palpite feito.

## Como Jogar

1. **Escolha o Nível de Dificuldade**:
   - `F` para Fácil: Adivinhe um número entre 1 e 10 (3 vidas).
   - `M` para Médio: Adivinhe um número entre 1 e 50 (4 vidas).
   - `D` para Difícil: Adivinhe um número entre 1 e 100 (5 vidas).

2. **Faça seu palpite**: Insira um número dentro do intervalo correspondente ao nível escolhido.

3. **Ganha ou perde**:
   - Se adivinhar o número secreto, você ganha!
   - Se acabar com as vidas, você perde e o número secreto é revelado.

## Como Executar o Projeto

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/seu-usuario/JogoAdivinhacao.git
   cd JogoAdivinhacao
