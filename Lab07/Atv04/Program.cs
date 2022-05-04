using System;

namespace Atv04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crie uma tabela para conversão de °C para °K para valores de 0°C a 100°C, com variação unitária. Sabe-se que para a conversão de temperatura usa-se a formula: °K = °C + 273,15. ");

            for(int i=0; i<=100; i++)
                Console.WriteLine("{0}°C = {1}°K", i, i+273.15);

        }
    }
}
