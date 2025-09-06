using System;
using MinhaBiblioteca;

class Exercicio5

{
    static string completarDNA(string dna)
    {
        char[] complemento = new char[dna.Length];
        dna = dna.ToUpper();
        for (int i = 0; i < dna.Length; i++)
        {
            switch (dna[i])
            {
                case 'A':
                    complemento[i] = 'T';
                    break;
                case 'T':
                    complemento[i] = 'A';
                    break;
                case 'C':
                    complemento[i] = 'G';
                    break;
                case 'G':
                    complemento[i] = 'C';
                    break;
                default:
                    complemento[i] = 'N';//Quando vem caracter incorreto
                    break;
            }
        }
        return new string(complemento);//transformando char(vetor de caracterer) em String
    }
    static void Main()
    {
        string dna, comp;
        Console.WriteLine("Entre com a fita de DNA");
        dna = Console.ReadLine();
        // comp = completarDNA(dna);
        // Console.WriteLine("Fita complementar: "+comp);
        Console.WriteLine("Fita complementar: " + completarDNA(dna));
        Console.ReadKey();
    }
}