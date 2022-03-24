using System;

namespace Atv01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler dois números do teclado e informar o maior. ");

            Console.WriteLine("Informe 1º número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe 2º número: ");
            double n2 = double.Parse(Console.ReadLine());

            if(n1>n2) 
                Console.WriteLine("{0} é maior que {1}", n1, n2);
            else
                Console.WriteLine("{0} é maior que {1}", n2, n1);
        }
    }
}
