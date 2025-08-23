using System;
using MinhaBiblioteca;

class Exercicio4
{
    
    static void Main()
    {
        int n, t=0;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        t = Biblioteca.maiorVetor(vetor);
        Console.WriteLine("\nO maior valor no vetor é: " + t);
        Console.ReadKey();
    }
}