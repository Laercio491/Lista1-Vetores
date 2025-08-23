using System;
using MinhaBiblioteca;

class Exercicio2
{
    
    static void Main()
    {
        int n, t=0;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        t = Biblioteca.imparVetor(vetor);
        Console.WriteLine("\nA quantidade de valores impares no vetor é: " + t);
        Console.ReadKey();
    }
}