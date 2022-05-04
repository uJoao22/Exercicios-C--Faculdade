using System;

namespace Atv05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crie uma tabela de conversão de centímetros para polegadas, começando de 0cm e terminando em 100cm, com variação de 2 em 2. (cada 2,5 cm equivalem a uma polegada) ");

            for(int i=0; i<=100; i+=2)
                Console.WriteLine("{0}cm = {1}pol", i, i/2.5);

        }
    }
}
