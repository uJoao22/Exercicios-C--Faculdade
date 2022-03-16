using System;

namespace Atv04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que calcule e mostre a área de um trapézio. Sabe-se que: A = (( base maior - base menos) * altura) /2");

            Console.WriteLine("Informe a base maior do trapézio: ");
            double baseMaior = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a base menor do trapézio: ");
            double baseMenor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do trapézio: ");
            double altura = double.Parse(Console.ReadLine());

            double area = ((baseMaior - baseMenor) * altura) / 2;

            Console.WriteLine("A área do trapézio é: {0}", area);
        }
    }
}
