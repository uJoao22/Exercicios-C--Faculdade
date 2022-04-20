using System;

namespace Atv05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foi feita uma pesquisa em um número indeterminado de postos dos preços da gasolina, do álcool e do diesel. Ler para cada posto, os valores  de cada combustível, calcular e imprimir o maior e o menor  valor  encontrado  para  cada  tipo  de  combustível  dentre  os  postos  pesquisados.  Os  dados terminam quando for digitado um valor de preço de gasolina igual a Zero. Colocar no final a opção para repetir tudo de novo. ");
            
            char loop;
            do {
                double i=1, gasolina=1, alcool=0, diesel=0,
                    maiorG=0, maiorA=0, maiorD=0,
                    menorG=99999, menorA=99999, menorD=99999;

                while(gasolina!=0) {
                    Console.WriteLine("\nPOSTO {0}", i);
                    Console.WriteLine("Informe o valor da gasolina");
                    gasolina = double.Parse(Console.ReadLine());
                    if(gasolina==0) continue;
                    maiorG = gasolina > maiorG ? gasolina : maiorG;
                    menorG = gasolina < menorG ?  gasolina : menorG;

                    Console.WriteLine("\nInforme o valor do álcool");
                    alcool = double.Parse(Console.ReadLine());
                    maiorA = alcool > maiorA ? alcool : maiorA;
                    menorA = alcool < menorA ?  alcool : menorA;

                    Console.WriteLine("\nInforme o valor do Diesel");
                    diesel = double.Parse(Console.ReadLine());
                    maiorD = diesel > maiorD ? diesel : maiorD;
                    menorD = diesel < menorD ?  diesel : menorD;

                    i++;
                }

                Console.WriteLine("\nO maior valor da gasolina foi: {0}, e o menor foi: {1}", maiorG, menorG);
                Console.WriteLine("\nO maior valor do álcool foi: {0}, e o menor foi: {1}", maiorA, menorA);
                Console.WriteLine("\nO maior valor do diesel foi: {0}, e o menor foi: {1}", maiorD, menorD);

                Console.WriteLine("\nDeseja rodar o programa novamente? (S / N)");
                loop = char.Parse(Console.ReadLine());
            } while(loop== 'S' || loop == 's');

        }
    }
}
