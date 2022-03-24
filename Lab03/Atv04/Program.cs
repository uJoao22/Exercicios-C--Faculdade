using System;

namespace Atv04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler um número e informar seu valor absoluto ( Exemplo: ABS(10) = 10 / ABS(-10) = 10 ) ");
            
            Console.WriteLine("Informe um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            int valorAbs = Math.Abs(num);

            Console.WriteLine("O valor absoluto é: {0}", valorAbs);
        }
    }
}
