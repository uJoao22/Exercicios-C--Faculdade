using System;

namespace Atv06_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça programas que implementem os seguintes somatórios: c) L = 1 - 2/4 + 3/9 - 4/16 + ... + N/N2");

            Console.WriteLine("\nDigite um número");
            int n = int.Parse(Console.ReadLine());
            double soma = 0;

            Console.Write("\nL = ");

            for(int i=1; i<=n; i++) {
                Console.Write("{0}/{1}", i, Math.Pow(i, 2));
                if(i!=n){
                    if(i%2==0)
                        Console.Write(" + ");
                    else
                        Console.Write(" - ");
                }

                soma = i%2==0 ? soma-(double)i/Math.Pow(i, 2) : soma+(double)i/Math.Pow(i, 2);
            }

            Console.WriteLine("\nL = {0:0.00}", soma);
        }
    }
}
