using System;

namespace Atv07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler três números e informar a soma dos dois maiores. ");

            Console.WriteLine("Informe o 1º número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º número: ");
            double n2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o 3º número: ");
            double n3 = double.Parse(Console.ReadLine());

            double maior=0, maior2=0;

            if(n1>n2 && n1>n3)
                maior = n1;
            else if(n2>n1 && n2>n3)
                maior = n2;
            else
                maior = n3;

            if((n1>n2 && n1<n3) || (n1>n3 && n1<n2)) 
                maior2 = n1;
            else if((n2>n1 && n2<n3) || (n2>n3 && n2<n1))
                maior2 = n2;
            else 
                maior2 = n3;
            
            Console.WriteLine(maior+" + "+maior2+" = "+ (maior+maior2));
            
        }
    }
}
