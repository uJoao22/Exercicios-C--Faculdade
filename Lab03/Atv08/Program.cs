using System;

namespace Atv08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler quatro notas (de 0 a 100) de um aluno; calcular a média aritmética das notas; verificar se o aluno foi aprovado ou não. (média deve ser maior ou igual a 60) ");
        
            Console.WriteLine("\nInforma as notas de 0 a 100");
            Console.WriteLine("Informe a 1º nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a 2º nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a 3º nota do aluno: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a 4º nota do aluno: ");
            double nota4 = double.Parse(Console.ReadLine());

            if((nota1>=0 && nota1<=100) && (nota2>=0 && nota2<=100) && (nota3>=0 && nota3<=100) && (nota4>=0 && nota4<=100)) {
                double media = (nota1+nota2+nota3+nota4)/4;
                
                if(media >= 60) 
                    Console.WriteLine("Aluno APROVADO");
                else
                    Console.WriteLine("Aluno REPROVADO");
            } else {
                Console.WriteLine("Notas inválidas");
            }
        }
    }
}
