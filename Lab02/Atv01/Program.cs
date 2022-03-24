using System;

namespace Atv01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que receba dois números, calcule e mostre a subtração do primeiro número pelo segundo.");

            Console.WriteLine("Insira o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} - {1} = {2}", n1, n2, n1-n2);
        }
    }
}
