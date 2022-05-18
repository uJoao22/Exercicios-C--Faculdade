using System;

namespace Atv04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que defina um vetor de 120 caracteres, incluindo brancos e: • Calcule e imprima quantos brancos existem na frase • Calcule e imprima quantas vezes aparece a letra P (maiúscula ou minúscula) • Dada  uma  letra  qualquer  fornecida  pelo  teclado,  imprimir  a  primeira  vez  que  ela  aparece  na frase. ");

            Console.WriteLine("Insira uma texto com no máximo 120 caracteres");
            string frase = Console.ReadLine();

            Console.WriteLine("Agora insira um caracter");
            char letra = char.Parse(Console.ReadLine());

            int space=0, letterP=0, idxLetra=-1;

            for(int i=0; i<frase.Length; i++) {
                if(frase[i] == ' ')
                    space++;
                if(frase[i] == 'p' || frase[i] == 'P')
                    letterP++;
                if((frase[i] == char.ToUpper(letra) || frase[i] == char.ToLower(letra)) && idxLetra == -1) 
                    idxLetra = i;
            }

            Console.WriteLine("Existem {0} espaços em brancos\nA letra P aparece {1} vezes na frase\nA letra {2} aparece pela primeira vez na frase na posição {3}", space, letterP, letra, idxLetra);

        }
    }
}
