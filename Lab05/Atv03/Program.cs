using System;

namespace Atv03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler dois números X e Y inteiros do teclado, sendo que X pode ser maior que Y ou o contrário, e listar todos os números inteiros múltiplos de 3 que pertencem a esse intervalo. ");

            Console.WriteLine("Informe um número");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro número");
            int Y = int.Parse(Console.ReadLine());

            int maior = X > Y ? X : Y;
            int menor = X < Y ? X : Y;
            
            do {
                if (menor%3 == 0)
                    Console.WriteLine(menor);
                menor++;
            } while (menor<=maior);

        }
    }
}
