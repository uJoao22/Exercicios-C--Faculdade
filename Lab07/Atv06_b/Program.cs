using System;

namespace Atv06_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça programas que implementem os seguintes somatórios: b) J = 21/250 + 22/249 + 23/248 + ... + 250/21");

            double soma = 0;

            Console.Write("\nJ = ");

            int j=250;
            for(int i=21; i<=250; i++) {
                Console.Write("{0}/{1}", i, j);
                if(i!=250)
                    Console.Write(" + ");
                soma += (double)i/(double)j;  
                j--;  
            }

            Console.WriteLine("\nJ = {0:0.0}", soma);


        }
    }
}
