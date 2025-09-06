using System;
using MinhaBiblioteca;

class Exercicio4

{
    static void Main()
    {
        int n, t;
        Console.WriteLine("Tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        Biblioteca.gerarVetor(meuVetor);
        Biblioteca.mostrarVetor(meuVetor);
        t = Biblioteca.maiorVetor(meuVetor);
        Console.WriteLine("\nO maior valor do vetor: " + t);
        Console.ReadKey();
    }
}