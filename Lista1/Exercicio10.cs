using System;
using MinhaBiblioteca;


class Exercicio10

{
    static int[] quantVetor(int[] v1)
    {
        int[] medida = new int[6];
        for (int i = 0; i < v1.Length; i++)
        {
            switch (v1[i])
            {
                case 1:
                    medida[0] = medida[0] + 1;
                    break;
                case 2:
                    medida[1] = medida[1] + 1; ;
                    break;
                case 3:
                    medida[2] = medida[2] + 1;
                    break;
                case 4:
                    medida[3] = medida[3] + 1;
                    break;
                case 5:
                    medida[4] = medida[4] + 1;
                    break;
                case 6:
                    medida[5] = medida[5] + 1;
                    break;
            }
        }
        return medida;
    }
    static void Main()
    {
        Random aleatorio = new Random();
        int n;
        Console.WriteLine("Quantos laçamentos foram feitos: ");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        for (int i = 0; i < meuVetor.Length; i++)
        {
            meuVetor[i] = aleatorio.Next(1, 6);
        }
        int[] resul = new int[6];
        resul = quantVetor(meuVetor);
        for (int i = 0; i < resul.Length; i++)
        {
            Console.WriteLine($"A quentidade do numero [{i + 1}] é: {resul[i]}");
        }
        Console.ReadKey();

    }
}