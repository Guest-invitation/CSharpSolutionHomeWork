// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

namespace GB.Task56
{
    class Program
    {
        static void Main(string[] asgs)
        {
            int[,] matrix = new int[5, 4];
            FillMatrix(matrix);
            PrintMatrix(matrix);
            int [] arraySum = new int [matrix.GetLength(0)];
            GetSumRow(matrix, arraySum);
            Console.WriteLine();
            for(int i = 0; i < arraySum.Length; i++)
            {
                Console.WriteLine($" Сумма элементов {i+1} строки равна {arraySum[i]}");
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальная сумма элементов находится на {GetMinSum(arraySum)+1} и равна {arraySum[GetMinSum(arraySum)]}");
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

        public static int [] GetSumRow(int [,] matrixMain, int [] arrayS)
        {
            for (int i = 0; i < matrixMain.GetLength(0); i++)
            {
                int resultSumRow = 0;
                for (int j = 0; j < matrixMain.GetLength(1); j++)
                {
                    resultSumRow = resultSumRow + matrixMain[i,j];
                }
                arrayS[i] = resultSumRow;
                Console.WriteLine();
            }
            return arrayS;
        }

        public static int GetMinSum(int [] array)
        {
            int min = array[0];
            int minPos = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                    minPos = i;
                }
            }
            return minPos;
        }
    }
}