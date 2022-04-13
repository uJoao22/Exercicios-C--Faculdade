using System;

namespace Atv07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um programa que use no máximo 3 variáveis para ler 10 números inteiros e apresente a soma desses números. ");

            int i=0, soma =0;
            do {
                Console.WriteLine("Informe um número inteiro");
                soma += int.Parse(Console.ReadLine());
                i++;
            } while (i<10);

            Console.WriteLine(soma);
        }
    }
}
