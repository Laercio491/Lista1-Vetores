using System;
using MinhaBiblioteca;

class Exercicio11

{
    static string linguagem(string msg)
    {
    string resultado = "";

        for (int i = 0; i < msg.Length; i++)
        {
            // Se o caractere atual for 'p' E não for o último caractere, e o próximo caractere for letra
            if (msg[i] == 'p' && i + 1 < msg.Length && Char.IsLetter(msg[i + 1]))
            {
                // pula o 'p' e adiciona só a letra seguinte
                resultado += msg[i + 1];
                i++; // pula o próximo caractere, pois já foi adicionado
            }
            else
            {
                // adiciona caractere normalmente (espaços, pontuação, letras que não vem após p)
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
using System;
using MinhaBiblioteca;

class Exercicio11

{
    static string linguagem(string msg)
    {
    string resultado = "";

        for (int i = 0; i < msg.Length; i++)
        {
            // Se o caractere atual for 'p' E não for o último caractere, e o próximo caractere for letra
            if (msg[i] == 'p' && i + 1 < msg.Length && Char.IsLetter(msg[i + 1]))
            {
                // pula o 'p' e adiciona só a letra seguinte
                resultado += msg[i + 1];
                i++; // pula o próximo caractere, pois já foi adicionado
            }
            else
            {
                // adiciona caractere normalmente (espaços, pontuação, letras que não vem após p)
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