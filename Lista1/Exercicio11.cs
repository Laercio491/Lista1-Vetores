using System;
using MinhaBiblioteca;

class Exercicio11

{
    static string linguagem(string msg)
    {
    string resultado = "";

        for (int i = 0; i < msg.Length; i++)
        {
            if (msg[i] == 'p' && i + 1 < msg.Length && Char.IsLetter(msg[i + 1]))
            {
                resultado += msg[i + 1];
                i++;
            }
            else
            {
                resultado += msg[i];
            }
        }
        return resultado;
    }
    static void Main()
        {
            string msg;
            Console.WriteLine("Entre com a mensagem");
            msg = Console.ReadLine();
            Console.WriteLine("Decodificação: " + linguagem(msg));
            Console.ReadKey();
        }
}
