using System;

namespace Atv04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler um número inteiro e positivo X do teclado e informar quais são todos os divisores desse número. ");

            Console.WriteLine("Informe um número inteiro positivo");
            int X = int.Parse(Console.ReadLine());

            int i = X;
            do {
                if (X%i == 0)
                    Console.WriteLine(i);
                i--;
            } while(i>0);
        }
    }
}
