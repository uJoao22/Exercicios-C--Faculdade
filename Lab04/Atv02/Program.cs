using System;

namespace Atv02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No livro “O Nome da Rosa” o ritmo da narrativa segue o mesmo da rotina dos monges que se baseia nas horas canônicas. Estas horas são consideradas especiais para estes monges e correspondem aos seguintes nomes e horários:");
            Console.WriteLine("a. Matinas - 3 h");
            Console.WriteLine("b. Laudes - 5 h (aprox. – ao amanhecer)");
            Console.WriteLine("c. Prima - 7 h ");
            Console.WriteLine("d. Tercia - 9 h");
            Console.WriteLine("e. Sexta - meio dia");
            Console.WriteLine("f. Noa - 15 h");
            Console.WriteLine("g. Vésperas - 18 h (aprox. – ao por do sol)");
            Console.WriteLine("h. Completas- 21 h");
            Console.WriteLine("Faça um programa que leia a hora atual (um numero entre 0 e 23) e informe se a hora corresponde a alguma das horas canônicas ou mande a mensagem “Não é uma hora canônica");

            DateTime data = DateTime.Now;
            int hora = data.Hour;
            
            switch (hora) {
                case 3: Console.WriteLine("Matinas"); break;
                case 5: Console.WriteLine("Laudes"); break;
                case 7: Console.WriteLine("Prima"); break;
                case 9: Console.WriteLine("Tercia"); break;
                case 12: Console.WriteLine("Sexta"); break;
                case 15: Console.WriteLine("Noa"); break;
                case 18: Console.WriteLine("Vésperas"); break;
                case 21: Console.WriteLine("Completas"); break;
                default: Console.WriteLine("Não é uma hora canônica"); break;
            }
        }
    }
}
