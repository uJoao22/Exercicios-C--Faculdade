using System;

namespace Atv05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler um número e informar se ele é divisível por 2 e por 7 ao mesmo tempo. ");

            Console.WriteLine("Informe um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num%14 == 0) 
                Console.WriteLine("É divisível por 2 e 7");
            else
                Console.WriteLine("NÃO é divisível por 2 e 7");
        }
    }
}
