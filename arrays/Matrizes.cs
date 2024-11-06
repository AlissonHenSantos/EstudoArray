using System;
using arrays;
namespace arrays
{
    internal class Matrizes
    {
        static void Main()
        {
            int line = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            int[,] matriz = new int[line, col];
            arrays.BibliotecaMatriz.buildMatriz(matriz);
            maior(matriz);

        }
        static void maior(int[,] matriz)
        {
            int line = matriz.GetLength(0);
            int col = matriz.GetLength(1);
            int maior = matriz[0, 0];
            arrays.BibliotecaMatriz.showMatriz(matriz);
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matriz[i,j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }
            }
            Console.WriteLine($"O maior elemento é: {maior}");
        }
    }
}
