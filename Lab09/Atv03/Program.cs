using System;

namespace Atv03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em uma cidade sabe-se que, em janeiro de um certo ano, não ocorreu temperatura inferior a 15°C, nem superior a 40°C.  Faça um programa que leia as temperaturas diárias (dos 10 primeiros dias) calcule e imprima: a) A menor e a maior temperatura ocorrida; b) A temperatura média; c)Em quais dias a temperatura foi inferior a temperatura média");

            double[] dias = new double[10];

            for(int i=0; i<dias.Length; i++) {
                Console.WriteLine("Insira a temperatura do dia {0}° dia de janeiro: ", i+1);
                dias[i] = double.Parse(Console.ReadLine());
            }

            double maior=0, menor=999, soma=0;
            menorMaiorSoma(dias, ref maior, ref menor, ref soma);
            tempInfMedia(dias, soma/10);
            Console.WriteLine("A maior temperatura é: {0}°C\nA menor temperatura é: {1}°C\nA temperatura média é: {2}°C", maior, menor, soma/10);
        }

        static void menorMaiorSoma(double[] dd, ref double ma, ref double me, ref double so) {
            for(int i=0; i<dd.Length; i++) {
                if(dd[i]>ma)
                    ma = dd[i];
                if(dd[i]<me)
                    me = dd[i];
                so += dd[i];
            }
        }

        static void tempInfMedia(double[] dd, double media) {
            Console.Write("\nA tempaeratura dos dias: ");
            for(int i=0; i<dd.Length; i++) {
                if(dd[i]<media)
                    Console.Write((i+1)+", ");
            }
            Console.WriteLine("foram inferiores a média");
        }
    }
}
