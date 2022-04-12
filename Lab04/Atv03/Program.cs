using System;

namespace Atv03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No ocidente estamos acostumados com o nosso formato de datas composto de dias, meses e anos e todas as regras para meses de 28, 30 e 31 dias, além dos anos bissextos. Mas esse nosso calendário, chamado de Gregoriano, foi uma evolução do calendário Juliano (do imperador Julio Cesar). E atualmente ainda se usa (em astronomia, cronologia e alguns sistemas) a Data Juliana. Este formato de data ignora a existência dos meses e é formado APENAS do Ano e o Dia, sendo esse dia um número que vai de 1 a 365 (respectivamente de 1º de janeiro à 31 de dezembro). Como algoritmos também é cultura, faça um programa que leia uma data gregoriana nos seus três valores: dia, mês e ano, e a converta para o formato de data Juliana: DiaJuliano e Ano. Exemplo:");
            Console.WriteLine("a. 01 / 01 / 2009 => 1/2009");
            Console.WriteLine("b. 01 / 02 / 2009 => 32/2009 ( os 31 dias de janeiro + 1)");
            Console.WriteLine("c. 19 / 09 / 2009 => 262.2009 ( os dias de jan a agosto + 19)");

            Console.WriteLine("Informa a data Gregoriana. No formato (dd/mm/yyyy)");
            string[] dataGregoriana = Console.ReadLine().Split("/");

            DateTime data = new DateTime(
                int.Parse(dataGregoriana[2]), 
                int.Parse(dataGregoriana[1]), 
                int.Parse(dataGregoriana[0])
            );

            Console.WriteLine("{0}/{1}", data.DayOfYear, data.Year);
        }
    }
}
