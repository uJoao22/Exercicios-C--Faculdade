using System;

namespace Atv03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa para gerar uma tabela de conversão de graus para os respectivos senos e cossenos para uma variação de ângulo de 0 a 360 de 15 em 15 graus. (use as funções Math.Cos() para o cosseno e Math.Sin() para o seno)");

            for(int i=0; i<=360; i+=15)
                Console.WriteLine("{0}° = {1:0.00}sen° = {2:0.00}cos°", i, Math.Sin(i), Math.Cos(i));
        }
    }
}
