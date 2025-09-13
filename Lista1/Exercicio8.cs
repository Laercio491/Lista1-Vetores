using System;
using MinhaBiblioteca;


class Exercicio8

{
    static int quantExVetor(int[] v1, int[] v2)
    {
        int v3 = 0;
        for (int i = 0; i < v1.Length; i++)
        {
            if (v1[i] == v2[0])
            {
                v3++;
            }
        }
        return v3;
    }
    static void Main()
    {
        int n;

        Console.WriteLine("Tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] vetor1 = new int[n];
        int[] g = new int[n];
        int[] t = new int[0];
        Console.WriteLine("Numero de busca: ");
        g[0] = int.Parse(Console.ReadLine());
        Biblioteca.gerarVetor(vetor1);
        Console.WriteLine("A quantida de vezes que aparece "+g[0]+" é: "+ quantExVetor(vetor1, g));
        Biblioteca.mostrarVetor(vetor1);
        Console.ReadKey();
    }
}