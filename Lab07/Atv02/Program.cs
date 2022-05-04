using System;

namespace Atv02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que calcule o seguinte somatório, sendo que o valor de N deve ser fornecido pelo usuário: H = 1 + 1/2 + 1/3 + 1/4 + ... + 1/N");

            Console.WriteLine("\nDigite o número");
            int n = int.Parse(Console.ReadLine());
            double soma = 0;

            Console.Write("\nH = ");

            for(int i=1; i<=n; i++) {
                Console.Write("1/{0}",i);
                if(i!=n)
                    Console.Write(" + ");
                soma += 1/(double)i;    
            }

            Console.WriteLine("\nH = {0:0.0}", soma);
        }
    }
}
