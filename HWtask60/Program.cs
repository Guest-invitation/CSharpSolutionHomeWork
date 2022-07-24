// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

namespace GB.Task60
{
    class Program
    {
        static void Main(string[] asgs)
        {
            int[,,] matrix = new int[2, 2, 2];
            FillMatrix(matrix);
            Console.WriteLine("Сгенерирован трехмерный массив размера 2х2х2: ");
            PrintMatrix(matrix);
        }

        public static int[,,] FillMatrix(int[,,] matrixF)
        {
            for (int i = 0; i < matrixF.GetLength(0); i++)
            {
                for (int j = 0; j < matrixF.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixF.GetLength(2); k++)
                    {
                        matrixF[i, j, k] = new Random().Next(10, 100);
                    }
                }
            }
            return matrixF;
        }

        public static int[,,] PrintMatrix(int[,,] matrixP)
        {
            for (int i = 0; i < matrixP.GetLength(0); i++)
            {
                for (int j = 0; j < matrixP.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixP.GetLength(2); k++)
                    {
                        Console.WriteLine($"{matrixP[i, j, k]} {(i, j, k)}");
                    }
                }
            }
            return matrixP;
        }
    }
}