using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace arrays
{
    public class Biblioteca
    {
        public static void createArray(int[] vetor)
        {
           for(int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void createArray(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]:");
                vetor[i] = double.Parse(Console.ReadLine());
            }
        }

        public static void buildArray(int[] vetor)
        {
           Random random = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 6);

            }
        }
        public static void buildArray(double[] vetor)
        {
            Random random = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100)+random.NextDouble();

            }
        }

        public static void showArray(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"| {vetor[i]} ");
            }
        }
        public static void showArray(char[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"| {vetor[i]} ");
            }
        }
        public static void showArray(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"| {vetor[i]:F2} ");
            }
        }

    }
}
