using System;

namespace Atv01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crie uma tabela para conversão de graus °C para °F para valores de 0°C a 100°C, com variação unitária. Sabe-se que para a conversão de temperatura usa-se a formula: °F = 9 * °C / 5 + 32.");

            for(int i=0; i<=100; i++)
                Console.WriteLine("{0}°C = {1}°F", i, 9*i/5+32);
        }
    }
}
