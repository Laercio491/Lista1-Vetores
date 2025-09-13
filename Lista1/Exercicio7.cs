using System;
using MinhaBiblioteca;


class Exercicio7

{
    static int[] multVetor(int[] v1, int[] v2)
    {
        int[] v3 = new int[v1.Length];
        for (int i = 0; i < v1.Length; i++)
        {
            v3[i]=(v1[i]*v2[i]);
        }
        return v3;
    }
    static void Main()
    {
        int n;

        Console.WriteLine("Tamanho do vetores: ");
        n = int.Parse(Console.ReadLine());
        int[] vetor1 = new int[n];
        int[] vetor2 = new int[n];
        int[] vetor3 = new int[n];
        Biblioteca.gerarVetor(vetor1);
        Biblioteca.gerarVetor(vetor2);
        vetor3 = multVetor(vetor1, vetor2);
        Console.WriteLine("Os vetores multiplicados dão: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("| "+vetor3[i]+" |");
        }
        Console.ReadKey();
    }
}