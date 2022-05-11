using System;

namespace Atv04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma função que receba como parâmetro de entrada, a quantidade de segundos e, calcule e retorne como parâmetros de saída, três inteiros representando a: hora, minutos e segundos equivalentes. Exemplo:   9.610 segundos = 2h, 40 min e 10 seg. Use como parâmetros de saída parâmetros do tipo: (ref int var) ");

            Console.Write("\n{0} segundos = ", DateTime.Now.Hour + (DateTime.Now.Minute*60) + (DateTime.Now.Hour*60*60));

            int hora=0, min=0, seg=0;
            convertToHourMinSeg(DateTime.Now.Hour + (DateTime.Now.Minute*60) + (DateTime.Now.Hour*60*60), ref hora, ref min, ref seg);
            
            Console.Write("{0}h, {1}min e {2}seg = ", hora, min, seg);
        }

        static void convertToHourMinSeg(int segundos, ref int hh, ref int mm, ref int ss) {
            hh = segundos/3600;
            mm = (segundos-(hh*60*60))/60;
            ss = (segundos-(hh*60*60)-(mm*60));
        }
    }
}
