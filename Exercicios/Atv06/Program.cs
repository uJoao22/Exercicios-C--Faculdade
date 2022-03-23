using System;

namespace Atv06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que receba o valor dos catetos de um triângulo, calcule e mostre o valor da hipotenusa. Obs: Para calcular a raiz quadrada use a função sqrt() como abaixo: y = Math.Sqrt(x) // calcula a raiz quadrada de x coloca o resultado na variável y.");

            Console.WriteLine("Informe o valor do primeiro cateto: ");
            double c1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o valor do segundo cateto: ");
            double c2 = double.Parse(Console.ReadLine());

            double somaCateto = Math.Pow(c1, 2) + Math.Pow(c2, 2);
            double hipotenusa = Math.Sqrt(somaCateto);

            Console.WriteLine("A hipotenusa é: {0}", hipotenusa);
        }
    }
}
