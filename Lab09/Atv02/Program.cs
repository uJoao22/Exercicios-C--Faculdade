using System;

namespace Atv02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa que leia um conjunto de números e os guarde em um vetor. Depois conte e imprima quantos números positivos e a seguir imprima estes números. Depois conte e imprima quantos números negativos e quais são eles. ATENÇÃO: os números positivos e negativos podem ser digitados em qualquer ordem, mas devem ser listados separados (os positivos primeiro, os negativos depois).");

            int[] nums = new int[6]; 
            int positivos=0, negativos=0;

            for(int i=0; i<nums.Length; i++) {
                Console.WriteLine("informe um valor");
                nums[i] = int.Parse(Console.ReadLine());
                if(nums[i] > 0)
                    positivos++;
                else
                    negativos++;
            }
            // POSITIVOS
            Console.WriteLine("Número positivos: "+positivos);
            Console.Write("São eles: ");
            for(int i=0; i<nums.Length; i++){
                if(nums[i]>0)
                    Console.Write(nums[i]+", ");
            }
            // NEGATIVOS
            Console.WriteLine("\nNúmero negativos: "+negativos);
            Console.Write("São eles: ");
            for(int i=0; i<nums.Length; i++){
                if(nums[i]<0)
                    Console.Write(nums[i]+", ");
            }
        }
    }
}
