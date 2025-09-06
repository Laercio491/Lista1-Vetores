using System;

namespace MinhaBiblioteca
{
    public class Biblioteca
    {
        public static void lerVetor(int[] vetor)
        {
            Console.WriteLine("Entre com os dados do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Array[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());
            }// fim for

        }

        public static void gerarVetor(int[] vetor)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < vetor.Length; i++)
                vetor[i] = aleatorio.Next(1, 100);

        }
        public static void mostrarVetor(int[] vetor)
        {
            Console.WriteLine("Dados do Vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("|" + vetor[i]);
            }
            Console.Write("|");
        }
        public static int somaVetor(int[] vetor)
        {
            int quant = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                quant = quant + vetor[i];
            }
            return quant;
        }
        public static int quantImpar(int[] vetor)
        {
            int quant = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    quant++;
                }
            }
            return quant;
        }
        public static int menorVetor(int[] vetor)
        {
            int menor = 100;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (menor > vetor[i])
                {

                    menor = vetor[i];
                }
            }
            return menor;
        }

    public static int maiorVetor(int[] vetor)
        {
            int maior = 1;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (maior < vetor[i]) {

                    maior = vetor[i];
                }
            }
            return maior;
        }
    }
}