using System;
using System.Diagnostics.CodeAnalysis;
using static arrays.Biblioteca;
namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static int somaVetor(int[] vetor) // exercicio 1
        {
            int soma = 0;

            for(int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }

            return soma;
        }

        static int maior(int[] vetor) //exercicio 2
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
        static int menor(int[] vetor) //exercicio 3
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
        
        static int qntImpar(int[] vetor)// exercicio 4
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

        static void multArray(int[] array1, int[] array2, int[] array3)//exercicio 7
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

        static void reverse(int[] array) // exercicio 8
        { 
            for(int i = array.Length - 1 ; i >= 0; i--)
            {
                Console.Write("| " + array[i]);
            }
        
        }

        static void dado(int[] array)// exercicio 10
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

        static string constaArray(int[] array) //exercicio 9
        {
            int chute = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < array.Length; i++)
            {
                if (chute == array[i])
                {
                    showArray(array);
                    return $"\n O numero consta no vetor ";
                }
            }

            return "O número não está no vetor";
            
        }

        static string sortArr(int[] array) // exercicio 6
        {
            int chute = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if(chute == array[i]){
                    return $"Acertou. O elemento está no índice: {i}";
                }
            }
            return "Errou";

        }

        static void dna() //exercicio5
        {
            char[] dna = new char[5];

            for (int i = 0; i < dna.Length; i++)
            {
                dna[i] = char.Parse(Console.ReadLine());
            }

            char[] complementar = new char[dna.Length];
            for (int i = 0; i < dna.Length; i++)
            {
                if (dna[i] == 'a')
                {
                    complementar[i] = 't';
                } else if (dna[i] == 't')
                {
                    complementar[i]= 'a';
                }else if (dna[i] == 'c')
                {
                    complementar[i] = 'g';
                }else if (dna[i] == 'g')
                {
                    complementar[i] = 'c';
                }
            }

            showArray(complementar);




        }

        static void notasCarnaval() //exercicio 12
        {

            double[] notas = new double[5];
            double soma = 0, menor = 0, maior = 0; 

            for (int i = 0; i < notas.Length; i++ )
            {
              
                notas[i] = double.Parse(Console.ReadLine());
                soma += notas[i];
            }
            
            for(int i = 0; i < notas.Length; i++)
            {
                if(menor == 0 || notas[i] < menor)
                {
                    menor = notas[i];
                }
                if (notas[i] > maior)
                {
                    maior = notas[i];
                }
            }
            Console.WriteLine(soma -= menor - maior);

        }

    }
}
