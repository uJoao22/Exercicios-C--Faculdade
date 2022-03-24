using System;

namespace Atv05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que receba o valor do salário mínimo e o valor do salário de um funcionário, calcule e mostre a quantidade de salários mínimos que ganha esse funcionário.");

            Console.WriteLine("Informe o valor do sálario minimo atualmente: ");
            double salarioMinimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do sálario de um funcionário: ");
            double salarioFuncionario = double.Parse(Console.ReadLine()); 

            double qtdSalario = salarioFuncionario/salarioMinimo;

            Console.WriteLine("O funcionário ganha {0} salários mínimos",qtdSalario);
        }
    }
}
