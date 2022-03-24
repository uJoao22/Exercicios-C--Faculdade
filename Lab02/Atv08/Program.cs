using System;

namespace Atv08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Faça um programa que receba a medida de dois ângulos de um triângulo, calcule e mostre a medida do terceiro ângulo. Sabe-se que a soma dos ângulos de um triângulo é 180. ");
            
            Console.WriteLine("Infornme a medida do 1º angulo do triângulo: ");
            double ang1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Infornme a medida do 2º angulo do triângulo: ");
            double ang2 = double.Parse(Console.ReadLine());

            double ang3 = 180 - (ang1+ang2);

            Console.WriteLine("A medida do 3º angulo é: {0}°", ang3);
        }
    }
}
