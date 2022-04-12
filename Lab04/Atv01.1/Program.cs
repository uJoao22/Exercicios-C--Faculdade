using System;

namespace Atv01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um programa que leia dois números do teclado e em seguida mostra um menu com opções para executar um das quatro operações básicas (+,-,* ou /). Mostrar o resultado da operação executada. Fazer o programa em duas versões: usando switch.");

            Console.WriteLine("Insira o 1º valor");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 2º valor");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para multiplicar");
            Console.WriteLine("Digite 4 para dividir");
            int op = int.Parse(Console.ReadLine());

            switch(op){
                case 1:
                    Console.WriteLine("{0} + {1} = {2}", n1, n2, n1+n2);
                break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2}", n1, n2, n1-n2);
                break;
                case 3:
                    Console.WriteLine("{0} * {1} = {2}", n1, n2, n1*n2);
                break;
                case 4:
                    Console.WriteLine("{0} / {1} = {2}", n1, n2, n1/n2);
                break;
                default:
                    Console.WriteLine("Operação Inválida");
                break;
            }
        }
    }
}
