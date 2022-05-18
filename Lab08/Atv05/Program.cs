using System;

namespace Atv05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma função que receba três números representando o dia, mês e ano de uma data. A função deverá calcular quantos dias se passaram entre esta data e o dia 01/01/1900. Para simplificar as coisas considere os meses: 1, 3, 5, 7, 8, 10  e 12 como sendo de 31 dias e os demais 30. Para os “avançadinhos” façam para o caso real, ou seja: fevereiro tem 28 dias exceto em anos bissextos (a cada 4 anos)");

            int dias = calcDias(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            Console.WriteLine("\nDesde o dia 01/01/1900 já se passaram {0} dias", dias);
        }

        static int calcDias(int dia, int mes, int ano) {
            int dias=dia, bi=4;
            for(int i=1900; i<ano; i++) {
                dias = bi%4==0 ? dias+366 : dias+365;
                bi++;
            }
            for(int i=1; i<mes; i++){
                if(i==2){
                    dias = bi%4==0 ? dias+29 : dias+28;
                    continue;
                }
                dias = i==4||i==6||i==9||i==11 ? dias+30 : dias+31;
            }
            return dias;
        }
    }
}
