using System;

namespace Atv05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler um número inteiro X do teclado e informar em ordem decrescente quais são os números ímpares menores que esse número. ");

            Console.WriteLine("Informe um número inteiro");
            int X = int.Parse(Console.ReadLine());

            int i = X;
            do {
                if (i%2 == 1)
                    Console.WriteLine(i);
                i--;
            } while(i>0);

        }
    }
}
