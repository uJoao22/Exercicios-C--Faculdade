using System;

namespace Atv02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que mostre todos os múltiplos de 7 menores que 1000.");

            int i = 1;
            do {
                if (i%7 == 0)
                    Console.WriteLine(i);
                i++;
            } while (i<1000);
        }
    }
}
