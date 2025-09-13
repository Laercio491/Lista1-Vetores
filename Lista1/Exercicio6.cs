using System;
using MinhaBiblioteca;


class Exercicio6

{
    static int[] existeVetor(int[] meuVetor, int g )
    {
        int[] t = new int[meuVetor.Length];
        for (int i = 0; i < meuVetor.Length; i++)
        {
            if (meuVetor[i] == g)
            {
                t[i] = i;
            }
        }

        return t;
    }
    static void Main()
    {
        int n;

        Console.WriteLine("Tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        int g = 0;
        int[] t = new int[n];
        Biblioteca.gerarVetor(meuVetor);
        Console.WriteLine("Numero de busca: ");
        g = int.Parse(Console.ReadLine());
        t = existeVetor(meuVetor, g);
        if (t[1] != 0)
        {
            Console.WriteLine("O numero inserido foi achado");
            for (int i = 0; i < meuVetor.Length; i++)
            {
                Console.WriteLine("Posições: " + t[i]);
            }

        }
        else
        {
            Console.WriteLine("O numero inserido não foi achado");
        }
        Console.ReadKey();
    }
}