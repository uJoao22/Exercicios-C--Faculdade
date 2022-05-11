using System;

namespace Atv05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma função que receba três números representando o dia, mês e ano de uma data. A função deverá calcular quantos dias se passaram entre esta data e o dia 01/01/1900. Para simplificar as coisas considere os meses: 1, 3, 5, 7, 8, 10  e 12 como sendo de 31 dias e os demais 30. Para os “avançadinhos” façam para o caso real, ou seja: fevereiro tem 28 dias exceto em anos bissextos (a cada 4 anos)");

            calcDias(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            
        }

        static void calcDias(int dia, int mes, int ano) {
            Console.WriteLine(dia+"/"+mes+"/"+ano);
        }
    }
}
