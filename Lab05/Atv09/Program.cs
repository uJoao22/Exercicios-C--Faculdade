using System;

namespace Atv08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um algoritmo que calcula o N-ésimo termo da seqüência de Fibonacci, onde um termo é calculado pela soma dos anteriores (1, 1, 2, 3, 5, 8, 13, 21, ...) utilizando o comando while e o do-while ");

            Console.WriteLine("\n\nDeseja rodar o programa usando:");
            Console.WriteLine("Digite 1 - para while");
            Console.WriteLine("Digite 2 - para do while");

            switch (char.Parse(Console.ReadLine())) {
                case '1': usandoWhile(); break;
                case '2': usandoDoWhile(); break;
                default: Console.WriteLine("Valor inválido"); break;
            }
        }

        static void usandoDoWhile() {
            int i=0, ultimo=0, fib=1;

            do {
                int aux=ultimo;
                ultimo = fib;
                fib = ultimo + aux;
                Console.Write("{0}, ", fib);
                i++;
            } while(i<8);
        }

        static void usandoWhile() {
            int i=0, ultimo=0, fib=1;

            while(i<8) {
                int aux=ultimo;
                ultimo = fib;
                fib = ultimo + aux;
                Console.Write("{0}, ", fib);
                i++;
            }
        }
    }
}
