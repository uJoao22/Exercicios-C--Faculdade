using System;

namespace Atv04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acrescente comandos no exercício 2 que permita que o programa seja executado várias vezes, a exemplo do que foi feito no exercício 3.");
            
            char loop;
            do{
                double soma=0, num=1;
                int i = 0;
                while(num!=0) {
                    Console.WriteLine("\nPara encerar o programa digite 0");
                    Console.WriteLine("Informe o número: ");
                    num = double.Parse(Console.ReadLine());
                    soma += num;
                    if(num!=0)
                        i++;
                }

                Console.WriteLine("\nA soma dos valores anterios é de: {0:0.00}", soma);
                Console.WriteLine("Foram lidos {0} valores", i);

                Console.WriteLine("\nDeseja rodar o programa novamente? (S / N)");
                loop = char.Parse(Console.ReadLine());
            } while(loop == 'S' || loop == 's');

        }
    }
}
