using System;

namespace Atv01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que leia os dois números inteiros e mostre na tela todos os números inteiros do intervalo. Exemplo: [-20, +30] ");

            Console.WriteLine("Informe um número");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro número");
            int n2 = int.Parse(Console.ReadLine());

            int maior = n1 > n2 ? n1 : n2;
            int menor = n1 < n2 ? n1 : n2;
            
            do {
                Console.WriteLine(menor);
                menor++;
            } while (menor<=maior);
        }
    }
}
