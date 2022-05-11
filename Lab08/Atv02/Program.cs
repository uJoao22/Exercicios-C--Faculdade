using System;

namespace Atv02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma função que receba um número inteiro positivo como parâmetro, e caso este número seja primo retorne 1, caso contrário retorne 0. Número primo é aquele que só é divisível por 1 e por ele mesmo.");

            Console.WriteLine("\nInsira um número inteiro");
            int result = isPrimo(int.Parse(Console.ReadLine()));

            if(result == 1)
                Console.WriteLine("É primo");
            else
                Console.WriteLine("Não é primo");
        }

        static int isPrimo(int n1) {
            for(int i=n1-1; i>1; i--) {
                if(n1%i == 0)
                    return 0;
            }
            return 1;
        }
    }
}
