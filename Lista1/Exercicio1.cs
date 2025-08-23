using System;
using MinhaBiblioteca;

class Exercicio1
{
    static void Main()
    {
        int n, soma=0;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        soma= Biblioteca.somaVetor(vetor);
        Console.WriteLine("\nA soma do vetor é: " + soma);
        Console.ReadKey();
    }
}