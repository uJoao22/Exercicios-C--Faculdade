using System;

namespace Atv02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que receba duas notas, calcule e mostre a média ponderada dessas notas, considerando peso 2 para a primeira nota e peso 3 para a segunda nota.");

            Console.WriteLine("Insira a primeira nota:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota:");
            double n2 = double.Parse(Console.ReadLine());

            double mp = (n1*2 + n2*3) / (2+3);

            Console.WriteLine("O calculo da média ponderada é: {0}", mp);
        }
    }
}
