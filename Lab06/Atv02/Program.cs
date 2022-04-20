using System;

namespace Atv02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acrescente  um  contador  no  programa  anterior  para  informar  a  quantidade  de  valores  que  foram lidos. ");

            double soma=0, num=1;
            int i = 0;
            
            while(num!=0) {
                Console.WriteLine("\nPara encerar o programa digite 0");
                Console.WriteLine("Informe o número: ");
                num = double.Parse(Console.ReadLine());
                soma += num;
                if(num!=0)
                    i++;
            }

            Console.WriteLine("\nA soma dos valores anterios é de: {0:0.00}", soma);
            Console.WriteLine("Foram lidos {0} valores", i);
        }
    }
}
