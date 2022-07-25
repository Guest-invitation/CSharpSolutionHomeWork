// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

using System.Collections.Generic;

namespace GB.Task60
{
    class Program
    {
        static void Main(string[] asgs)
        {
            int[,,] matrix = new int[2, 2, 2];
            List<int> list = new List<int>();
            GetList(list);
            // PrintList(list);
            FillMatrix(matrix, list);
            Console.WriteLine("Сгенерирован трехмерный массив размера 2х2х2: ");
            PrintMatrix(matrix);
        }

        public static void GetList(List<int> list)
        {
            for (int i = 10; i < 100; i++)
            {
                list.Add(i);
            }
        }
        public static void PrintList(List<int> list)
        {
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
        }
        public static int[,,] FillMatrix(int[,,] matrixF, List<int> list)
        {
            for (int i = 0; i < matrixF.GetLength(0); i++)
            {
                for (int j = 0; j < matrixF.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixF.GetLength(2); k++)
                    {
                        int n = new Random().Next(0, list.Count);
                        matrixF[i, j, k] = list[n];
                        list.RemoveAt(n);
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