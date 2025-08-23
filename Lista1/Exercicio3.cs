using System;
using MinhaBiblioteca;

class Exercicio3
{
    
    static void Main()
    {
        int n, t=0;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        t = Biblioteca.menorVetor(vetor);
        Console.WriteLine("\nO menor valor no vetor é: " + t);
        Console.ReadKey();
    }
}