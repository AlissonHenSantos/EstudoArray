using System;
using static arrays.Biblioteca;
namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Tamanho do vetor:");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            buildArray(arr);

          
          
         
           
            
           

        }

        static int somaVetor(int[] vetor)
        {
            int soma = 0;

            for(int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }

            return soma;
        }

        static int maior(int[] vetor)
        {
            int maior = 0;

            for (int i = 0;i < vetor.Length;i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
            }

            return maior;
        }
        static int menor(int[] vetor)
        {
            int menor = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < menor || menor == 0)
                {
                    menor = vetor[i];
                }
            }

            return menor;
        }
        
        static int qntImpar(int[] vetor)
        {
            int qnt = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0 )
                {
                    qnt++;
                }
            }
        
            return qnt;
        }

        static void multArray(int[] array1, int[] array2, int[] array3)
        {
            for(int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] * array2[i];
               
            }
            for(int i = 0;i < array3.Length; i++)
            {
                Console.WriteLine($" | {array3[i]} ");
            }


        }

        static void reverse(int[] array) 
        { 
            for(int i = array.Length - 1 ; i >= 0; i--)
            {
                Console.Write("| " + array[i]);
            }
        
        }

        static void dado(int[] array)
        {
            int[] dado = { 0, 0, 0, 0, 0, 0 };


            for (int i = 0; i < array.Length; i++)
            {
                switch (array[i])
                {
                    case 1: dado[0]++;
                        break;
                    case 2: dado[1]++;
                        break;
                    case 3: dado[2]++;
                        break;
                    case 4: dado[3]++;
                        break;
                    case 5: dado[4]++;
                        break;
                    case 6: dado[5]++;
                        break;
                }
            }
            for (int i = 0; i < dado.Length; i++)
            {
                Console.WriteLine("\n" + dado[i]);
            }

        }

        static string response(int[] array)
        {
            int chute = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (chute == array[i])
                {
                    return "O numero consta no vetor";
                }
            }

            return "O número não está no vetor";
            
        }
    }
}
