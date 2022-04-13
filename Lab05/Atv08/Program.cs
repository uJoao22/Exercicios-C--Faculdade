using System;

namespace Atv08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um programa que leia vários números, menores que 13, enquanto a soma desses números for menor que 21. Deve aparecer na tela o número de números que já foram lidos e a frase “Ainda não acabou; caso a soma seja maior que 21 deve aparecer o número de números lidos e a frase “Acabou – você perdeu”; caso a soma dos números seja igual a 21 deve aparecer na tela “Acabado, soma = 21 – você ganhou.” ");

            int soma=0, i=1;
            do {
                Console.WriteLine("Informe um número inteiro menor que 13");
                int num = int.Parse(Console.ReadLine());
                soma += num;
                
                if(soma<21) {
                    Console.WriteLine("Já foram lidos {0} números", i);
                    Console.WriteLine("Ainda não acabou");
                } else
                    break;

                i++;
            } while (soma<21);

            if (soma==21)
                Console.WriteLine("Acabado, soma = 21 - você ganhou");
            else if(soma>21){
                Console.WriteLine("Foram lidos {0} números", i);
                Console.WriteLine("Acabou - você perdeu");
            }
        }
    }
}
