using System;

namespace Atv03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler um número inteiro e dizer se ele é par ou impar (dica: use o operador resto da divisão ) ");

            Console.WriteLine("Informe um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if(num%2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }
    }
}
