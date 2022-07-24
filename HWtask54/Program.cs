// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию 
// элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

namespace GB.Task54
{
    class Program
    {
        static void Main(string[] asgs)
        {
            int[,] matrix = new int[3, 4];
            FillMatrix(matrix);
            PrintMatrix(matrix);
            GetMatrixStructure(matrix);
            Console.WriteLine();
            PrintMatrix(matrix);
        }

        public static int[,] FillMatrix(int[,] matrixF)
        {
            for (int i = 0; i < matrixF.GetLength(0); i++)
            {
                for (int j = 0; j < matrixF.GetLength(1); j++)
                {
                    matrixF[i, j] = new Random().Next(1, 10);
                }
            }
            return matrixF;
        }

        public static int[,] PrintMatrix(int[,] matrixP)
        {
            for (int i = 0; i < matrixP.GetLength(0); i++)
            {
                for (int j = 0; j < matrixP.GetLength(1); j++)
                {
                    Console.Write(matrixP[i, j] + " | ");
                }
                Console.WriteLine();
            }
            return matrixP;
        }

        public static int[,] GetMatrixStructure(int[,] matrixS)
        {
            for (int i = 0; i < matrixS.GetLength(0); i++)
            {
                int min = matrixS[i, 0];
                for (int j = 0; j < matrixS.GetLength(1); j++)
                {
                    int minPos = j;
                    for (int jSecond = j + 1; jSecond < matrixS.GetLength(1); jSecond++)
                    {
                        if (matrixS[i,minPos] > matrixS[i, jSecond])
                        {
                            minPos = jSecond;
                        }
                    }
                    int change = matrixS[i,minPos];
                    matrixS[i,minPos] = matrixS[i,j];
                    matrixS[i,j] = change;
                }
            }
            return matrixS;
        }
    }
}