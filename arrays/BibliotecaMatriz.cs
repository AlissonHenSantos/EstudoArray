using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class BibliotecaMatriz
    {
        public static void readMatriz(int[,] array)
        {
            int line = array.GetLength(0);
            int col = array.GetLength(1);
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Digite um valor");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void showMatriz(int[,] array)
        {
            int line = array.GetLength(0);
            int col = array.GetLength(1);

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"| {array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void buildMatriz(int[,] array)
        {
            Random rand = new Random();
            int line = array.GetLength(0);
            int col = array.GetLength(1);
            
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    
                    array[i, j] = rand.Next(1, 100);
                }
            }
        }
    }
}
