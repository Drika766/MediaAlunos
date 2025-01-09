using System;

class MediaAlunos
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Cálculo da Média dos Alunos ===");

        Console.Write("Digite o número de notas a serem inseridas: ");
        int quantidadeNotas = int.Parse(Console.ReadLine());

        double soma = 0;

        for (int i = 1; i <= quantidadeNotas; i++)
        {
            Console.Write($"Digite a nota {i}: ");
            double nota = double.Parse(Console.ReadLine());
            soma += nota;
        }

        double media = soma / quantidadeNotas;

        Console.WriteLine($"\nA média das notas é: {media:F2}");

        if (media >= 7)
        {
            Console.WriteLine("Aluno aprovado!");
        }
        else if (media >= 5)
        {
            Console.WriteLine("Aluno em recuperação.");
        }
        else
        {
            Console.WriteLine("Aluno reprovado.");
        }
    }
}
