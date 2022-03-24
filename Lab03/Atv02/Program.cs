using System;

namespace Atv02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler um número real e informar se ele é positivo negativo ou nulo. ");

            Console.WriteLine("Informe o número: ");
            double num = double.Parse(Console.ReadLine());

            if(num>0)
                Console.WriteLine("POSITIVO");
            else if(num<0)
                Console.WriteLine("NEGATIVO");
            else
                Console.WriteLine("NULO");
        }
    }
}
