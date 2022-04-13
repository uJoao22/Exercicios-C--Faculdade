using System;

namespace Atv08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um algoritmo que calcula o N-ésimo termo da seqüência de Fibonacci, onde um termo é calculado pela soma dos anteriores (1, 1, 2, 3, 5, 8, 13, 21, ...) utilizando o comando while e o do-while ");

            int i=1, soma=1, ultimo=0;
            do {
                soma += ultimo;
                

                i++;
            } while(i<10);

        }
    }
}
