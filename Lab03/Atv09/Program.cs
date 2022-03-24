using System;

namespace Atv09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um programa para o cálculo do salário líquido de um funcionário, levando-se em conta: ");
            Console.WriteLine("a. Salário Bruto = horas trabalhadas * salário hora; ");
            Console.WriteLine("b. Desconto = 0% do salário bruto, se este for menor que R$350,00 ");
            Console.WriteLine("c. Desconto = 10% do salário bruto, se este for maior que R$350,00 e menor que R$1000,00 ");
            Console.WriteLine("d. Desconto = 20% do salário bruto, se este for maior que R$1000,00. ");
            Console.WriteLine("Os valores de horas trabalhadas e salário hora deverão ser recebidos através do dispositivo de entrada. Sabe-se ainda que o salário líquido é igual ao salário bruto subtraído do desconto. ");
        
            Console.WriteLine("Informe a quantidade de horas trabalhadas");
            double horaTrab = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do salário por hora");
            double salHora = double.Parse(Console.ReadLine());

            double salBruto = horaTrab * salHora;
            double salLiquido = salBruto;

            if(salBruto >= 1000) 
                salLiquido -= salBruto*0.20;
            else if(salBruto >= 350 && salBruto < 1000)
                salLiquido -= salBruto*0.10;

            Console.WriteLine("O salário bruto é: R$ {0}\nO salário liquído é: R$ {1}", salBruto.ToString("N2"), salLiquido.ToString("N2"));

        }
    }
}
