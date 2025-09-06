﻿using System;

using MinhaBiblioteca;

class Exercicio2

{
    static void Main()
    {
        int n, t = 0;
        Console.WriteLine("Tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        Biblioteca.gerarVetor(meuVetor);
        Biblioteca.mostrarVetor(meuVetor);
        t = Biblioteca.quantImpar(meuVetor);
        Console.WriteLine("\nQuantidade de numeros impar: " + t);
        Console.ReadKey();
    }
}