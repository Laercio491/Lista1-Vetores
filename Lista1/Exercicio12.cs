using System;
using MinhaBiblioteca;
using System.Globalization;



class Exercicio12

{
    static double tabVetor(double[] notas)
    {
        double menor = notas[0];
        double maior = notas[0];
        double soma = notas[0];

        for (int i = 1; i < notas.Length; i++)
        {
            soma = soma + notas[i];

            if (notas[i] < menor)
                menor = notas[i];

            if (notas[i] > maior)
                maior = notas[i];
        }

        // Subtrai a maior e a menor nota
        double notaFinal = (soma - menor - maior);
        return notaFinal;
    }

    static void Main()
    {
        double[] notas = new double[5];
        Console.WriteLine("Insira as notas da escola de samba (1 casa decimal, Ex: 5,1):");

        for (int i = 0; i < 5; i++)
        {
            notas[i] = double.Parse(Console.ReadLine());
        }

        double resul = tabVetor(notas);
        Console.WriteLine($"\nA nota final da escola é: {resul:F1}");
        Console.ReadKey();

    }
}