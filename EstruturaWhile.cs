using System;

class EstruturaWhile
{
    public static void Executar()
    {
        int palpite = 0;
        Random random = new Random();

        int numeroSecreto = random.Next(1, 16);
        bool numeroEncontrado = false;
        int tentativasRestantes = 5;
        int tentativas = 0;

        while (tentativasRestantes > 0 && !numeroEncontrado)
        {
            Console.WriteLine("Insira seu palpite: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out palpite))
            {
                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número encontrado em {0} tentativas!", tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("Maior... tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            }
        }

        if (!numeroEncontrado)
        {
            Console.WriteLine("Você perdeu! O número secreto era {0}.", numeroSecreto);
        }
    }

    static void Main(string[] args)
    {
        Executar();
    }
}
