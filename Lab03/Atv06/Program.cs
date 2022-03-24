using System;

namespace Atv06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler três números quaisquer e informar o maior e o menor. ");

            Console.WriteLine("Informe o 1º número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º número: ");
            double n2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o 3º número: ");
            double n3 = double.Parse(Console.ReadLine());

            if(n1>n2 && n1>n3)
                Console.WriteLine("{0} é o maior", n1);
            else if(n2>n1 && n2>n3)
                Console.WriteLine("{0} é o maior", n2);
            else
                Console.WriteLine("{0} é o maior", n3);

            if(n1<n2 && n1<n3)
                Console.WriteLine("{0} é o menor", n1);
            else if(n2<n1 && n2<n3)
                Console.WriteLine("{0} é o menor", n2);
            else
                Console.WriteLine("{0} é o menor", n3);

        }
    }
}
