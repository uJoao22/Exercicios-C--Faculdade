using System;

namespace Atv06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler um número inteiro X do teclado e informar o fatorial desse número. ");

            Console.WriteLine("Informe um número inteiro");
            int X = int.Parse(Console.ReadLine());

            int fat=1;
            do {
                fat = fat * X;
                X--;
            } while(X>1);

            Console.WriteLine(fat);
        }
    }
}
