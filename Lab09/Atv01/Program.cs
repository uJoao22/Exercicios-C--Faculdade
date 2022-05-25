using System;

namespace Atv01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declare na função main() dois vetores de inteiros A e B. Usando a função acima, ler dois conjuntos de 10 números, colocando cada conj em um vetor. Depois prencha um terceiro vetor C[] sendo que cada posição de C[] deverá correponder ao menor valor correspondente às respectivas posições nos vetores A[] e B[]. Finalmente imprima o resultado de C[]. ");

            float[] A = new float[10];
            float[] B = new float[10];

            LeVetor(A);
            LeVetor(B);

            ImprimeC(A, B);
        }

        static void LeVetor(float[] vetor) {
            for (int i = 0; i < vetor.Length; i++) {
                Console.Write("Entre com a nota do {0}° aluno: ", i+1);
                vetor[i] = float.Parse(Console.ReadLine());
            }
        }

        static void ImprimeC(float[] vetorA, float[] vetorB) {
            for (int i=0; i<vetorA.Length; i++)
                Console.WriteLine("A menor nota foi: {0}, do aluno: {1}",
                vetorA[i] < vetorB[i] ? vetorA[i] : vetorB[i], vetorA[i] < vetorB[i] ? 'A' : 'B');
        }

    }
}
