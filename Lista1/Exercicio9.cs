using System;
using MinhaBiblioteca;


class Exercicio9

{
    static string invVetor(string v1)
    {
        int j = v1.Length-1;
        char[] inv = new char[v1.Length];
        for (int i = 0; i < v1.Length; i++)
        {
            inv[i] = v1[j];
            j--;
        }
        return new string(inv);
    }
    static void Main()
    {
        string org="", inv="";
        Console.WriteLine("Entre com a frase");
        org = Console.ReadLine();
        inv = invVetor(org);
        Console.WriteLine("Inversamente fica: "+inv);
        Console.ReadKey();
    }
}