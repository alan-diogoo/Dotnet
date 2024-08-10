using System;

class JogoAdivinhacao
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Escolha o nível de dificuldade: Fácil (F), Médio (M), Difícil (D)");
        string dificuldade = Console.ReadLine().ToUpper();
        int numeroMaximo = 0;
        int vidas = 0;

        switch (dificuldade)
        {
            case "F":
                numeroMaximo = 10;
                vidas = 3;
                break;
            case "M":
                numeroMaximo = 50;
                vidas = 4;
                break;
            case "D":
                numeroMaximo = 100;
                vidas = 5;
                break;
            default:
                Console.WriteLine("Dificuldade inválida. Escolha F, M ou D.");
                return;
        }

        var aleatorio = new Random();
        int numeroSorteado = aleatorio.Next(1, numeroMaximo + 1);
        bool acertou = false;

        Console.WriteLine($"Você escolheu a dificuldade {dificuldade}. Tente adivinhar o número entre 1 e {numeroMaximo}.");

        while (vidas > 0 && !acertou)
        {
            Console.WriteLine($"Você tem {vidas} vidas restantes. Digite seu palpite:");
            int palpite;

            if (!int.TryParse(Console.ReadLine(), out palpite) || palpite < 1 || palpite > numeroMaximo)
            {
                Console.WriteLine($"Palpite inválido. Digite um número entre 1 e {numeroMaximo}.");
                continue;
            }

            if (palpite == numeroSorteado)
            {
                acertou = true;
                Console.WriteLine("Parabéns! Você acertou o número!");
            }
            else
            {
                vidas--;
                if (vidas > 0)
                {
                    Console.WriteLine("Palpite errado. Tente novamente.");
                }
            }
        }

        if (!acertou)
        {
            Console.WriteLine($"Você perdeu. O número correto era {numeroSorteado}.");
        }

        Console.WriteLine("Obrigado por jogar!");
    }
}
