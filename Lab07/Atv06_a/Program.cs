using System;

namespace Atv06_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça programas que implementem os seguintes somatórios: a) G = 1 + 3/2 + 5/3 + 7/4 + ... + 99 / 50");

            double soma = 0;

            Console.Write("\nG = ");

            int j=1;
            for(int i=1; i<=50; i++) {
                Console.Write("{0}/{1}", j, i);
                if(i!=50)
                    Console.Write(" + ");
                soma += (double)j/(double)i;  
                j+=2;  
            }

            Console.WriteLine("\nG = {0:0.0}", soma);


        }
    }
}
