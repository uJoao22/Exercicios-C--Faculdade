using System;

namespace Atv06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça agora uma função que receba uma quantidade de dias corridos e os transforme em dias, meses e anos (retornados como parâmetros de saída), tendo como dia Zero o dia 01/01/1900. Datas negativas são anteriores a este dia.  Para testar essa função utilize a função do exercício anterior para calcular quantos dias, meses e anos entre o dia de hoje e algumas datas especiais");

            Console.WriteLine("\nInsira o valor dos dias");
            int dias = int.Parse(Console.ReadLine());

            int dia=0, mes=0, ano=0;
            convertToDayMonthYear(dias, ref dia, ref mes, ref ano);

            Console.WriteLine("{0} dias, a partir do dia 01/01/1900 é equivalente a: {1}/{2}/{3}", dias, dia, mes, ano);
            
        }

        static void convertToDayMonthYear(int dias, ref int dd, ref int mm, ref int aa) {
            if(dias >= 0) {
                int restoDias=dias;
                do {
                    int aux = (aa==0 || aa%4==0) ? 366 : 365;
                    aa = (dias/aux);
                    restoDias -= aux;
                } while(restoDias >=365);
                aa += 1900;

                for(int i=1; i<=12; i++) {
                    if(i==2) {
                        mm += restoDias/28;
                        restoDias -= 28;
                    } else if(i==4 || i==6 || i==9 || i==11) {
                        mm += restoDias/30;
                        restoDias -= 30;
                    } else {
                        mm += restoDias/31;
                        restoDias -= 31;
                    }
                }


                dd = 1 + (restoDias)%30;
            } else {
                aa = 1899 - (Math.Abs(dias)/365);
                mm = 12 - (Math.Abs(dias)%365)/30;
                dd = 30 - (Math.Abs(dias)%365)%30;
            }
        }
    }
}
