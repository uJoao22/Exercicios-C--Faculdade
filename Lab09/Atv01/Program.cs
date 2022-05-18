using System;

namespace Atv01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declare na função main() dois vetores de inteiros A e B. Usando a função acima, ler dois conjuntos de 10 números, colocando cada conj em um vetor. Depois prencha um terceiro vetor C[] sendo que cada posição de C[] deverá correponder ao menor valor correspondente às respectivas posições nos vetores A[] e B[]. Finalmente imprima o resultado de C[]. ");

            int[] a = new int[10];
            int[] b = new int[10];

            int[] teste = LeVetor(a);
            Console.WriteLine(teste);
        }

        static int[] LeVetor(int []vetor) { 
            for (int i=0; i<vetor.Length; i++) { 
                Console.Write("Entre com a nota do aluno [{0}]", i+1);    
                vetor[i] = int.Parse(Console.ReadLine()); 
            } 
            return vetor;
        } 
    }
}
