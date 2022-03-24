using System;

namespace Atv07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que receba o raio, calcule e mostre:");
            Console.WriteLine("a) o comprimento de uma esfera, sabe-se que C = 2πR; ");
            Console.WriteLine("b) a área de uma esfera, sabe-se que A = πR2; ");
            Console.WriteLine("c) o volume de uma esfera, sabe-se que V = 4/3πR3.");
            Console.WriteLine("Obs: Para calcular o raio ao quadrado ou ao cubo você pode usar a função pow() como abaixo: ");
            Console.WriteLine("Z = Math.Pow(x, y)  // calcula a potência: XY e coloca o resultado na variável Z.");

            Console.WriteLine("Insira o valor do raio de uma esfera");
            double raio = double.Parse(Console.ReadLine());

            double comprimento = 2 * Math.PI * raio;
            double area = Math.PI * Math.Pow(raio, 2);
            double volume = (4/3) * Math.PI * Math.Pow(raio, 3);

            Console.WriteLine("O comprimento da esfera é: {0}, a área é: {1}, e o volume é: {2}", comprimento.ToString("F"), area.ToString("F"), volume.ToString("F"));
        }
    }
}
