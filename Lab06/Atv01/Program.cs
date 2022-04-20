using System;

namespace Atv01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que leia um número indeterminado de valores da tela. Quando for informado o valor Zero, o programa deve parar de solicitar os números e exibir a soma dos valores anteriormente digitados. ");

            double soma=0, num=1;
            
            while(num!=0) {
                Console.WriteLine("\nPara encerar o programa digite 0");
                Console.WriteLine("Informe o número: ");
                num = double.Parse(Console.ReadLine());
                soma += num;
            }

            Console.WriteLine("\nA soma dos valores anterios é de: {0:0.00}", soma);
        }
    }
}
