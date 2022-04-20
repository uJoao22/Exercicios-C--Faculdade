using System;

namespace Atv03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Complete  o  programa  abaixo  que  deverá  calcular  o  Fatorial  de  vários  Números.  A  estrutura  para solicitar diversos números já está pronta, falta apenas o algoritmo do cálculo do fatorial. ");

            int N, Cont, Fat = 1;
            char repetir;
            do{
                Console.WriteLine("EXEMPLO PARA CALCULAR FATORIAL DE N");
                Console.WriteLine("Entre com um valor para cálculo do fatorial: ");
                N = int.Parse(Console.ReadLine());
                int x = N;
                if (N >= 0) {
                    Fat=1;
                    do {
                        Fat = Fat * N;
                        N--;
                    } while(N>1);
                    Console.WriteLine("O fatorial de {0} é {1}", x, Fat);
                }
                else 
                    Console.WriteLine("Não posso calcular fatorial de número negativo");
                
                Console.WriteLine("\n Deseja repetir o programa ? (S / N)");
    
                repetir = Console.ReadKey().KeyChar;

            } while (repetir == 'S' || repetir == 's');
        }
    }
}
