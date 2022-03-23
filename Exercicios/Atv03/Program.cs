using System;

namespace Atv03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que receba o preço de um produto, calcule e mostre o novo preço, sabendo-se que este sofreu um desconto de 10%");

            Console.WriteLine("Informe o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            double novoPreco = preco - (preco*0.10);

            Console.WriteLine("O produto que custava R${0} agora custa: R${1}", preco, novoPreco);
        }
    }
}
