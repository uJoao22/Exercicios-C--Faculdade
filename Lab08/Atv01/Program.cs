using System;

namespace Atv01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que contenha uma função que receba dois números inteiros como parâmetro de entrada e leia um valor do teclado que esteja entre os dois parâmetros passados. A função deve retornar o número correto para o programa principal e este deve imprimir o valor lido. ");

            int dia, mes; 
            Console.WriteLine("\nInforme o dia entre 1 e 31: ");       
            dia = le_no_intervalo(1, 31); 
            Console.WriteLine("Informe o mes entre 1 e 12: ");     
            mes = le_no_intervalo(1, 12); 
            Console.WriteLine("Data: {0}/{1}", dia, mes); 

            
        }

        static int le_no_intervalo(int n1, int n2) {
            int valor=0;
            do{
                valor = int.Parse(Console.ReadLine());
                if(valor<n1 || valor>n2)
                    Console.WriteLine("Valor inválido. Insira outro número");
            } while (valor<n1 || valor>n2);
            return valor;
        }
    }
}
