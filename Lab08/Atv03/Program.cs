using System;

namespace Atv03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma função que receba três números inteiros como parâmetros, representando horas, minutos e segundos, e retorne o seu valor convertido em segundos. Exemplo:  2h, 40 min e 10 seg  =  9.610 segundos ");

            Console.Write("\n{0}h, {1}min e {2}seg = ", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            Console.Write("{0} segundos", convertToSegs(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
        }

        static int convertToSegs(int hh, int mm, int ss) {
            return ss + (mm*60) + (hh*60*60);
        }
    }
}
