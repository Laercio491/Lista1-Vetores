using System;
using MinhaBiblioteca;

class Exercicio3

{
    static void Main()
    {
        int n, t;
        Console.WriteLine("Tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        Biblioteca.gerarVetor(meuVetor);
        Biblioteca.mostrarVetor(meuVetor);
        t = Biblioteca.menorVetor(meuVetor);
        Console.WriteLine("\nO menor valor do vetor: " + t);
        Console.ReadKey();
    }
}